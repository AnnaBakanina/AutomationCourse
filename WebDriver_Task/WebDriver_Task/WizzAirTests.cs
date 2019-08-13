using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace WebDriver_Task
{
    [TestFixture]
    public class WizzAirTests
    {
        private string _url = "https://wizzair.com";
        private IWebDriver _driver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(_url);

        }

        // Create new test class and implement the following scenario:
        //- Open 'wizzair.com'
        //- Search for flights from Kiev to Copenhagen for 1 adult person for the nearest date(one way)
        //- Ensure that correct flight is displayed in search results
        //- Verify: flight date, arrival/destination points, correct date is selected, 3 options with different prices are displayed, check prices,
        // return flights are not displayed

        //- Select one of the proposed offers 
        //- On the PASSENGERS page enter the first, last name, select Male/Female 
        //- Verify that route is correct on the top of the page
        //- Select any luggage option
        //- Click Continue
        //- Verify that Sign in dialog is displayed


        [Test]
        public void TestCase()
        {
        }
    }
}
