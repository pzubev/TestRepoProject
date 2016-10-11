using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Go_To_TelerikAcademy_Home_Page()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }


        [TestMethod]
        public void Can_Go_To_HQC_Course_Page()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectCourse("Качествен програмен код - част 2 (септември 2016)");
            Assert.IsTrue(Pages.HomePage.IsAtHQCPage("Качествен програмен код - част 2 (септември 2016)"));
        }


        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
