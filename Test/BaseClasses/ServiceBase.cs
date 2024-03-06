using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;
using Test.BaseClasses;

namespace Test.BaseClasses
{
    public class ServiceBase
    {
        private static Dictionary<string, IService> _service = [];
        public static void Add(string key, IService service)
        {
            _service.Add(key, service);
        }

        public static bool Remove(string key)
        {
            if (_service.ContainsKey(key))
            {
                _service.Remove(key);
                return true;
            }
            return false;
        }

        public static Dictionary<string, IService> GetAll()
        {
            return _service;
        }

        public static IService? Get(string key)
        {
            if (_service.ContainsKey(key))
                return _service[key];
            return null;
        }
    }
}