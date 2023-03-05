using DemoWithExample.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace DemoWithExample.StepDefinitions
{
    [Binding]
    public class DemoWithExampleStepDefinitions
    {
        DemoWithExamplePage demoWithExamplePage;

        public DemoWithExampleStepDefinitions() 
        { 
         demoWithExamplePage= new DemoWithExamplePage();
        }



        [Given(@"I navigate to website ""([^""]*)""")]
        public void GivenINavigateToWebsite(string url)
        {
            demoWithExamplePage.NavigateToURL(url);
        }

        [Given(@"I enter First Name ""([^""]*)""")]
        public void GivenIEnterFirstName(string firstname)
        {
            demoWithExamplePage.EnterFirstName(firstname);
        }

        [Given(@"I enter Last Name ""([^""]*)""")]
        public void GivenIEnterLastName(string lastname)
        {
            demoWithExamplePage.EnterLastName(lastname);
        }

        [Given(@"I enter Address ""([^""]*)""")]
        public void GivenIEnterAddress(string address)
        {
            demoWithExamplePage.EnterAddress(address);
        }

        [Given(@"I enter Email Address ""([^""]*)""")]
        public void GivenIEnterEmailAddress(string email)
        {
            demoWithExamplePage.EnterEmail(email);
        }

        [Given(@"I enter Phone Number ""([^""]*)""")]
        public void GivenIEnterPhoneNumber(string phonenumber)
        {
           demoWithExamplePage.EnterPhoneNumber(phonenumber);
        }

        [Given(@"I select my Gender")]
        public void GivenISelectMyGender()
        {
            demoWithExamplePage.MyGender();
        }

        [Given(@"I select my Hobbies")]
        public void GivenISelectMyHobbies()
        {
            demoWithExamplePage.MyHobbies();
        }

        [Given(@"I select my languages")]
        public void GivenISelectMyLanguages()
        {
            demoWithExamplePage.MyLanguage();
        }

        [Given(@"I enter my Password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            demoWithExamplePage.EnterPassword(password);
        }

        [Given(@"I enter my Confirm Password ""([^""]*)""")]
        public void GivenIEnterMyConfirmPassword(string confirmpassword)
        {
            demoWithExamplePage.EnterConfirmPassword(confirmpassword);
        }

        [When(@"I click on the Submit Button")]
        public void WhenIClickOnTheSubmitButton()
        {
            demoWithExamplePage.ClickOnSubmitButton();
        }
    }
}
