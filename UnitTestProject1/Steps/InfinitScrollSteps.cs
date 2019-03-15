using System;
using TechTalk.SpecFlow;
using AnswerDigitalTest.Pages;
using AnswerDigitalTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [Binding]
    public class InfinitScrollSteps
    {
        [Given(@"I navigate to the infinite scroll page")]
        public void GivenINavigateToTheInfiniteScrollPage()
        {
            MainPage.GoTo();
            MainPage.ClickOn(MainPage.infiniteScroll);

        }
        
        [When(@"I scroll to the bottom of the page")]
        public void WhenIScrollToTheBottomOfThePage()
        {
           InfiniteScroll.ScrollToBottom() ;
        }
        
        [When(@"I scroll to the top of the page")]
        public void WhenIScrollToTheTopOfThePage()
        {
            InfiniteScroll.ScrollToTop();
        }
        
        [Then(@"I should be able to see the infinite scroll")]
        public void ThenIShouldBeAbleToSeeTheInfiniteScroll()
        {
            Assert.IsTrue(InfiniteScroll.isDisplayed());
        }
    }
}
