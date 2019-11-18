using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Crapy
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            using (var driver = new ChromeDriver())
            {
               
                driver.Navigate().GoToUrl("https://www.cellspare.com/other/realme-spare-parts/realme-xt-spare-parts/realme-xt-lcd-screen-with-digitizer-module-black");

               // driver.Manage().Window.Size = new Size(2, 2);
                //var userNameField = driver.FindElementById("usr");
                //var userPasswordField = driver.FindElementById("pwd");
                //var loginButton = driver.FindElementByXPath("//input[@value='Login']");


                //userNameField.SendKeys("admin");
                //userPasswordField.SendKeys("12345");

                //// and click the login button
                //loginButton.Click();

                // Extract the text and save it into result.txt
                var result = driver.FindElementByXPath("//div[@class='location-bar']/h1").Text;
                var res = driver.FindElementByXPath("//div[@class='price']/div[@class='price-regular']").Text;
                // var result = driver.FindElement(By.XPath("//div/a")).ToString();
                //IReadOnlyList<IWebElement> muchoCheese = driver.FindElements(By.CssSelector("#cheese li"));
               
                List<String> ll = new List<string>();
                ll.Add(result);
                ll.Add(res);
                
                foreach (String s in ll)
                {
                    File.AppendAllText("result.txt", "\n"+s+"\t");
                }
                driver.Quit();
                Console.WriteLine("here is the result "+result);
              

                // Take a screenshot and save it into screen.png
                //     driver.GetScreenshot().SaveAsFile(@"screen.png");
            }
        }
    }
}