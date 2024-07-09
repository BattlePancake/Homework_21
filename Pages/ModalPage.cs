using Homework_21.WebElements;
using OpenQA.Selenium;

namespace Homework_21.Pages
{
    internal class ModalPage : BasePage
    {
        private static Element _modalText = new(By.XPath("//*[@class='modal-body']"));

        public const string ExpectedSmallModalText = "This is a small modal. It has very less content";
        public const string ExpectedLargeModalText = "Lorem Ipsum is simply dummy text of the printing and typesetting" + 
            " industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown " + 
            "printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five " + 
            "centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised " + 
            "in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop " + 
            "publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

        public static Element OpenSmallModal = new(By.XPath("//*[@id='showSmallModal']"));
        public static Element OpenLargeModal = new(By.XPath("//*[@id='showLargeModal']"));

        public static Element CloseSmallModal = new(By.XPath("//*[@id='closeSmallModal']"));
        public static Element CloseLargeModal = new(By.XPath("//*[@id='closeLargeModal']"));

        public static void ClickButton(Element element) => element.ClickElement();

        public static string GetPopupText() => _modalText.GetElementText();

        public static bool CheckThatSmallPopupClosed()
        {
            try
            {
                ClickButton(CloseSmallModal);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool CheckThatLargePopupClosed()
        {
            try
            {
                ClickButton(CloseLargeModal);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
