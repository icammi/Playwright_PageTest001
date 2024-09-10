using Microsoft.Playwright.NUnit;

namespace Playwright_PageTest001
{
    [TestFixture]
    public class TestExecutionExtent : PageTest
    {
        #region HOOKS
        [OneTimeSetUp]
        public async Task ClassInit()
        {

        }

        [OneTimeTearDown]
        public async Task ClassCleanUp()
        {

        }

        [SetUp]
        public async Task TestSetup()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.CurrentContext.Test.MethodName);
        }

        [TearDown]
        public async Task TearDown()
        {

        }

        #endregion

        [Test]
        [Category("Extent")]
        public async Task Extent_Login_TC()
        {
            LoginHotel loginPage = new (Page);
            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
        }
         
        [Test]
        [Category("Extent")]
        public async Task Extent_SearchHotelExecution_TC()
        {
            LoginHotel loginPage = new (Page);
            SearchHotel searchPage = new (Page);

            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
            await searchPage.Search("Sydney");
        }

        [Test]
        [Category("Extent")]
        public async Task Extent_SelectHotelExecution_TC()
        {
            LoginHotel loginPage = new (Page);
            SearchHotel searchPage = new (Page);
            SelectHotel selectPage = new (Page);

            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
            await searchPage.Search("Sydney");
            await selectPage.Select();
        }

        [Test]
        [Category("Extent")]
        public async Task Extent_BookHotelExecution_TC()
        {
            LoginHotel loginPage = new (Page);
            SearchHotel searchPage = new (Page);
            SelectHotel selectPage = new (Page);
            BookingHotel bookingPage = new (Page);
            
            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
            await searchPage.Search("Sydney");
            await selectPage.Select();
            await bookingPage.BookHotel("Amir", "Imam", "123 Street", "1234567890123456", "VISA", "2", "2025", "123");           
        }
    }


    public class AssemblyInitialize
    {
        [SetUpFixture]
        public class Setup
        {
            [OneTimeSetUp]
            public static void AssemblyLevelSetup()
            {
                // Create Extent Report
                ExtentReport.LogReport("TestReport");
            }

            [OneTimeTearDown]
            public static void AssemblyLevelTearDown()
            {
                ExtentReport.extentReports.Flush();
            }
        }
    }
}