using Homework_22.Pages;

namespace Homework_22.Tests
{
    internal class ModalPageTest : BaseTest
    {
        [Test]
        [Description("First modal test")]
        public void ModalPageTest1()
        {
            MainPage.NavigateToModalPage();

            ModalPage.ClickButton(ModalPage.OpenSmallModal);
            var result = ModalPage.GetPopupText();
            Assert.That(result, Is.EqualTo(ModalPage.ExpectedSmallModalText));

            ModalPage.ClickButton(ModalPage.CloseSmallModal);

            Thread.Sleep(2000);

            var check = ModalPage.CheckThatSmallPopupClosed();
            Assert.That(check, Is.False);

            ModalPage.ClickButton(ModalPage.OpenLargeModal);
            result = ModalPage.GetPopupText();
            Assert.That(result, Is.EqualTo(ModalPage.ExpectedLargeModalText));

            ModalPage.ClickButton(ModalPage.CloseLargeModal);

            Thread.Sleep(2000);

            check = ModalPage.CheckThatLargePopupClosed();
            Assert.That(check, Is.False);
        }
    }
}
