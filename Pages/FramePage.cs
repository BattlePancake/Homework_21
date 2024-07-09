using Homework_21.WebElements;
using OpenQA.Selenium;

namespace Homework_21.Pages
{
    internal class FramePage : BasePage
    {
        private static Element _frameOne = new(By.XPath("//*[@id='frame1']"));

        public const string ExpectedPageText = "Sample Iframe page There are 2 Iframes in this page." +
            " Use browser inspecter or firebug to check out the HTML source. In total you can switch " +
            "between the parent frame, which is this window, and the two frames below";
        public const string ExpectedTextFrameOne = "This is a sample page";
        
        public static Element FrameOneText = new(By.XPath("//*[@id='sampleHeading']"));
        public static Element PageText = new(By.XPath("//*[@id='framesWrapper']//div[1]"));

        public static void SwitchToFrameOne() => _frameOne.SwitchToFrame();
        public static void ExitFrame() => _frameOne.ReturnFromFrame();

        public static string GetElementText(Element element) => element.GetElementText();
    }
}