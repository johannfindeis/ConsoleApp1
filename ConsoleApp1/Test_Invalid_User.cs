using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ConsoleApp1
{
    class Test_Invalid_User 
    {
        static void Main(string[] args)
        {   

            // invalid user test
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            driver.FindElement(By.Name("user-name")).SendKeys("standard_user_invalid");

            driver.FindElement(By.Name("password")).SendKeys("secret-sauce");
            driver.FindElement(By.Name("login-button")).Click();


            if (driver.Url == "https://www.saucedemo.com/inventory.html")
            {
                driver.Quit();
            }
            else
            {
                Console.WriteLine("test failed!");
            }
        }
    }
}
