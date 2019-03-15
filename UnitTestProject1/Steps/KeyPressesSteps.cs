using AnswerDigitalTest;
using AnswerDigitalTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class KeyPressesSteps
    {
        [Given(@"I navigate to the Key Presses Application")]
        public void GivenINavigateToTheKeyPressesApplication()
        {
            MainPage.GoTo();
            MainPage.ClickOn(MainPage.keyPresses);
        }
        
        [When(@"I press '(.*)'")]
        public void WhenIPress(string button)
        {
            KeyPresses.PressButton(button);
        }
        
        [Then(@"I should see '(.*)' presented in the You Pressed field")]
        public void ThenIShouldSeePresentedInTheYouPressedField(string resultText)
        {
            Assert.AreEqual(resultText, KeyPresses.ReadResult());
        }
    }
}
