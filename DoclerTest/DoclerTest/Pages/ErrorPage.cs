namespace DoclerTest.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System.Net;


    public class ErrorPage : PageBase
    {  
        public void ClickError()
        {
            this.Driver.FindElement(By.Id("error")).Click();            
        }
    }
}
