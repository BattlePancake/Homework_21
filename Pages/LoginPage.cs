using Homework_22.Factory;
using Homework_22.WebElements;
using OpenQA.Selenium;

namespace Homework_22.Pages
{
    internal class LoginPage : BasePage
    {

        private const string _userName = "standard_user";
        private const string _password = "secret_sauce";

        private static Element _userNameField = new Element(By.XPath("//*[@id='user-name']"));
        private static Element _passwordField = new (By.XPath("//*[@id='user-name']"));
        private static Element _loginButton = new (By.XPath("//*[@id='user-name']"));

        //private static IWebElement userNameFieldOne => Driver.GetWait(driver).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='user-name']")));
        //private static IWebElement passwordFieldOne => Driver.GetWait(driver).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='password']")));
        //private static IWebElement loginButtonOne => Driver.GetWait(driver).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login-button']")));

        public static void Login()
        {
            _userNameField.SendValue(_userName);
            _passwordField.SendValue(_password);
            //userNameField.SendKeys(_userName);
            //passwordField.SendKeys(_password);
            _loginButton.ClickElement();
        }

    }
}