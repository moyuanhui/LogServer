using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using LogServer.WebApi.Extensions;
using Newtonsoft.Json.Converters;

namespace LogServer.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var config = GlobalConfiguration.Configuration;
            var jqueryFormatter = config.Formatters.FirstOrDefault(x => x.GetType() == typeof(System.Web.Http.ModelBinding.JQueryMvcFormUrlEncodedFormatter));
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Remove(jqueryFormatter); 
            //config.Formatters.Remove(config.Formatters.FormUrlEncodedFormatter);
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
            //config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new UnixDateTimeConverter());
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;//json数据格式化排版
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();//驼峰命名法
            //向消息处理管线中添加一个处理器，按添加顺序执行
            config.MessageHandlers.Add(new AuthenticationHandler());
        }
    }
}
