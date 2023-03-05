using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace DemoWithExample.Utilities
{
    [Binding]
    public class Hooks3
    {
        public static IWebDriver driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
           driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}