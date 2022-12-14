using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedShopping.POMs
{
    public  class CartPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.Id("checkout"));
        public CartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public CheckoutStepOnePage clickCheckoutButton()
        {
            _checkoutButton.Click();
            return new CheckoutStepOnePage(_seleniumDriver);
        }

    }
}
