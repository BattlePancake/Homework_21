using Homework_21.Factory;
using OpenQA.Selenium;

namespace Homework_21.Pages
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();

        public static void OpenPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }
    }
}
