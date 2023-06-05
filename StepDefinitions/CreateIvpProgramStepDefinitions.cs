using LowCodeInternal_BusinessApps_Automation_BDD.Actions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace LowCodeInternal_BusinessApps_Automation_BDD.StepDefinitions
{
    [Binding]
    internal class CreateIvpProgramStepDefinitions
    {
        CreateIvpProgramAction CurrentPage = new CreateIvpProgramAction();
        [Given(@"Navigate to the IVP Dashboard Page")]
        public void GivenNavigateToTheIVPDashboardPage()
        {
            LoginPage_OktaPreview_ActionPage Okta = new LoginPage_OktaPreview_ActionPage();
            Okta.Login();
        }

        [When(@"Click On Add New Program Button")]
        public void WhenClickOnAddNewProgramButton()
        {
            IvpDashboardAction ivpDashboardTest = new IvpDashboardAction();
            ivpDashboardTest.IVPAddNewProgram();
        }

        [Then(@"Create a New Program and Save")]
        public void ThenCreateANewProgramAndSave()
        {
            CurrentPage.As<CreateIvpProgramAction>().Approval();
            CurrentPage.As<CreateIvpProgramAction>().Status();
            CurrentPage.As<CreateIvpProgramAction>().ShipStartDate();
            CurrentPage.As<CreateIvpProgramAction>().ShipEndDate();
            CurrentPage.As<CreateIvpProgramAction>().Year();
            CurrentPage.As<CreateIvpProgramAction>().NationalAcct();
            CurrentPage.As<CreateIvpProgramAction>().Category();
            CurrentPage.As<CreateIvpProgramAction>().AllBranches();
            CurrentPage.As<CreateIvpProgramAction>().SubmitDate();
            CurrentPage.As<CreateIvpProgramAction>().PayMode();
            CurrentPage.As<CreateIvpProgramAction>().SalesType();
            CurrentPage.As<CreateIvpProgramAction>().PurchaseType();
            CurrentPage.As<CreateIvpProgramAction>().AllCustomers();
            CurrentPage.As<CreateIvpProgramAction>().AllShipTos();
            CurrentPage.As<CreateIvpProgramAction>().InvoiceRequired();
            CurrentPage.As<CreateIvpProgramAction>().CalcFactor();
            CurrentPage.As<CreateIvpProgramAction>().IvpProgram();
            CurrentPage.As<CreateIvpProgramAction>().PriceIncrease();
            CurrentPage.As<CreateIvpProgramAction>().Commodity();
            CurrentPage.As<CreateIvpProgramAction>().OwnerName();
            CurrentPage.As<CreateIvpProgramAction>().GroupId();
            CurrentPage.As<CreateIvpProgramAction>().CustomerSearch();
            CurrentPage.As<CreateIvpProgramAction>().SupplierSearch();
            CurrentPage.As<CreateIvpProgramAction>().JodName();
            CurrentPage.As<CreateIvpProgramAction>().DealId();
            CurrentPage.As<CreateIvpProgramAction>().VendorProgramId();
            CurrentPage.As<CreateIvpProgramAction>().Program();
            CurrentPage.As<CreateIvpProgramAction>().Comments();
            CurrentPage.As<CreateIvpProgramAction>().CreateProgram();
            CurrentPage.As<CreateIvpProgramAction>().GetProgramCodeValue();
            CurrentPage.As<CreateIvpProgramAction>().CloseProgram();
        }
        [Given(@"Navigate to Dashboard Page")]
        public void GivenNavigateToDashboardPage()
        {
            LoginPage_OktaPreview_ActionPage Okta = new LoginPage_OktaPreview_ActionPage();
            Okta.Login();
        }

        [When(@"Search for a program")]
        public void WhenSearchForAProgram()
        {
            CurrentPage.As<CreateIvpProgramAction>().DashboardYearFilter();
            CurrentPage.As<CreateIvpProgramAction>().DashboardStatusFilter();
            CurrentPage.As<CreateIvpProgramAction>().ClickExistingProgramLink();
            CurrentPage.As<CreateIvpProgramAction>().GetProgramCodeValue();
        }

        [Then(@"Add notes to that program")]
        public void ThenAddNotesToThatProgram()
        {
            CurrentPage.As<CreateIvpProgramAction>().ClickNoteTab();
            CurrentPage.As<CreateIvpProgramAction>().SaveProgram();
            CurrentPage.As<CreateIvpProgramAction>().CloseProgram();
        }

    }
}
