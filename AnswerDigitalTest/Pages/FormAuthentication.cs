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
    public class FormAuthentication
    {
        public static string username = "tomsmith";
        public static string password = "SuperSecretPassword!";

        public static void EnterUsername(string username)
        {
            IWebElement userName = MainPage.webDriver.FindElement(By.Name("username"));
            userName.SendKeys(username);
        }

        public static void EnterPassword(string password)
        {
            IWebElement passWord = MainPage.webDriver.FindElement(By.Id("password"));
            passWord.SendKeys(password);
        }

        public static void LogIn()
        {
            IWebElement login = MainPage.webDriver.FindElement(By.CssSelector("#login > button > i"));
            login.Click();
            MainPage.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static string ErrorText()
        {
            string errortext = MainPage.webDriver.FindElement(By.Id("flash")).Text;
            errortext = errortext.Replace("\r\n×", string.Empty);
            return errortext;
        }

        public static bool LogOutCheck()
        {
            string logOutText = MainPage.webDriver.FindElement(By.Id("flash")).Text;
            logOutText = logOutText.Replace("\r\n×", string.Empty);
            if (logOutText == "You logged out of the secure area!")
            {
                return true;
            } 
            else
            {
                return false;
            }
            
        }

        
    }
}
