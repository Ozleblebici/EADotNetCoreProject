using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;

namespace EAAutoFramework.Extensions
{
    public static class WebDriverExtensions
    {


        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = ((IJavaScriptExecutor)dri).ExecuteScript("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            LoopingWait(obj, timeOut, execute, stopWatch);

            static void LoopingWait<T>(T obj, int timeOut, Func<T, bool> execute, Stopwatch stopWatch)
            {
                while (stopWatch.ElapsedMilliseconds < timeOut)
                {
                    if (execute(obj))
                    {
                        break;
                    }
                }
            }
        }

        public static IWebElement FindById(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementById(element).IsElementPresent())
                {
                    return remoteWebDriver.FindElementById(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        public static IWebElement FindByXpath(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementByXPath(element).IsElementPresent())
                {
                    return remoteWebDriver.FindElementByXPath(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        public static IWebElement FindByCss(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementByCssSelector(element).IsElementPresent())
                {
                    return remoteWebDriver.FindElementByCssSelector(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        public static IWebElement FindByLinkText(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementByLinkText(element).IsElementPresent())
                {
                    return remoteWebDriver.FindElementByLinkText(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

    }
}
