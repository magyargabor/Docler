namespace DoclerTest.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium;


    public class FormPage : PageBase
    {
        public string currentUrl;        
        public void ClickForm()
        {
            this.Driver.FindElement(By.Id("form")).Click();
            this.currentUrl = this.Driver.Url;            
        }

        public bool IsFormButtonActive()
        {
            var navbar = this.Driver.FindElement(By.ClassName("navbar-nav"));
            var activeElement = navbar.FindElement(By.ClassName("active"));
            var formButton = this.Driver.FindElement(By.Id("form"));            
            if (formButton.Text == activeElement.Text)
            {
                return true;
            }
            else return false;
        }

        public void ClickGo()
        {
            this.Driver.FindElement(By.Id("hello-submit")).Click();
            this.currentUrl = this.Driver.Url;
        }

        public string GetHelloText()
        {                       
            return this.Driver.FindElement(By.Id("hello-text")).Text;            
        }

        public void TypeToInputBox(string value)
        {
            Driver.FindElement(By.Id("hello-input")).SendKeys(value);
        }
        
        public bool InputBoxIsVisible()
        {
            return this.Driver.FindElement(By.Id("hello-input")).Displayed;
        }

        public bool SubmitButtonIsVisible()
        {
            return this.Driver.FindElement(By.Id("hello-submit")).Displayed;
        }
    }
}
