using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Cache
{
    public interface ICache
    {
        /// <summary>
        /// 添加一个key和数据到缓存中
        /// </summary>
        /// <typeparam name="T">缓存数据类型</typeparam>
        /// <param name="key">key</param>
        /// <param name="data">数据</param>
        /// <param name="cacheSecond">缓存过期时间(秒)</param>
        void Set<T>(string key, T data, int cacheSecond);

        /// <summary>
        /// 获取key在缓存中的数据
        /// </summary>
        /// <typeparam name="T">缓存数据类型</typeparam>
        /// <param name="key">key</param>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        /// 用key从缓存中移除数据
        /// </summary>
        /// <param name="key">key</param>
        void Remove(string key);

        /// <summary>
        /// 清除当前缓存容器的所有缓存项
        /// </summary>
        void Clear();

        /// <summary>
        /// 是否已经存在key的缓存
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        bool Contains(string key);
    }
}
