namespace DotNetSelenium;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

public class Test
{
    [Test]
    public void Test1()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");
        options.AddArgument("--window-size=1920,1080");
        var driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        SeleniumCustomMethods.Click(driver, By.LinkText("Login"));
        SeleniumCustomMethods.EnterText(driver, By.Name("UserName"), "Admin");
        SeleniumCustomMethods.EnterText(driver, By.Id("Password"), "password");

        System.Threading.Thread.Sleep(2000);
        IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn-signin"));
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].click();", btnLogin);

        driver.Quit();
    }

    public void Test2()
    {
    }
}