using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedShopping.POMs
{
    public class ShoppingSite
    {
        public IWebDriver SeleniumDriver { get; set; }
        public HomePage HomePage { get; set; }
        public InventoryPage InventoryPage { get; set; }

        public ShoppingSite()
        {
            //Instantiate the driver
            SeleniumDriver = new ChromeDriver();
            //instatiate our page objects with the selenium driver
 //           HomePage = new HomePage(SeleniumDriver);
        }


    }
}
