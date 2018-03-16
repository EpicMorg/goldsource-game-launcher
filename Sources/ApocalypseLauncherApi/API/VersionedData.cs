using System;
using Newtonsoft.Json;

namespace ApocalypseLauncherApi.API
{

    public class VersionedData
    {
        public Version Version { get; set; }
        public int Api { get; set; }

        public static VersionedData Load(string data)
        {
            return SnakeDeserializer.Deserialize<VersionedData>(data);
        }
    }

    public class VersionedData<T> : VersionedData
    {
        public T Data { get; set; }
    }
}