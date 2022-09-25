import sys, os, jinja2, datetime

from parseCppHeader import parseHeader

TRAILER_SIZE = 10

def getHashtable(data, father='telemetry'):
    _el = []
    if type(data) == dict:
        for k,v in data.items():
            if type(v) == dict:
                _el.extend(getHashtable(v, f'{father}.{k}'))
            elif type(v) == list:
                if k == 'trailer':
                    continue
                if type(v[0]) == tuple:
                    _el.append((f'{father}.{k}', v))
                else:
                    _el.extend(getHashtable(v, f'{father}.{k}'))
            elif type(v) == tuple:
                _el.append((f'{father}.{k}', v))

    elif type(data) == list:
        for idx,vv in enumerate(data):
            _el.extend(getHashtable(vv, f'{father}{idx}'))
    return _el

def getTrailers(data:dict):
    trailer_list = []
    for k,v in data.items():
        if k == 'trailer':
            trailers = getHashtable(v.get('trailer'), 'trailer')
            
            prop_counts = len(trailers) / TRAILER_SIZE
            _count = 0
            _temp = []
            for tr in trailers:
                _key_list = tr[0].split('.')[1:len(tr[0].split('.'))]
                _temp.append(('.'.join(_key_list), tr[1]))
                _count += 1
        
                if _count == prop_counts:
                    _count = 0
                    trailer_list.append(_temp)
                    _temp = []
    return trailer_list

def isTuple(value):
    return type(value)==tuple
def isList(value):
    return type(value)==list

def main():
    try:
        file_name = sys.argv[1]
    except IndexError:
        print('请输入文件名作为脚本参数')
        return
    
    if not os.path.exists(file_name):
        print('请输入正确的文件名')
        return

    env = jinja2.Environment(loader=jinja2.FileSystemLoader('./template/'))
    env.filters['isTuple'] = isTuple
    env.filters['isList'] = isList
    temp = env.get_template('csharp.j2')

    r, i = parseHeader(file_name)

    hashtables = getHashtable(r)
    trailers = getTrailers(r)

    temp_out = temp.render(data={
        'nowtime': datetime.datetime.now(),
        'namespace': 'telemetry', 
        'hashtables': hashtables, 
        'trailers': trailers,
    })

    with open('TelemetryMemoryMap.cs', 'w+') as f:
        f.write(temp_out)

    print('已生成 TelemetryMemoryMap.cs 文件')

if __name__ == '__main__':
    main()