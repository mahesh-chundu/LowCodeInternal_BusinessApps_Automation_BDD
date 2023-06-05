using LowCodeInternal_BusinessApps_Automation_BDD.Actions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using LowCodeInternal_BusinessApps_Automation_BDD.Testdata;

namespace LowCodeInternal_BusinessApps_Automation_BDD.Common
{
    internal  class BasePage
    {
        public static class DriverManager
        {
            public static IWebDriver driver { get; set; } = null!;
        }
    }
}

