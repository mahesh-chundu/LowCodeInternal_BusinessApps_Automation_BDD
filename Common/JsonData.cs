﻿using LowCodeInternal_BusinessApps_Automation_BDD.Testdata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCodeInternal_BusinessApps_Automation_BDD.Common
{
    public static class JsonDataProvider
    {
        private static readonly string _jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Configurations", "configurationsettings.json");
        private static readonly object _lockObject = new object();
        private static Data? _data;

        internal static Data GetData()
        {
            if (_data == null)
            {
                lock (_lockObject)
                {
                    if (_data == null)
                    {
                        string json = File.ReadAllText(_jsonFilePath);
                        _data = JsonConvert.DeserializeObject<Data>(json);
                    }
                }
            }
            return _data;
        }
    }
}
