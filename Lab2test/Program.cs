using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Test
{
    class Program
    {
        private static IWebDriver chromeDriver;
        static void Main(string[] args)
        {
            try
            {
                chromeDriver = new ChromeDriver(@"C:\Users\exolon\Downloads\chromedriver_win32 (1)");
                chromeDriver.Navigate().GoToUrl("https://tyt.by/");
                chromeDriver.FindElement(By.Id("index_email")).SendKeys("sergey");
                chromeDriver.FindElement(By.Id("index_pass")).SendKeys("T32Tye");
                chromeDriver.FindElement(By.XPath("//button[@id='index_login_button']")).Click();
                System.Threading.Thread.Sleep(10000);


                if (chromeDriver != null)
                    chromeDriver.Quit();
            }

            catch (Exception e)
            {
                e.StackTrace.ToString();
                throw;
            }


        }
    }
}
