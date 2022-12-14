using System;
using TechTalk.SpecFlow;
using AutomatedShopping.POMs;
using NUnit.Framework;

namespace AutomatedShopping.StepDefinitions
{
    [Binding]
    public class PresentSelectionStepDefinitions
    {
        private HomePage _homePage;
        private ShoppingSite _shoppingSite;
        private InventoryPage _inventoryPage;
        private CartPage _cartPage;
        private CheckoutStepOnePage _checkoutStepOnePage;
        private CheckoutStepTwoPage _checkoutStepTwoPage;
        [BeforeScenario]
        public void BeforeScenario()
        {
            _shoppingSite = new ShoppingSite();
        }

        [AfterScenario] 
        public void AfterScenario()
        {
            _shoppingSite.SeleniumDriver.Close();
            _shoppingSite.SeleniumDriver.Quit();
        }
        
        [Given(@"that I have signed in to the saucedemo site")]
        public void GivenThatIHaveSignedInToTheSaucedemoSite()
        {
            _homePage = new HomePage(_shoppingSite.SeleniumDriver);
            _inventoryPage = _homePage.Login("standard_user", "secret_sauce");
        }

        [When(@"I select a random present")]
        public void WhenISelectARandomPresent()
        {
            _inventoryPage.SelectRandomPresent();
        }

        [When(@"I click on the shopping cart")]
        public void WhenIClickOnTheShoppingCart()
        {
            _cartPage = _inventoryPage.ClickCart();
        }

        [Then(@"I will be on the cart page")]
        public void ThenIWillBeOnTheCartPage()
        {
            Assert.That(_shoppingSite.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));
        }

        [When(@"I click on the checkout button")]
        public void WhenIClickOnTheCheckoutButton()
        {
            _checkoutStepOnePage = _cartPage.clickCheckoutButton();
        }

        [Then(@"I will be on the checkout step one page")]
        public void ThenIWillBeOnTheCheckoutStepOnePage()
        {
            Assert.That(_shoppingSite.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
        }

        [When(@"I fill in the first name (.*)")]
        public void WhenIFillInTheFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        [When(@"I fill in the second name (.*)")]
        public void WhenIFillInTheSecondName(string lastName)
        {
            throw new NotImplementedException();
        }

        [When(@"I fill in the city (.*)")]
        public void WhenIFillInTheCity(string city)
        {
            throw new NotImplementedException();
        }

        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            throw new NotImplementedException();
        }

        [Then(@"I will be on the checkout step two page")]
        public void ThenIWillBeOnTheCheckoutStepTwoPage()
        {
            Assert.That(_shoppingSite.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-two.html"));
        }

        [When(@"I click the finish button")]
        public void WhenIClickTheFinishButton()
        {
            _checkoutStepTwoPage.clickFinishButton();
        }

        [Then(@"I will be on the checkout complete page")]
        public void ThenIWillBeOnTheCheckoutCompletePage()
        {
            Assert.That(_shoppingSite.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
        }

    }
}
