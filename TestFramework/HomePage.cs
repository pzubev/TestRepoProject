using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class HomePage
    {
        public static string Url = "http://telerikacademy.com";
        private static string PageTitle = "Софтуерна академия на Телерик (безплатни видео курсове и уроци) - Телерик Академия - Студентска система";

        public bool IsAtHQCPage(string courseName)
        {
            var coursePage = new AuthorsPage();
            PageFactory.InitElements(Browser.Driver, coursePage);
            return coursePage.Course == courseName;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='Menu']/li[3]/a")]
        private IWebElement courseLink;

        public void SelectCourse(string courseName)
        {
            var entry = Browser.Driver.FindElement(By.Id("EntranceButton"));
            entry.Click();
            courseLink.Click();
            var course = Browser.Driver.FindElement(By.LinkText(courseName));
            course.Click();
        }

        public void GoTo()
        {
            Browser.NavigateTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }

}
