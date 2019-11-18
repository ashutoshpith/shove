using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using Newtonsoft.Json;
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


                // Extract the text and save it into result.txt
                var result = driver.FindElementByXPath("//div[@class='location-bar']/h1").Text;
                var res = driver.FindElementByXPath("//div[@class='price']/div[@class='price-regular']").Text;
                // var result = driver.FindElement(By.XPath("//div/a")).ToString();
                //IReadOnlyList<IWebElement> muchoCheese = driver.FindElements(By.CssSelector("#cheese li"));
                Type type = new Type
                {
                    Name = result,
                    Price = res

                };

                // serialize JSON to a string and then write string to a file
                File.AppendAllText("result.json", JsonConvert.SerializeObject(type));

              



                //List<String> ll = new List<string>();
                //ll.Add(result);
                //ll.Add(res);

                //foreach (String s in ll)
                //{
                //    File.AppendAllText("result.json", "\n"+s+"\t");
                //}
                driver.Quit();
                Console.WriteLine("here is the result "+result);
              

                // Take a screenshot and save it into screen.png
                //     driver.GetScreenshot().SaveAsFile(@"screen.png");
            }
        }
    }
}