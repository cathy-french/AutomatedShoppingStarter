// Generated by Selenium IDE

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using OpenQA.Selenium.Interactions;

[TestFixture]
public class LoginTests
{
    private IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void successfulsignin()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(1492, 824);
        driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).Click();
        driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys("standard_user");
        driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).Click();
        driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).SendKeys("secret_sauce");
        driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".title")).Text, Is.EqualTo("PRODUCTS"));
    }

    [Test]
    public void usernamenotregistered()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(1491, 824);
        driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).Click();
        driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys("cathy");
        driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).Click();
        driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).SendKeys("secret_sauce");
        driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();

        Assert.That(driver.FindElement(By.CssSelector("*[data-test=\"error\"]")).Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
}
