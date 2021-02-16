using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace selenium.Tests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CreateNewCustomer()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customers")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Sam");
            driver.FindElement(By.Id("Address")).SendKeys("Richmond");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            
           

        }
        [TestMethod]
        public void ChangeCustomerNameAndAddress()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customers")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[3]/a[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Address")).Clear();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Name")).SendKeys("Heeja");
            driver.FindElement(By.Id("Address")).SendKeys("Burnaby");
            driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[3]/div/input")).Click();


        }

        [TestMethod]
        public void AccessCustomerDetailPage()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customers")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[3]/a[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.XPath("/ html / body / div[2] / p / a[2]")).Click();


        }


        [TestMethod]
        public void DelelteCustomer()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customers")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[4]/td[3]/a[3]")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            driver.FindElement(By.XPath("/ html / body / div[2] / div / form / div / input")).Click();


        }

        [TestMethod]
        public void CreateNewEmplyee()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Tom");
            driver.FindElement(By.Id("Address")).SendKeys("Vancouver");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            


        }

        [TestMethod]
        public void ChnageEmployeeNameAndAddress()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[4]/a[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Address")).Clear();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("Name")).SendKeys("Heeja");
            driver.FindElement(By.Id("Address")).SendKeys("Burnaby");
            driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[3]/div/input")).Click();


        }

        [TestMethod]
        public void AccessEmployeeDetailPage()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[3]/a[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.XPath("/ html / body / div[2] / p / a[2]")).Click();


        }
        [TestMethod]
        public void DelelteEmployee()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[4]/a[3]")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.XPath("/html/body/div[2]/div/form/div/input")).Click();


        }


        [TestMethod]
        public void CreateServiceAndEmployee()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Mike");
            driver.FindElement(By.Id("Address")).SendKeys("Vancouver");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            driver.FindElement(By.LinkText("Services")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.Id("ServiceID")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.XPath("//*[@id='ServiceID']/option[4]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("ServiceType")).SendKeys("Prescription");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("CustomerID")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//*[@id='CustomerID']/option[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[4]/div/input")).Click();


        }

        [TestMethod]
        public void DelectService()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[4]/a[3]")).Click();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.XPath("/ html / body / div[2] / div / form / div / input")).Click();
           

        }


        [TestMethod]
        public void AccessServiceDetail()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "https://localhost:44381";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employees")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[4]/a[2]")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            


        }
    }
}
