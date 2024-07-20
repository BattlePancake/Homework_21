using Homework_22.Factory;
using Homework_22.Pages;

namespace Homework_22.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            BasePage.OpenPage();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
