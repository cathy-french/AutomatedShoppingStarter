using NUnit.Framework;
using AutomatedShopping.POMs;

namespace AutomatedShopping.UnitTests
{
    internal class LoginTestWithPOM
    {
        private ShoppingSite _shoppingSite;

        [SetUp]
        public void SetUp()
        {
            _shoppingSite = new ShoppingSite();
        }

        [TearDown]
        protected void TearDown()
        {
            _shoppingSite.SeleniumDriver.Close();
            _shoppingSite.SeleniumDriver.Quit();
        }
        [Test]
        public void successfulsignin()
        {
            HomePage homePage = new HomePage(_shoppingSite.SeleniumDriver);
            homePage.EnterUserName("standard_user");
            homePage.EnterPassword("secret_sauce");
            homePage.ClickLoginButton();      
            Assert.That(_shoppingSite.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void usernamenotregistered()
        {
        }

    }
}
