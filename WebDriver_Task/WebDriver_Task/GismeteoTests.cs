using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace WebDriver_Task
{
    [TestFixture]
    public class GismeteoTests
    {
        private string _url = "https://gismeteo.ua";
        private IWebDriver _driver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(_url);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test, Description("Find all divs on the page")]
        public void GetAllDivsOnPage()
        {
            IList<IWebElement> listDivs = _driver.FindElements(By.CssSelector("div"));

            Assert.That(listDivs, Is.Not.Empty, "List of divs is empty");
        }

        [Test, Description("Find all divs with h2 class")]
        public void AllDivsWithHTwoClass()
        {
            IList<IWebElement> listDivs = _driver.FindElements(By.CssSelector("div, .h2"));
        }

        public static void ToConsole(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}
