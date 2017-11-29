namespace DoclerTest
{
    using System;
    using DoclerTest.Pages;
    using DoclerTest.ErrorPageTests;
    using TechTalk.SpecFlow;
    using NUnit.Framework;
    using OpenQA.Selenium;
    
    [Binding]
    public class ErrorPageSteps
    {
        protected ErrorPage errorPage = new ErrorPage();
        protected bool logoVisibleOnScreen;
        protected string title;
        protected int errorCode;    
    }


    public class ErrorSteps : ErrorPageSteps
    {

        /***********************************************/

        [Given(@"Click to Error Button")]
        public void GivenClickToErrorButton()
        {
            errorPage.ClickError();
        }        
        [When(@"Searching for logo on Error Page")]
        public void WhenSearchingForLogoOnErrorPage()
        {
            try
            {
                this.logoVisibleOnScreen = errorPage.IsLogoVisible();
            }
            catch (Exception ex)
            {
                this.logoVisibleOnScreen = false;
            }
        }
        [Then(@"ErrorPageLogo is visible on screen")]
        public void ThenErrorPageLogoIsVisibleOnScreen()
        {
            errorPage.closeBrowser();
            Assert.AreEqual(true, this.logoVisibleOnScreen);
            errorPage.closeDiver();
        }

        /***********************************************/

        [When(@"Get ErrorPage Title")]
        public void WhenGetErrorPageTitle()
        {
            this.title = errorPage.GetTitle();
        }
        [Then(@"ErrorPageTitle is ""(.*)""")]
        public void ThenErrorPageTitleIs(string p0)
        {
            errorPage.closeBrowser();
            Assert.AreEqual(p0, this.title);
            errorPage.closeDiver();
        }

        /***********************************************/

        [When(@"Get ErrorPage Http Response Code")]
        public void WhenGetErrorPageHttpResponseCode()
        {
            this.errorCode = errorPage.GetStatusCode();
        }

        [Then(@"Code is (.*)")]
        public void ThenCodeIs(int p0)
        {
            errorPage.closeBrowser();
            Assert.AreEqual(p0, this.errorCode);
            errorPage.closeDiver();
        }

        /***********************************************/

    }
}
