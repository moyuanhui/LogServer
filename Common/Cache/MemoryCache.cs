using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Common.Cache
{
    public class MemoryCache : ICache
    {
        protected ObjectCache Ocache
        {
            get { return System.Runtime.Caching.MemoryCache.Default; }
        }

        public void Set<T>(string key, T data, int cacheSecond)
        {
            var cacheData = (object)data;
            if (cacheData == null) return;

            if (cacheSecond > 0)
            {
                var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromSeconds(cacheSecond) };
                Ocache.Set(new CacheItem(key, cacheData), policy);
            }
        }

        public T Get<T>(string key)
        {
            if (Contains(key))
            {
                return (T)Ocache[key];
            }
            return default(T);
        }

        public void Remove(string key)
        {
            Ocache.Remove(key);
        }

        public void Clear()
        {
            foreach (var item in Ocache)
            {
                Remove(item.Key);
            }
        }

        public bool Contains(string key)
        {
            return Ocache.Contains(key);
        }
    }
}
