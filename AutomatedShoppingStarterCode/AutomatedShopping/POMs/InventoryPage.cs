using OpenQA.Selenium;

namespace AutomatedShopping.POMs
{
    public class InventoryPage
    {
        private IWebDriver _seleniumDriver;
        private Random _random = new Random();

        private IWebElement _title => _seleniumDriver.FindElement(By.CssSelector(".title"));
        private IWebElement _cart => _seleniumDriver.FindElement(By.ClassName("shopping_cart_badge"));
        public InventoryPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
        public string GetTitle => _title.Text;
        public int CartCount => Int32.Parse(_cart.Text);

        public void SelectRandomPresent()
        {
            int itemNo = _random.Next(1, 6);
            itemNo = 1;
            var item = _seleniumDriver.FindElement(By.XPath("//div[@class='inventory_item'][1]"));
            // add the item to the basket
            item.FindElement(By.CssSelector("button")).Click();
        }

        public CartPage ClickCart()
        {
            _cart.Click();
            return new CartPage(_seleniumDriver);
        }
    }
}