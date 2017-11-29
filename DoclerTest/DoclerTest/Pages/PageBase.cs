namespace DoclerTest.Pages
{
    using OpenQA.Selenium;        
    using OpenQA.Selenium.Chrome;
    using System;
    using System.Net;
    using NUnit.Framework;


    public class PageBase
    {
        public PageBase()
        {
            this.Driver= new ChromeDriver();
            this.Driver.Url = "http://uitest.duodecadits.com/";            
        }

        public void closeDiver()
        {
            this.Driver.Quit();
        }

        public void closeBrowser()
        {
            this.Driver.Close();
        }

        public IWebDriver Driver { get; set; }



        public int GetStatusCode()
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(this.Driver.Url);
            try
            {
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                return (int)myHttpWebResponse.StatusCode;
            }
            catch (WebException ex)
            {
                return (int)(ex.Response as HttpWebResponse).StatusCode;
            }
        }
                               
        public string GetTitle()
        {
            return this.Driver.Title;
        }
        public bool IsLogoVisible()
        {
            try
            {
                return this.Driver.FindElement(By.Id("dh_logo")).Displayed;  
            }
            catch (Exception e)
            {
                throw e;
            }
        }               
    }
}
