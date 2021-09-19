using System;
using System.Collections.Generic;

namespace ClientWPF
{
    public class Context
    {
        private static Context _instance;
        public static Context Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Context();
                }
                return _instance;
            }
        }

        private Dictionary<string, object> data = new Dictionary<string, object>();
        public object? Get(string key)
        {
            if (data.ContainsKey(key))
            {
                return data[key];
            }
            return null;
        }

        public object? Get(string key, Type t)
        {
            if (data.ContainsKey(key))
            {
                object d = data[key];
                if (d.GetType() == t)
                {
                    return d;
                }
            }
            return null;
        }
        public void Add(string key, object obj)
        {
            if (!data.ContainsKey(key))
            {
                data.Add(key, obj);
            }
        }

        public void Remove(string key)
        {
            if (data.ContainsKey(key))
            {
                data.Remove(key);
            }
        }
    }
}
