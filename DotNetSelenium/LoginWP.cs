namespace DotNetSelenium;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
public class Test
{

    [Test]
    public void Test1()
    {        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        driver.Manage().Window.Maximize();
        //IWebElement webElement = driver.FindElement(By.XPath("//button//div[contains(text(),'Alle akzeptieren')]"));
        //webElement.Click();
        SeleniumCustomMethods.Click(driver, By.LinkText("Login"));
        //driver.FindElement(By.LinkText("Login")).Click();
        //IWebElement UserName = driver.FindElement(By.Name("UserName"));
        //UserName.SendKeys("Admin");
        SeleniumCustomMethods.EnterText(driver, By.Name("UserName"), "Admin");
        //IWebElement Password = driver.FindElement(By.Id("Password"));
        //Password.SendKeys("password");
        SeleniumCustomMethods.EnterText(driver, By.Id("Password"), "password");
        IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));
        btnLogin.Submit();

    }
    public void Test2()
    {

    }
}
