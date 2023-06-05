﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LowCodeInternal_BusinessApps_Automation_BDD.Testdata;
using LowCodeInternal_BusinessApps_Automation_BDD.PageObjects;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;
using LowCodeInternal_BusinessApps_Automation_BDD.Common;

namespace LowCodeInternal_BusinessApps_Automation_BDD.Actions
{
    internal class LoginPage_OktaPreview_ActionPage:LoginPage_OktaPreview_PageObjects
    {
        internal LoginPage_OktaPreview_ActionPage Login() 
        {
            Data data = JsonDataProvider.GetData();
            DriverManager.driver = new ChromeDriver();
            DriverManager.driver.Navigate().GoToUrl(data?.BaseUrl);
            DriverManager.driver.Manage().Window.Maximize();
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            oktaUsername?.SendKeys(data?.Username);
            oktaPassword?.SendKeys(data?.Password);
            oktaSubmit?.Click();
            return this;
        }
    }
}
