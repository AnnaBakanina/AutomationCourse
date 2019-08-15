using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private string _currentEnvironmentVersion;

        [SetUp]
        public void Setup()
        {
        }

        [Test, Description("Helthchecks on the environment")]
        public void TestHelthchecks()
        {
            Assert.Pass();
        }

        [Test, Description("Check if there is new TeamCity build and start deploy it")]
        public void TestTeamCityNewBuild()
        {

        }

        [Test,Description("Send message to the Slack chat")]
        public void TestAddSlackNotification()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}