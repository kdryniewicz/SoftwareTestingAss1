using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Test2
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void The2Test()
        {
            driver.Navigate().GoToUrl("http://localhost:53807/");
            driver.FindElement(By.Id("Male")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("24");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            try
            {
                Assert.AreEqual("on", driver.FindElement(By.Id("Male")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            Assert.AreEqual("on", driver.FindElement(By.Id("Male")).GetAttribute("value"));
            try
            {
                Assert.AreEqual("24", driver.FindElement(By.Name("age")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            Assert.AreEqual("24", driver.FindElement(By.Name("age")).GetAttribute("value"));
            driver.FindElement(By.Id("body")).Click();
            driver.FindElement(By.XPath("//div[@id='body']/section[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='body']/section[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='body']/section[2]")).Click();
            try
            {
                Assert.AreEqual("Your Premium is 6", driver.FindElement(By.XPath("//div[@id='body']/section[2]/b")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            Assert.AreEqual("Your Premium is 6", driver.FindElement(By.XPath("//div[@id='body']/section[2]/b")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
