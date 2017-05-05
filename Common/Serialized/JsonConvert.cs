using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Serialized
{
    public class JsonConvert
    {
        /// <summary>
        /// 将对象序列化成Json
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="referenceLoopIgnore">是否忽略循环引用序列化</param>
        /// <returns>json</returns>
        public static string Serialize(object obj, bool referenceLoopIgnore = false)
        {
            if (referenceLoopIgnore)
            {
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                };
                return Newtonsoft.Json.JsonConvert.SerializeObject(obj, setting);
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        /// <summary>
        /// 将对象序列化成Json
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="camelCasePropertyName">是否驼峰命名</param>
        /// <returns></returns>
        public static string SerializeV2(object obj, bool camelCasePropertyName = false)
        {
            if (camelCasePropertyName)
            {
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
                };
                return Newtonsoft.Json.JsonConvert.SerializeObject(obj, setting);
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        /// <summary>
        /// 将对象序列化成Json
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="referenceLoopIgnore">是否忽略循环引用序列化</param>
        /// <param name="jsonConverters">序列化转化器</param>
        /// <returns>json</returns>
        public static string Serialize(object obj, bool referenceLoopIgnore = false, params JsonConverter[] jsonConverters)
        {
            if (referenceLoopIgnore)
            {
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    Converters = jsonConverters
                };
                return Newtonsoft.Json.JsonConvert.SerializeObject(obj, setting);
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, jsonConverters);
        }

        /// <summary>
        /// 将json反序列化成对象
        /// </summary>
        /// <typeparam name="TType">反序列化成的类型</typeparam>
        /// <param name="json">json</param>
        /// <returns>TType</returns>
        public static TType Deserialize<TType>(string json)
        {
            var type = typeof(TType);
            return (TType)Deserialize(json, type);
        }

        /// <summary>
        /// 将json反序列化成对象
        /// </summary>
        /// <param name="json">json</param>
        /// <param name="type">反序列化成的类型</param>
        /// <returns>object</returns>
        public static object Deserialize(string json, Type type)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(json, type);
        }
        /// <summary>
        /// json字符串格式化
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FormatJsonString(string str)
        {
            try
            {
                //格式化json字符串
                JsonSerializer serializer = new JsonSerializer();
                TextReader tr = new StringReader(str);
                JsonTextReader jtr = new JsonTextReader(tr);
                object obj = serializer.Deserialize(jtr);
                if (obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    return textWriter.ToString();
                }
                else
                {
                    return str;
                }
            }
            catch
            {
                return str;
            }
        }
    }
}
