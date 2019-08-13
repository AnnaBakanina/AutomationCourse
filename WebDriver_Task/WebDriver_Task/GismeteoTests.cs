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
            IList<IWebElement> listDivs = _driver.FindElements(By.CssSelector("div .h2"));

            Assert.That(listDivs, Is.Empty, "List of divs is not empty");
        }

        //3. Find all items with news titles(the block under list of cities)(х items)
        //4. Find the last span with news title
        //5. Get all titles from items from #3
        //6. Find element with text Киев
        //7. Find the element that describes city next after Киев
        //8. Find all top menu link
        //9. On the current city weather page find element for 3 current weekdays.
        //10. Find element for currently selected weekday
        //11. Find temperature when it's Малооблачно (1 element!!)
        //12. Find the same elements, but using CSS where possible


        public static void ToConsole(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
