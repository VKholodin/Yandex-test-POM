using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace YandexSimpleTest
{
  
   public class Driver
   {
      public static IWebDriver Instance { get; set; }

      public static void Initialize()
      {
         Instance = new ChromeDriver();
         Instance.Manage().Window.Maximize();
         Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      }

      public static void Close()
      {
         Instance.Close();
      }
   }
}
