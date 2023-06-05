using LowCodeInternal_BusinessApps_Automation_BDD.Testdata;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using static LowCodeInternal_BusinessApps_Automation_BDD.Common.BasePage;
using LowCodeInternal_BusinessApps_Automation_BDD.PageObjects;
using OpenQA.Selenium.Internal;
using LowCodeInternal_BusinessApps_Automation_BDD.Common;

namespace LowCodeInternal_BusinessApps_Automation_BDD.StepDefinitions
{
    [Binding]
    internal class LoginToOktaStepDefinitions : LoginPage_OktaPreview_PageObjects
    {
        [Given(@"Navigate to the Login Page")]
        public void GivenNavigateToTheLoginPage()
        {
            Data data = JsonDataProvider.GetData();
            DriverManager.driver = new ChromeDriver();
            DriverManager.driver.Navigate().GoToUrl(data?.BaseUrl);
            DriverManager.driver.Manage().Window.Maximize();
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [When(@"Enter Username and Password")]
        public void WhenEnterUsernamePasswordAndClickOnSubmitButton()
        {
            Data data = JsonDataProvider.GetData();
            oktaUsername?.SendKeys(data?.Username);
            oktaPassword?.SendKeys(data?.Password);
            
        }

        [Then(@"click on Submit Button")]
        public void ThenLandingOnTheDesiredPage()
        {
            oktaSubmit?.Click();
        }
    }
}
