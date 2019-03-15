using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnswerDigitalTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AnswerDigitalTest.Pages
{
    public class KeyPresses
    {
        public static void PressButton(string button)
        {
            Actions action = new Actions(MainPage.webDriver);
            if (button == "Home")
            {
                action.SendKeys(Keys.Home);
                action.Perform();

            }
            else if (button == "Enter")
            {
                action.SendKeys(Keys.Enter);
                action.Perform();
            }
            else if (button == "Up")
            {
                action.SendKeys(Keys.Up);
                action.Perform();
            }
            else if (button == "Space")                
            {
                action.SendKeys(Keys.Space);
                action.Perform();
            }
            
        }

        
        public static string ReadResult()
        {
            WebDriverWait wait = new WebDriverWait(MainPage.webDriver, TimeSpan.FromSeconds(20));
            IWebElement result;
            result = wait.Until(ExpectedConditions.ElementExists(By.Id("result")));
            string text = result.Text;
            text = text.Replace("You entered: ", string.Empty);
            return text;
                        
        }


    }
}
