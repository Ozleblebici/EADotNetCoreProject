using System;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using EAEmployeeTest.Pages;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class CreateEmployeePage : BasePage
    {
        public CreateEmployeePage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
        }

        IWebElement txtName => _parallelConfig.Driver.FindById("Name");

        IWebElement txtSalary => _parallelConfig.Driver.FindById("Salary");

        IWebElement txtDurationWorked => _parallelConfig.Driver.FindById("DurationWorked");

        IWebElement txtGrade => _parallelConfig.Driver.FindById("Grade");

        IWebElement txtEmail => _parallelConfig.Driver.FindById("Email");

        IWebElement btnCreateEmployee => _parallelConfig.Driver.FindByXpath("//input[@value='Create']");


        internal EmployeeListPage ClickCreateButton()
        {
            btnCreateEmployee.Submit();
            return new EmployeeListPage(_parallelConfig);
        }


        internal void CreateEmployee(string name, string salary, string durationworked, string grade, string email)
        {
            txtName.SendKeys(name);
            txtSalary.SendKeys(salary);
            txtDurationWorked.SendKeys(durationworked);
            txtGrade.SendKeys(grade);
            txtEmail.SendKeys(email);
        }

    }
}
