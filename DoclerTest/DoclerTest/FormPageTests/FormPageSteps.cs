namespace DoclerTest
{
    using DoclerTest.Pages;
    using DoclerTest.FormPageTests;
    using TechTalk.SpecFlow;
    using NUnit.Framework;

    
    [Binding]
    public class FormPageSteps
    {
        protected FormPage formPage = new FormPage();
        protected bool logoVisibleOnScreen;
        protected string title;
        protected string currentUrl;
        protected bool isFormButtonActive;
        protected bool isInputBoxVisible;
        protected bool isSubmitButtonVisible;
    }


    public class FormSteps : FormPageSteps
    {
        
        /***********************************************/

        [Given(@"Click to Form Button")]
        public void GivenClickToFormButton()
        {
            formPage.ClickForm();
        }
        [When(@"Searching for logo on Form Page")]
        public void WhenSearchingForLogoOnFormPage()
        {
            this.logoVisibleOnScreen = formPage.IsLogoVisible();
        }
        [Then(@"FormPageLogo is visible on Screen")]
        public void ThenFormPageLogoIsVisibleOnScreen()
        {
            formPage.closeBrowser();            
            Assert.AreEqual(true, this.logoVisibleOnScreen);
            formPage.closeDiver();
        }

        /***********************************************/

        [When(@"Get FormPage Title")]
        public void WhenGetFormPageTitle()
        {
            this.title = formPage.GetTitle();
        }
        [Then(@"FormPageTitle is ""(.*)""")]
        public void ThenFormPageTitleIs(string p0)
        {
            formPage.closeBrowser();
            Assert.AreEqual(p0, this.title);            
            formPage.closeDiver();
        }

        /***********************************************/

        [When(@"Get FormPage URL")]
        public void WhenGetFormPageURL()
        {
            this.currentUrl = formPage.currentUrl;
        }
        [Then(@"I am on Form Page")]
        public void ThenIAmOnFormPage()
        {
            formPage.closeBrowser();            
            Assert.AreEqual("http://uitest.duodecadits.com/form.html", this.currentUrl);
            formPage.closeDiver();
        }

        /***********************************************/

        [When(@"Get Form Button Status")]
        public void WhenGetFormButtonStatus()
        {
            this.isFormButtonActive = formPage.IsFormButtonActive();
        }

        [Then(@"Is Form Button Active")]
        public void ThenIsFormButtonActive()
        {
            formPage.closeBrowser();
            Assert.AreEqual(true, isFormButtonActive);
            formPage.closeDiver();
        }

        /***********************************************/

        [When(@"Searching Input Box")]
        public void WhenSearchingInputBox()
        {
            this.isInputBoxVisible = formPage.InputBoxIsVisible();
        }

        [When(@"Searching Submit Button")]
        public void WhenSearchingSubmitButton()
        {
            this.isSubmitButtonVisible = formPage.SubmitButtonIsVisible();
        }

        [Then(@"Box is visible")]
        public void ThenBoxIsVisible()
        {
            formPage.closeBrowser();
            Assert.AreEqual(true, isInputBoxVisible);            
        }

        [Then(@"Button is visible")]
        public void ThenButtonIsVisible()
        {            
            Assert.AreEqual(true, isSubmitButtonVisible);
            formPage.closeDiver();
        }

        /***********************************************/

        [When(@"Type (.*) to the input field")]
        public void WhenTypeToTheInputField(string value)
        {
            formPage.TypeToInputBox(value);
        }

        [When(@"Push Submit Button")]
        public void WhenPushSubmitButton()
        {
            formPage.ClickGo();
        }

        [Then(@"Got the (.*)")]
        public void ThenGotThe(string result)
        {            
            Assert.AreEqual(result, formPage.GetHelloText());
            formPage.closeBrowser();
            formPage.closeDiver();
        }

        /***********************************************/
    
    }
}
