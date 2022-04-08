using EAAutoFramework.Base;
using OpenQA.Selenium;
using EAAutoFramework.Extensions;


namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig) { }


        IWebElement txtUserName => _parallelConfig.Driver.FindById("UserName");
        

        IWebElement txtPassword => _parallelConfig.Driver.FindById("Password");

        IWebElement btnLogin => _parallelConfig.Driver.FindByCss("input.btn");

        IWebElement btnLoginss => _parallelConfig.Driver.FindByCss("input.btn");


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return new HomePage(_parallelConfig);
        }


        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }

        internal BasePage ClickLoginButtons()
        {
            btnLoginss.Submit();
            return new HomePage(_parallelConfig);
        }
    }
}
