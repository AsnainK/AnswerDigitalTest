using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace AnswerDigitalTest.Pages
{
    public class InfiniteScroll
    {
        public static void ScrollToBottom()
        {
            var pageFooter = MainPage.webDriver.FindElement(By.Id("page-footer"));
            Actions actions = new Actions(MainPage.webDriver);
            actions.MoveToElement(pageFooter);
            actions.Perform();
            
        }

        public static void ScrollToTop()
        {
            var pageHeader = MainPage.webDriver.FindElement(By.CssSelector("#content > div > h3"));
            Actions actions = new Actions(MainPage.webDriver);
            actions.MoveToElement(pageHeader);
            actions.Perform();
        }

        public static bool isDisplayed()
        {
            var pageHeader = MainPage.webDriver.FindElement(By.CssSelector("#content > div > h3"));
            bool checker = pageHeader.Displayed;
            return checker;
        }


    }
}
