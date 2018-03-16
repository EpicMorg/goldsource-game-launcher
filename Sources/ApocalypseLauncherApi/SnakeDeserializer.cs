using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ApocalypseLauncherApi
{
    internal static class SnakeDeserializer
    {
        private static readonly JsonSerializer Converter = new JsonSerializer
        {
            ContractResolver = new SnakeCaseContractResolver()
        };

        public static T Deserialize<T>(string data)
        {
            using (var stringReader = new StringReader(data))
            using (var jsonTextReader = new JsonTextReader(stringReader))
                return Converter.Deserialize<T>(jsonTextReader);
        }

        //ToSnake -> to_snake
        private static string ToSnake(this string name)
        {
            var t = new StringBuilder();
            t.Append(char.ToLower(name[0]));
            for (var index = 1; index < name.Length; index++)
            {
                var c = name[index];
                //add '_' before numbers and captials 
                if (char.IsUpper(c)
                    || (char.IsNumber(c) && !char.IsNumber(name[index - 1])))
                {
                    t.Append('_');
                    t.Append(char.ToLower(c));
                }
                else t.Append(c);
            }
            return t.ToString();
        }

        internal class SnakeCaseContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName) => propertyName.ToSnake();
        }
    }
}