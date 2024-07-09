using Homework_21.Pages;

namespace Homework_21.Tests
{
    internal class NestedFramesPageTest : BaseTest
    {
        [Test]
        [Description("Nested Frames test")]
        public void NestedFramesPageTest1()
        {
            MainPage.NavigateToNestedFramesPage();

            NestedFramesPage.SwitchToFrame(NestedFramesPage._frameOne);
            var result = NestedFramesPage.GetElementText(NestedFramesPage.ParentFrameText);
            Assert.That(result, Is.EqualTo(NestedFramesPage.ExpectedParentFrameText));

            NestedFramesPage.SwitchToFrame(NestedFramesPage._frameChild);
            result = NestedFramesPage.GetElementText(NestedFramesPage.ChildFrameText);
            Assert.That(result, Is.EqualTo(NestedFramesPage.ExpectedChildFrameText));
        }
    }
}
