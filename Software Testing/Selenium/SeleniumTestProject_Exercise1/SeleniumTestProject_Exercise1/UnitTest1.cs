using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject_Exercise1
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            // Set up the ChromeDriver with the specified path:
            driver = new ChromeDriver();

            //Navigate to google.com
            driver.Navigate().GoToUrl("https://www.google.com");

            //Manage window:
            IWindow wnd = driver.Manage().Window;
            wnd.Maximize();

            //Sleep:
            Thread.Sleep(5000);
        }

        [TestMethod]
        public void TestMethod1()
        {

        } 

        [TestCleanup]
        public void Cleanup()
        {
            // Clean up the driver
            driver.Quit();
        }
    }
}

