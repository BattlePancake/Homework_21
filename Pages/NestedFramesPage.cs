using Homework_21.WebElements;
using OpenQA.Selenium;

namespace Homework_21.Pages
{
    internal class NestedFramesPage : BasePage
    {
        public const string ExpectedParentFrameText = "Parent frame";
        public const string ExpectedChildFrameText = "Child Iframe";

        public static Element _frameOne = new(By.XPath("//*[@id='frame1']"));
        public static Element _frameChild = new(By.XPath("/html/body/iframe"));

        public static Element ParentFrameText = new(By.XPath("/html/body"));
        public static Element ChildFrameText = new(By.XPath("/html/body"));

        public static void SwitchToFrame(Element element) => element.SwitchToFrame();
        public static void ExitFrame() => _frameOne.ReturnFromFrame();

        public static string GetElementText(Element element) => element.GetElementText();
    }
}
