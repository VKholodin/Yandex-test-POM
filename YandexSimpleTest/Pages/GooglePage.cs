using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using YandexSimpleTest.Elements;

namespace YandexSimpleTest
{
   public class GooglePage
   {

      public static void GoTo()
      {
         Driver.Instance.Navigate().GoToUrl(PageElements.BaseURL);
         var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
         wait.Until(d => d.Title.Equals("Google"));
      }

      public static void EnterSearchCriteria(String search)
      {
         var _search = Driver.Instance.FindElement(By.Name("q"));
         _search.SendKeys(search);
         _search.Submit();
      }

      public static void VerifySearchCriteria(string expected_value)
      {  
         var links = Driver.Instance.FindElements(By.XPath(PageElements.AllPageLinks))
            .FirstOrDefault();
         if (links != null)
         {
            var firstlink = links.Text;
            if (firstlink == null) throw new NoSuchElementException(nameof(firstlink));
            Assert.IsTrue(firstlink==expected_value, "it's not an expected link:{0} since actual one is:{1}", firstlink, expected_value);
         }
      }
   }
}
