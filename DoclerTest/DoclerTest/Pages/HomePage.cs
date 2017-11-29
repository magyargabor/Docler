namespace DoclerTest.Pages
{
    using OpenQA.Selenium;
    using NUnit.Framework;


    public class HomePage : PageBase
    {        
        public string currentUrl;
        public string welcomeText;

        public void ClickHome()
        {
            this.Driver.FindElement(By.Id("home")).Click();
            this.currentUrl = this.Driver.Url;                                       
        }

        public void ClickUiTesting()
        {
            this.Driver.FindElement(By.Id("site")).Click();
            this.currentUrl = this.Driver.Url;             
        }

        public string GetTagText(string tags)
        {
            var ui_test = this.Driver.FindElement(By.ClassName("ui-test"));
            if (ui_test.FindElement(By.CssSelector(tags)).Displayed)
            {
                return ui_test.FindElement(By.CssSelector(tags)).Text;                               
            }
            else return "false";
        }        

        public bool IsHomeButtonActive()
        {
            var navbar = this.Driver.FindElement(By.ClassName("navbar-nav"));
            var activeElement = navbar.FindElement(By.ClassName("active"));
            var homeButton = this.Driver.FindElement(By.Id("home"));
            if (homeButton.Text == activeElement.Text)
            {
                return true;
            }
            else return false;
        }
     }
}
