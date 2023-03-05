using DemoWithExample.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWithExample.PageObjects
{
    class DemoWithExamplePage
    {
        IWebDriver driver;
        public DemoWithExamplePage() 
        {
            driver = Hooks3.driver;
        }

        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[1]/div[1]/input"));
        IWebElement LastName => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[1]/div[2]/input"));
        IWebElement Address => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id=\"eid\"]/input"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Gender => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[5]/div/label[1]/input"));
        IWebElement Hobbies => driver.FindElement(By.Id("checkbox2"));
        IWebElement Languages => driver.FindElement(By.Id("msdd"));

        IWebElement Languages1 => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(7) > div > multi-select > div:nth-child(2) > ul > li:nth-child(8) > a"));
        IWebElement Password => driver.FindElement(By.Id("firstpassword"));
        IWebElement ConfirmPassword => driver.FindElement(By.Id("secondpassword"));
        IWebElement SubmitButton => driver.FindElement(By.Id("submitbtn"));

        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterFirstName(string firstName) 
        {
            FirstName.SendKeys(firstName);
        }

        public void EnterLastName(string lastName) 
        {
            LastName.SendKeys(lastName);
        }

        public void EnterAddress(string address) 
        { 
            Address.SendKeys(address);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPhoneNumber(string phonenumber) 
        {
            PhoneNumber.SendKeys(phonenumber);
        }

        public void MyGender()
        {
            Gender.Click();
        }

        public void MyHobbies()
        {
            Hobbies.Click();
        }

        public void MyLanguage()
        {
            Languages.Click();
            Languages1.Click();
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
            
        }

        public void EnterConfirmPassword(string confirmpassword)
        {
            ConfirmPassword.SendKeys(confirmpassword);

        }
        public void ClickOnSubmitButton()
        {
            SubmitButton.Click();
        }





    }
}
