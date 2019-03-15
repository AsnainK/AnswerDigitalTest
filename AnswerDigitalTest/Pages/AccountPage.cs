using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDigitalTest.Pages
{
    public class AccountPage
    {
        
        public static string URL
        {
            get { return MainPage.webDriver.Url; }
        }

        public static void LogOut()
        {
            var logOutButton = MainPage.webDriver.FindElement(By.CssSelector("#content > div > a > i"));
            logOutButton.Click();
            MainPage.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

    }
}
