using FractalzFrontend.Application.Abstractions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Cache
{
    public class CacheCreator : ICacheController
    {
        Dictionary<string, object> _cache = new Dictionary<string, object>();

        public void SetCache(string key, object value) =>
            _cache.Add(key, value);

        public T GetCache<T>(string key) => 
            (T)_cache[key];

        public void ClearCache() => _cache.Clear();
    }
}
