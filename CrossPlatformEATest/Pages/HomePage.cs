using System;
using System.Data;
using System.Linq;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement lnkLogin => _parallelConfig.Driver.FindByLinkText("Login");

        IWebElement lnkEmployeeList => _parallelConfig.Driver.FindByLinkText("Employee List");

        IWebElement lnkLoggedInUser => _parallelConfig.Driver.FindByXpath("//a[@title='Manage']");

        IWebElement lnkLogoff => _parallelConfig.Driver.FindByLinkText("Log off");


        internal void CheckIfLoginExist()
        {
            lnkLogin.AssertElementPresent();
        }


        internal LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return new LoginPage(_parallelConfig);
        }

        internal string GetLoggedInUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }

        public EmployeeListPage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return new EmployeeListPage(_parallelConfig);
        }

        public LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return new LoginPage(_parallelConfig);
        }
    }
}
