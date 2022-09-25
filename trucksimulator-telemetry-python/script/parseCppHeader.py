from datetime import datetime
import os
import sys
import CppHeaderParser, json, struct


CPP_HEADER_LOAD = None

define_map = {
    'stringsize': 64,
    'WHEEL_SIZE': 14,
    'SUBSTANCE_SIZE': 25
}

struct_type_map = {
    'bool': '?',
    'char': 's',
    'unsigned long long': 'Q',
    'unsigned int': 'I',
    'int': 'i',
    'float': 'f',
    'double': 'd',
    'long long': 'q', 
}

value_type = [
    'common', 
    'config', 
    'truck', 
    'gameplay', 
    'job', 
    'special', 
    'substances', 
    'trailer',
    'con',
    'com'
]

def getProp(prop, bytes_index=0):
    
    result = {}
    
    for p in prop['properties']['public']:
        _name = p['name']            
        _type = p['type']
        _array = p['array']
        _array_size = 1
        if _array > 0:
            _array_size = p['array_size']
            try:
                _array_size = int(_array_size)
            except (TypeError, ValueError):
                if _array_size in define_map.keys():
                    _array_size = define_map[_array_size]
                else:
                    _array_size = 1

        if _type in struct_type_map.keys():
            _prop_list = []
            fmt = struct_type_map[_type]
            
            if _array > 0:
                if _type == 'char' and _name != 'substance':
                    fmt = f'{_array_size}{fmt}'
                    
                else:
                    if _name == 'substance':
                        fmt = f'{define_map["stringsize"]}{fmt}'
                        _array_size = define_map['SUBSTANCE_SIZE']
                    
                    for _ in range(_array_size):
                        bytes_len = struct.calcsize(fmt)
                        _prop_list.append(
                            ( fmt, bytes_index, bytes_len, _type )
                        )
                        bytes_index += bytes_len
                        
            if len(_prop_list) > 0:
                _prop = _prop_list
            else:
                bytes_len = struct.calcsize(fmt)
                _prop = ( fmt, bytes_index, bytes_len, _type )
                bytes_index += bytes_len
            
            if _name.startswith('buffer') or _name.startswith('placeHolder'):
                continue
            
            result.update({
                _name: _prop
            })

        else:
            _raw_type = p['raw_type']
            _property_of_class = p['property_of_class']
            _struct_name = f'{_property_of_class}::{_type}'
            
            if _raw_type.startswith('::'):
                _struct_name = _type
            sub_struct = CPP_HEADER_LOAD['classes'][_struct_name]
            if _array>0:
                _r = []
                
                for _i in range(_array_size):
                    _r_temp, _bi = getProp(sub_struct, bytes_index)
                    _r.append(_r_temp)
                    bytes_index = _bi
                
            else:
                _r, _bi = getProp(sub_struct, bytes_index)
                bytes_index = _bi

            if _name.split('_')[0] in value_type:
                _name = _name.split('_')[0]

            if _name in result.keys():
                result.update({ _name: {**result[_name], **_r} })
            else:
                result.update({ _name: _r })

    
    return result, bytes_index

def parseHeader(file_name):
    
    if not os.path.exists(file_name):
        print('请输入正确的文件名')
        return

    cppHeader = CppHeaderParser.CppHeader(file_name)
    global CPP_HEADER_LOAD
    CPP_HEADER_LOAD = json.loads(cppHeader.toJSON())
    scsTelemetryMap_t = CPP_HEADER_LOAD['classes']['scsTelemetryMap_t']
    return getProp(scsTelemetryMap_t)