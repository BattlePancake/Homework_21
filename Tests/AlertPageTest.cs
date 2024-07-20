using Homework_22.Pages;
using Homework_22.WebElements;

namespace Homework_22.Tests
{
    internal class AlertPageTest : BaseTest
    {
        [Test]
        [Description("First alert accepting test")]
        public void AllertPageTest1()
        {
            MainPage.NavigateToAlertsPage();

            AlertPage.OpenAlert(AlertPage._alertButtonOne);
            var result = AlertPage.CheckAlert();
            Assert.That(result, Is.True);

            AlertPage.AcceptAlert();
            result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("Second alert accepting test")]
        public void AllertPageTest2()
        {
            MainPage.NavigateToAlertsPage();

            AlertPage.OpenAlert(AlertPage._alertButtonTwo);
            var result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);

            //Thread.Sleep(5000);
            Element.WaitAlertPresent();

            result = AlertPage.CheckAlert();
            Assert.That(result, Is.True);

            AlertPage.AcceptAlert();
            result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("Third alert accepting test")]
        public void AllertPageTest3()
        {
            MainPage.NavigateToAlertsPage();

            AlertPage.OpenAlert(AlertPage._alertButtonThree);
            var result = AlertPage.CheckAlert();
            Assert.That(result, Is.True);

            AlertPage.AcceptAlert();
            result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("Fourth alert accepting test")]
        public void AllertPageTest4()
        {
            MainPage.NavigateToAlertsPage();

            AlertPage.OpenAlert(AlertPage._alertButtonFour);
            var result = AlertPage.CheckAlert();
            Assert.That(result, Is.True);

            AlertPage.AcceptAlert();
            result = AlertPage.CheckAlert();
            Assert.That(result, Is.False);
        }
    }
}
