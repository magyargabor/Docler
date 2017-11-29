namespace DoclerTest
{
    using DoclerTest.Pages;
    using TechTalk.SpecFlow;
    using DoclerTest.HomePageTests;
    using NUnit.Framework;
    
    [Binding]
    public class HomePageSteps
    {
        protected HomePage homePage = new HomePage();
        protected bool logoVisibleOnScreen;
        protected string title;
        protected string currentUrl;
        protected bool isHomeButtonActive;
        protected string h1Text;
    }
    

    public class HomeSteps : HomePageSteps
    {
        
        /***********************************************/

        [Given(@"Click to Home Button")]
        public void GivenClickToHomeButton()
        {
            homePage.ClickHome();
        }
        [When(@"Searching for logo on Home Page")]
        public void WhenSearchingForLogoOnHomePage()
        {
            this.logoVisibleOnScreen = homePage.IsLogoVisible();
        }
        [Then(@"HomePageLogo is visible on screen")]
        public void ThenHomePageLogoIsVisibleOnScreen()
        {
            homePage.closeBrowser();
            Assert.AreEqual(true, this.logoVisibleOnScreen);
            homePage.closeDiver();
        }

        /***********************************************/
        
        [When(@"Get HomePage Title")]
        public void WhenGetHomePageTitle()
        {
            this.title = homePage.GetTitle();
        }
        [Then(@"HomePageTitle is ""(.*)""")]
        public void ThenHomePageTitleIs(string p0)
        {                      
            homePage.closeBrowser();
            Assert.AreEqual(p0, this.title);
            homePage.closeDiver();
        }

        /***********************************************/

        [When(@"Get HomePage URL")]
        public void WhenGetHomePagetURL()
        {
            this.currentUrl = homePage.currentUrl;
        }
        [Then(@"I am on Home Page")]
        public void ThenIAmOnHomePage()
        {
            homePage.closeBrowser();
            Assert.AreEqual("http://uitest.duodecadits.com/", this.currentUrl);
            homePage.closeDiver();
        }

        /***********************************************/

        [When(@"Get Home Button Status")]
        public void WhenGetHomeButtonStatus()
        {
            this.isHomeButtonActive = homePage.IsHomeButtonActive();
        }

        [Then(@"Is Home Button Active")]
        public void ThenIsHomeButtonActive()
        {
            homePage.closeBrowser();
            Assert.AreEqual(true, isHomeButtonActive);
            homePage.closeDiver();
        }

        /***********************************************/

        [Given(@"Click to Ui Testing Button")]
        public void GivenClickToUiTestingButton()
        {
            homePage.ClickUiTesting();
        }

        /***********************************************/

        [When(@"Searching for Text in ""(.*)"" tag")]
        public void WhenSearchingForTextInTag(string p0)
        {
            h1Text = homePage.GetTagText(p0);
        }
        [Then(@"The Text equals with ""(.*)""")]
        public void ThenTheTextEqualsWith(string p0)
        {
            homePage.closeBrowser();            
            Assert.AreEqual(h1Text, p0);
            homePage.closeDiver();
        }
    }
}
