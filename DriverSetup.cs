using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace firstautomationproject.Drivers
{
    public class DriverSetup
    {
        public static IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}