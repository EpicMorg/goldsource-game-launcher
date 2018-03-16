using System.Xml.Serialization;

namespace ApocalypseLauncher.HELPERS
{
   
    [XmlRoot(ElementName = "admin")]
    public class Admin
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
    }

    [XmlRoot(ElementName = "game")]
    public class Game
    {
        [XmlElement(ElementName = "game_code")]
        public string GameCode { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "globalrang")]
    public class Globalrang
    {
        [XmlElement(ElementName = "max_rang")]
        public string MaxRang { get; set; }

        [XmlElement(ElementName = "rang")]
        public string Rang { get; set; }
    }

    [XmlRoot(ElementName = "ip")]
    public class Ip
    {
        [XmlAttribute(AttributeName = "connect")]
        public string Connect { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "rang")]
    public class Rangs
    {
        [XmlElement(ElementName = "max_rang")]
        public string MaxRang { get; set; }

        [XmlElement(ElementName = "rang")]
        public string Rang { get; set; }
    }

    [XmlRoot(ElementName = "server")]
    public class Server
    {
        [XmlElement(ElementName = "admin")]
        public Admin Admin { get; set; }

        [XmlElement(ElementName = "game")]
        public Game Game { get; set; }

        [XmlElement(ElementName = "globalrang")]
        public Globalrang Globalrang { get; set; }

        [XmlElement(ElementName = "homepage")]
        public string Homepage { get; set; }

        [XmlElement(ElementName = "hosting")]
        public string Hosting { get; set; }

        [XmlElement(ElementName = "hostname")]
        public string Hostname { get; set; }

        [XmlElement(ElementName = "ip")]
        public Ip Ip { get; set; }

        [XmlElement(ElementName = "location")]
        public string Location { get; set; }

        [XmlElement(ElementName = "maps")]
        public string Maps { get; set; }

        [XmlElement(ElementName = "ping")]
        public string Ping { get; set; }

        [XmlElement(ElementName = "rang")]
        public Rangs Rangs { get; set; }

        [XmlElement(ElementName = "server_id")]
        public string ServerId { get; set; }

        [XmlElement(ElementName = "u_grang")]
        public UGrang UGrang { get; set; }

        [XmlElement(ElementName = "u_rang")]
        public URang URang { get; set; }

        [XmlElement(ElementName = "update")]
        public string Update { get; set; }

        [XmlElement(ElementName = "uptime")]
        public string Uptime { get; set; }

        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }

        [XmlElement(ElementName = "users")]
        public Users Users { get; set; }

        [XmlElement(ElementName = "vote")]
        public string Vote { get; set; }
    }

    [XmlRoot(ElementName = "u_grang")]
    public class UGrang
    {
        [XmlAttribute(AttributeName = "test")]
        public string Test { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "u_rang")]
    public class URang
    {
        [XmlAttribute(AttributeName = "test")]
        public string Test { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "users")]
    public class Users
    {
        [XmlElement(ElementName = "bots")]
        public string Bots { get; set; }

        [XmlElement(ElementName = "maxonline")]
        public string Maxonline { get; set; }

        [XmlElement(ElementName = "online")]
        public string Online { get; set; }
    }
}
