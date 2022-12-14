using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedShopping.POMs
{
    public class CheckoutStepOnePage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _firstNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postalCodeField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _continueButton => _seleniumDriver.FindElement(By.Id("continue"));
        public CheckoutStepOnePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public CheckoutStepTwoPage clickContinueButton()
        {
            _continueButton.Click();
            return new CheckoutStepTwoPage(_seleniumDriver);
        }

        public void EnterFirstName(string firstName) { }
        public void EnterLastName(string lastName) { }
        public void EnterPostCode(string postCode) { }
    }
}
