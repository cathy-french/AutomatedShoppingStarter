using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedShopping.POMs
{
    public class CheckoutStepTwoPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _finishButton => _seleniumDriver.FindElement(By.Id("finish"));
        public CheckoutStepTwoPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void clickFinishButton()
        {
            _finishButton.Click();
        }
    }
}
