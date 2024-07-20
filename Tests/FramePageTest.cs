using Homework_22.Pages;

namespace Homework_22.Tests
{
    internal class FramePageTest : BaseTest
    {
        [Test]
        [Description("Frame test")]
        public void FramePageTest1()
        {
            MainPage.NavigateToFramesPage();

            FramePage.SwitchToFrameOne();
            var result = FramePage.GetElementText(FramePage.FrameOneText);
            Assert.That(result, Is.EqualTo(FramePage.ExpectedTextFrameOne));

            FramePage.ExitFrame();
            var pageResult = FramePage.GetElementText(FramePage.PageText);
            Assert.That(pageResult, Is.EqualTo(FramePage.ExpectedPageText));
        }
    }
}
