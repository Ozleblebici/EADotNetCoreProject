using CrossPlatformEATest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {

        public EmployeeListPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement txtSearch => _parallelConfig.Driver.FindElement(By.Name("searchTerm"));

        IWebElement lnkCreateNew => _parallelConfig.Driver.FindElement(By.LinkText("Create New"));

        IWebElement lnkCreateNewss => _parallelConfig.Driver.FindElement(By.LinkText("Create New"));

        IWebElement tblEmployeeList => _parallelConfig.Driver.FindElement(By.ClassName("table"));

        IWebElement lnkLogoff => _parallelConfig.Driver.FindElement(By.LinkText("Log off"));

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage(_parallelConfig);
        }

        public CreateEmployeePage ClickCreateNews()
        {
            lnkCreateNewss.Click();
            return new CreateEmployeePage(_parallelConfig);
        }


        public IWebElement GetEmployeeList()
        {
            return tblEmployeeList;
        }

        internal void ClickLogoff()
        {
            lnkLogoff.Click();
        }
    }
}
