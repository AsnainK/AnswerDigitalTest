using System;
using AnswerDigitalTest;
using AnswerDigitalTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class AccountLogInSteps
    {
       
        [Given(@"I am on the Form Authentication page")]
        public void GivenIAmOnTheFormAuthenticationPage()
        {
            MainPage.GoTo();
            MainPage.ClickOn(MainPage.formAuthenticationLink);

        }

        [Given(@"I enter my username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            FormAuthentication.EnterUsername(username);
        }

        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            FormAuthentication.EnterPassword(password);
        }

        [When(@"I press Login")]
        public void WhenIPressLogin()
        {
            FormAuthentication.LogIn();
        }

        [Then(@"I should be logged in to my account")]
        public void ThenIShouldBeLoggedInToMyAccount()
        {
            Assert.AreEqual("http://the-internet.herokuapp.com/secure", AccountPage.URL);
        }

        [Then(@"I should be told my username is invalid")]
        public void ThenIShouldBeToldMyUsernameIsInvalid()
        {
            string error = FormAuthentication.ErrorText();
            Assert.AreEqual("Your username is invalid!",error);
        }

        [Given(@"I am logged in to my account")]
        public void GivenIAmLoggedInToMyAccount()
        {
            MainPage.GoTo();
            MainPage.ClickOn(MainPage.formAuthenticationLink);
            FormAuthentication.EnterUsername(FormAuthentication.username);
            FormAuthentication.EnterPassword(FormAuthentication.password);
            FormAuthentication.LogIn();
        }

        [When(@"I click the Log Out button")]
        public void WhenIClickTheLogOutButton()
        {
            AccountPage.LogOut();
        }

        [Then(@"I should be succesfully logged out of my account")]
        public void ThenIShouldBeSuccesfullyLoggedOutOfMyAccount()
        {
            bool check = FormAuthentication.LogOutCheck();
            Assert.IsTrue(check);
        }


    }
}
