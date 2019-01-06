using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YandexSimpleTest.Elements;

namespace YandexSimpleTest.Test
{
   [TestClass]
   public class YandexTest
   {
      
      [TestInitialize]
      public void Init()
      {
         Driver.Initialize();
      }

      [TestMethod]
      public void VerifyYandexLinkAsFisrt()
      {
        GooglePage.GoTo();
        GooglePage.EnterSearchCriteria(PageElements.SearchLink);
        GooglePage.VerifySearchCriteria(PageElements.ExpectedLinkValue);
      }

      [TestCleanup]
      public void Cleanup()
      {
         Driver.Close();
      }

   }
}
