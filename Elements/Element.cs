using Homework_21.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Homework_21.WebElements
{
    internal class Element
    {
        private readonly By? _locator;
        private Actions actions = new Actions(Driver.GetDriver());

        public Element(By locator) => _locator = locator;

        public IWebElement FindWebElement
        {
            get
            {
                WaitWebElementPresent();
                return Driver.GetDriver().FindElement(_locator);   
            }
        }

        public void WaitWebElementPresent() => Driver.GetWait(Driver.GetDriver()).Until(drv => drv.FindElements(_locator).Count() > 0);

        public static void WaitAlertPresent() => Driver.GetWait(Driver.GetDriver()).Until(drv => IsAlertVisible());

        public void SendValue(string value)
        {
            ScrollToElement();
            FindWebElement.SendKeys(value);
        }

        public void ClickElement()
        {
            ScrollToElement();
            FindWebElement.Click();
        }

        public string GetElementAttribute(string atr) => FindWebElement.GetAttribute(atr);

        public void ScrollToElement() => actions.MoveToElement(FindWebElement);

        //public void ScrollToElementByJS() => ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("argument[0].scrollIntoView(true)", FindWebElement);

        public static void AcceptAlert()
        {
            var alert = Driver.GetDriver().SwitchTo().Alert();
            alert.Accept();
        }

        public static bool IsAlertVisible()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public void SwitchToFrame()
        {
            Driver.GetDriver().SwitchTo().Frame(FindWebElement);
        }
        public void ReturnFromFrame()
        {
            Driver.GetDriver().SwitchTo().DefaultContent();
        }

        public string GetElementText() => FindWebElement.Text;


    }
}