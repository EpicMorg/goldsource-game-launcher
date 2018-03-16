using System;
using System.Collections.Generic;
using System.Threading;

namespace ApocalypseLauncherApi.API.v0
{
    public  class  OwnList
    {
        private static int _newobjectId = 0;
        private static int GetId => Interlocked.Increment(ref _newobjectId);

        private readonly int _objectId = GetId;
        public override string ToString()
        {
            return Name??$"Untitled-{_objectId}";
        }
        public string Name { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; } 
        public string ApiKey { get; set; }
    }
      
    public class FriendList
    {
        public string Name { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
    }

    public class Servers
    {
        public List<OwnList> OwnList { get; set; }
        public List<FriendList> FriendList { get; set; }
    }

    public class VersionedServers : VersionedData<Servers>
    {
        public const int ApiVersion = 1;

        public new static VersionedServers Load(string data)
        {
            var des = SnakeDeserializer.Deserialize<VersionedData>(data);
            if (des.Api == ApiVersion)
                return SnakeDeserializer.Deserialize<VersionedServers>(data);
            throw new ArgumentException("Unknown api version");
        }
    }

    #region  Примеры для того чтобы потом вспомнить то что было задумано

    // Пример полногй несовместимости версии апи 2 (номер - вынесен в отдельный неймспейс!)
    //public class Servers2
    //{
    //    public int Cnt { get; set; }

    //    public Servers2(Servers source)
    //    {
    //        Cnt = -1;
    //        //FriendList = source?.FriendList;
    //        //OwnList = source?.OwnList;
    //    }
    //}

    //Пример версии апи 2, с миграцией с 1 до 2



    //public class VersionedServers2 : VersionedData<Servers2>
    //{
    //    public const int ApiVersion = 2;

    //    public new static VersionedServers2 Load(string data)
    //    {
    //        var des = SnakeDeserializer.Deserialize<VersionedData>(data);
    //        if (des.Api < ApiVersion)
    //            return ((VersionedServers2)VersionedServers.Load(data));
    //        if (des.Api == ApiVersion)
    //            return SnakeDeserializer.Deserialize<VersionedServers2>(data);
    //        // else(des.Api>1)
    //        throw new ArgumentException("Unknown api version");
    //    }

    //    public static explicit operator VersionedServers2(VersionedServers source)
    //    {
    //        if (source == null) return null;
    //        return new VersionedServers2()
    //        {
    //            Api = ApiVersion,
    //            Version = source.Version,
    //            Data = source.Data != null ? new Servers2(source.Data) : null
    //        };
    //    }
    //}

    // Пример версии апи 3, с миграцией с 2 до 3 (дальше по аналогии!)
    //
    //public class VersionedServers3 : VersionedData<Servers3>
    //{
    //    public const int ApiVersion = 3;
    //    public new static VersionedServers3 Load(string data)
    //    {
    //        var des = SnakeDeserializer.Deserialize<VersionedData>(data);
    //        if (des.Api < ApiVersion)
    //            return ((VersionedServers3)VersionedServers1.Load(data));
    //        if (des.Api == ApiVersion)
    //            return SnakeDeserializer.Deserialize<VersionedServers3>(data);
    //        // else(des.Api>1)
    //        throw new ArgumentException("Unknown api version");
    //    }
    //    public static explicit operator VersionedServers3(VersionedServers1 source)
    //    {
    //        if (source == null) return null;
    //        return new VersionedServers3()
    //        {
    //            Api = ApiVersion,
    //            Version = source.Version,
    //            Data = (Servers3)source.Data
    //        };
    //    }
    //}

    //public class Servers3
    //{
    //    public string[] Addresses { get; set; }

    //    public static explicit operator Servers3(Servers2 v)
    //    {
    //        if (v == null) return null;
    //        return new Servers3()
    //        {
    //            Addresses = v.FriendList.Select(a => a.Ip.ToString()).ToArray()
    //        };
    //    }
    //}

    //class MyClass
    //{
    //     void 
    //}
    /*
        load()
            config = App -> Current[Type] -> Deserialize<Base>

            des = current;
            while(config.Version<current.Version)
                current = current.Parent;
            var deser = current.Deserialize(config)
            return migrate(deser)

        migrate(config)
            co
    */

    #endregion
}