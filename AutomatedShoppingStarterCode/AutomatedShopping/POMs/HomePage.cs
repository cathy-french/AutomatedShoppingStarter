using OpenQA.Selenium;

namespace AutomatedShopping.POMs
{
    public class HomePage
    {
        private IWebDriver _seleniumDriver;
        private string _homePageUrl = "https://www.saucedemo.com/";
        //Get web elements
  
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.CssSelector("*[data-test=\"username\"]"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.CssSelector("*[data-test=\"password\"]"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.CssSelector("*[data-test=\"login-button\"]"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector("[data-test=\"error\"]"));

        // Constructor that set the driver to be the driver from the config
        public HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
            VisitHomePage();
        }
        

        // Methods 
        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
            _seleniumDriver.Manage().Window.Size = new System.Drawing.Size(1492, 824);
        } 
        public void EnterUserName(string username) => _usernameField.SendKeys(username);
        public void EnterPassword(string password) => _passwordField.SendKeys(password);
        public void ClickLoginButton() => _loginButton.Click();
        public string CheckErrorMessage() => _errorMessage.Text;

        public InventoryPage Login(string userName, string password)
        {
            return new InventoryPage(_seleniumDriver);
        }
    }
}