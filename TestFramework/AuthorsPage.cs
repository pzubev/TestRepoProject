using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class AuthorsPage
    {
        [FindsBy(How =How.Id, Using = "#panel-title")]
        private IWebElement courseTitle;

        public string Course
        {
            get
            {
                return courseTitle.Text;
            }
        }
    }
}