using System;
using System.Collections.Generic;
using LogServer.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void GetAuthorization()
        {
            var androidKey = "shx_own_Android";
            var iosKey = "shx_own_ios";
            var appKey = LogServer.Common.Security.DEncrypt.Base64Encrypt(androidKey);
            var appSecret = LogServer.Common.Security.DEncrypt.Encrypt(appKey);
            var dic = new Dictionary<string, string>
            {
                {"appKey", appKey},
                { "appSecret", appSecret}
            };
            var str = LogServer.Common.Serialized.JsonConvert.Serialize(dic);
            var result = LogServer.Common.Security.DEncrypt.Base64Encrypt(str);
            var result3 = LogServer.Common.Security.DEncrypt.Base64Encrypt(result);
            var result2 = LogServer.Common.Security.DEncrypt.Base64Decrypt(result);
        }
    }
}
