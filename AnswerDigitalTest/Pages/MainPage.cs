using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDigitalTest
{
    public class MainPage
    {
        public static IWebDriver webDriver = new ChromeDriver();

        public static string formAuthenticationLink = "Form Authentication";
        public static string infiniteScroll = "Infinite Scroll";
        public static string keyPresses = "Key Presses";

        public static string mainPageURL = "http://the-internet.herokuapp.com/";

        
        public static void GoTo()
        {
            webDriver.Navigate().GoToUrl(mainPageURL);           
        }

        public static void ClickOn(string linkText)
        {
            var element = webDriver.FindElement(By.LinkText(linkText));
            element.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);            
        }

        

    }
}
