using Homework_22.WebElements;
using OpenQA.Selenium;

namespace Homework_22.Pages
{
    internal class AlertPage : BasePage
    {
        public static Element _alertButtonOne = new (By.Id("alertButton"));
        public static Element _alertButtonTwo = new(By.Id("timerAlertButton"));
        public static Element _alertButtonThree = new(By.Id("confirmButton"));
        public static Element _alertButtonFour = new(By.Id("promtButton"));

        public static void OpenAlert(Element element) => element.ClickElement();

        public static void AcceptAlert() => Element.AcceptAlert();
        public static bool CheckAlert() => Element.IsAlertVisible();

    }
}