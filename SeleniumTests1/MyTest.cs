using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject
{
    class MyTests
    {
        [Test]
        public void RegisterTest()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");

            driver.FindElement(By.XPath("//a[text()='REGISTER']")).Click();

            driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys("Anq");
            driver.FindElement(By.XPath("//input[@name='lastName']")).SendKeys("Vis");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("1234567890");
            driver.FindElement(By.XPath("//input[@name='userName']")).SendKeys("my@email.com");

            driver.FindElement(By.XPath("//input[@name='address1']")).SendKeys("123 Best Street");
            driver.FindElement(By.XPath("//input[@name='city']")).SendKeys("London");
            driver.FindElement(By.XPath("//input[@name='state']")).SendKeys("Middlesex");
            driver.FindElement(By.XPath("//input[@name='postalCode']")).SendKeys("AB1 2CD");

            IWebElement dd = driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement countryDropDown = new SelectElement(dd);
            countryDropDown.SelectByText("UNITED KINGDOM ");

            driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("AnqTest1");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("hello123");
            driver.FindElement(By.XPath("//input[@name='confirmPassword']")).SendKeys("hello123");

            //driver.FindElement(By.XPath("//input[@name='register']")).Click();

            //driver.Close();
        }



        [Test]
        public void LoginTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");

            driver.FindElement(By.XPath("//input[@name='userName']")).SendKeys("AnqTest1");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("hello123");
            //driver.FindElement(By.XPath("//input[@name='login']")).Click();

            //if (driver.FindElement(By.XPath("//a[text()='PROFILE']")).Displayed)
            //{
            //    Console.Write("Login successful");
            //}
            //else
            //{
            //    Console.WriteLine("Login did not work");
            //}

           

        }


        //pre-req to login first
        [Test]
        public void SearchFlightTest()
        {
            IWebElement mySelector;
            SelectElement selectThisEle;
            IWebDriver driver = new ChromeDriver();

            driver.FindElement(By.XPath("//input[@value='oneway']")).Click();

            mySelector = driver.FindElement(By.XPath("//select[@name='passCount']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByValue("3");

            mySelector = driver.FindElement(By.XPath("//select[@name='fromPort']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByText("London");

            mySelector = driver.FindElement(By.XPath("//select[@name='fromMonth']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByText("July");

            mySelector = driver.FindElement(By.XPath("//select[@name='fromDay']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByIndex(3);

            mySelector = driver.FindElement(By.XPath("//select[@name='toPort']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByText("Paris");

            mySelector = driver.FindElement(By.XPath("//select[@name='toMonth']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByText("August");

            mySelector = driver.FindElement(By.XPath("//select[@name='toDay']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByText("10");

            driver.FindElement(By.XPath("//input[@value='First']")).Click();

            mySelector = driver.FindElement(By.XPath("//select[@name='airline']"));
            selectThisEle = new SelectElement(mySelector);
            selectThisEle.SelectByText("Unified Airlines");

            driver.FindElement(By.XPath("//input[@name='findFlights']")).Click();

            driver.Close();
        }

    }
}
