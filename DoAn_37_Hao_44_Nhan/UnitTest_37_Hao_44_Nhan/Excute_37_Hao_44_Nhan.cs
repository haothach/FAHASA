using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTest_37_Hao_44_Nhan
{
    [TestClass]
    public class Excute_37_Hao_44_Nhan
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://www.fahasa.com/");
            Thread.Sleep(1000);
            IWebElement clear = driver.FindElement(By.ClassName("fhs_top_account_button"));
            clear.Click();
            Thread.Sleep(1000);
            IWebElement user = driver.FindElement(By.Id("login_username"));
            user.SendKeys("0335607157");
            Thread.Sleep(1000);
            IWebElement pass = driver.FindElement(By.Id("login_password"));
            pass.SendKeys("T123456789");
            Thread.Sleep(1000);
            IWebElement login = driver.FindElement(By.ClassName("fhs-btn-login"));
            login.Click();


        }
    }
}
