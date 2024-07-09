using Homework_21.WebElements;
using OpenQA.Selenium;

namespace Homework_21.Pages
{
    internal class MainPage : BasePage
    {
        private static Element _alertsButton = new(By.XPath("//*[@class='category-cards']//div[3]//div[2]"));
        private static Element _alertsTabButton = new(By.XPath("//*[@class='accordion']//div[3]//ul//li[2]"));
        private static Element _framesTabButton = new(By.XPath("//*[@class='accordion']//div[3]//ul//li[3]"));
        private static Element _nestedFramesTabButton = new(By.XPath("//*[@class='accordion']//div[3]//ul//li[4]"));
        private static Element _modalTabButton = new(By.XPath("//*[@class='accordion']//div[3]//ul//li[5]"));

        public static void NavigateToAlertsPage()
        {
            _alertsButton.ClickElement();
            _alertsTabButton.ClickElement();
        }

        public static void NavigateToFramesPage()
        {
            _alertsButton.ClickElement();
            _framesTabButton.ClickElement();
        }

        public static void NavigateToNestedFramesPage()
        {
            _alertsButton.ClickElement();
            _nestedFramesTabButton.ClickElement();
        }

        public static void NavigateToModalPage()
        {
            _alertsButton.ClickElement();
            _modalTabButton.ClickElement();
        }
    }
}
