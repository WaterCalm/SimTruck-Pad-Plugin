import os, sys

from datetime import datetime

from parseCppHeader import parseHeader


def main():
    try:
        file_name = sys.argv[1]
    except IndexError:
        print('请输入文件名作为脚本参数')
        return
    
    if not os.path.exists(file_name):
        print('请输入正确的文件名')
        return

    r, i = parseHeader(file_name)

    with open('telemetry_memory_map.py', 'w+') as f:
        f.write(
            f'#create_time  {datetime.now()}\n'
            f'memory_map={r}'
        )

    print('已生成 telemetry_memory_map.py 文件')


if __name__ == '__main__':
    main()