using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WaterCalm.SimTruckPadPlugin
{
    public class SharedMemory
    {
        private const uint defaultMapSize = 32 * 1024;
        private const string memoryFileName = "Local\\SCSTelemetry";
        private telemetry.memoryMap memoryMap = new telemetry.memoryMap();

        public bool Hooked { get; private set; }
        public Exception HookException { get; private set; }
        public byte[] RawData { get; private set; }
        public dynamic DataValue { get; private set; }

        private MemoryMappedFile _memoryMappedFile;
        private MemoryMappedViewAccessor _memoryMappedViewAccessor;

        public void Connect()
        {
            uint mapSize = defaultMapSize;
            string mapName = memoryFileName;

            if (Hooked)
            {
                Disconnect();
            }

            try
            {
                RawData = new byte[mapSize];

                _memoryMappedFile = MemoryMappedFile.CreateOrOpen(mapName, mapSize, MemoryMappedFileAccess.ReadWrite);
                _memoryMappedViewAccessor = _memoryMappedFile.CreateViewAccessor(0, mapSize);

                Hooked = true;
            } catch (Exception e)
            {
                Hooked = false;
                HookException = e;
            }
        }

        public void Disconnect()
        {
            Hooked = false;
            _memoryMappedFile.Dispose();
            _memoryMappedViewAccessor.Dispose();
        }

        public dynamic GetValue(string PropName)
        {
            string _propName = $"telemetry.{PropName}";
            dynamic _memMap;

            if (memoryMap.memorys_map.ContainsKey(_propName))
            {
                _memMap = memoryMap.memorys_map[_propName];
                
                if (_memMap.GetType().BaseType == typeof(Array))
                {

                    JArray _values = new JArray();
                    
                    for(int i=0; i<_memMap.Length; i++)
                    {
                        _values.Add(new JValue(convertData(_memMap[i])));
                    }

                    return _values.ToString();

                } else
                {
                    return convertData(_memMap);
                }
            }

            
            return null;
        }

        private dynamic convertData(telemetry.memoryMap.memoryTuple memoryTuple)
        {
            int sidx = memoryTuple.startIndex;
            int len = memoryTuple.length;
            string vtype = memoryTuple.valueType;
            byte[] _temp = new byte[len];

            _memoryMappedViewAccessor.ReadArray(sidx, _temp, 0, _temp.Length);

            if (vtype == "bool")
            {
                return getBool(_temp);

            }else if (vtype == "char")
            {
                return getString(_temp);

            }else if (vtype == "unsigned long long")
            {
                return getULong(_temp);

            }else if (vtype == "unsigned int")
            {
                return getUint(_temp);

            }else if (vtype == "int")
            {
                return getInt(_temp);

            }else if (vtype == "float")
            {
                return getFloat(_temp);

            }else if (vtype == "double")
            {
                return getDouble(_temp);

            }else if (vtype == "long long")
            {
                return getLong(_temp);
            }   
            return null;
        }

        private bool getBool(byte[] data)
        {
            return BitConverter.ToBoolean(data, 0);
        }

        private string getString(byte[] data)
        {
            return Encoding.UTF8.GetString(data).Replace('\0', ' ').Trim();
        }

        private uint getUint(byte[] data)
        {
            return BitConverter.ToUInt32(data, 0);
        }

        private float getFloat(byte[] data)
        {
            return BitConverter.ToSingle(data, 0);
        }

        private double getDouble(byte[] data)
        {
            return BitConverter.ToDouble(data, 0);
        }

        private int getInt(byte[] data)
        {
            return BitConverter.ToInt32(data, 0);
        }

        private long getLong(byte[] data)
        {
            return BitConverter.ToInt64(data, 0);
        }

        private ulong getULong(byte[] data)
        {
            return BitConverter.ToUInt64(data, 0);
        }

    }
}
