import struct, json

from multiprocessing import shared_memory
from telemetry_memory_map import memory_map


game_type_map = {
    0: 'UnknownGame',
    1: 'ETS2',
    2: 'ATS',
}

def loadMemory():
    try:
        mem = shared_memory.SharedMemory(name='Local\SCSTelemetry')
    except FileNotFoundError:
        mem = None

    return mem

def getData(key:str):
    mem = loadMemory()
    if mem is None:
        return json.dumps({
            'code': -1,
            'data': ''
        })

    key_list = key.split('.')
    value_mem_map = memory_map

    for k in key_list:
        value_mem_map = value_mem_map.get(k)
        if value_mem_map is None:
            return json.dumps({
                'code': -2,
                'key': key,
                'data': ''
            })

    if type(value_mem_map) == tuple:
        fmt, sindex, length, ctype = value_mem_map

        value = struct.unpack(
            fmt,
            mem.buf[sindex:sindex+length].tobytes()
        )

        if ctype == 'char':
            value = [ v.decode('utf8').strip('\x00') for v in value ]
        
        if len(value) == 1:
            value = value[0]

        if key == 'scs_values.game':
            value = game_type_map[value]

        return json.dumps({
            'code': 0,
            'key': key,
            'data': value
        }, ensure_ascii=False)

    else:
        pass

    return