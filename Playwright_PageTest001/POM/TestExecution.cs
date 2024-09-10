using Microsoft.Playwright.NUnit;

namespace Playwright_PageTest001
{
    [TestFixture]
    public class TestExecution : PageTest
    {
        [Test]
        public async Task LoginExecution_TC()
        {
            LoginPage loginPage = new (Page);
            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
        }

        [Test]
        public async Task SearchHotelExecution_TC()
        {
            LoginPage loginPage = new (Page);
            SearchPage searchPage = new (Page);

            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
            await searchPage.SearchHotel("Sydney");
        }

        [Test]
        public async Task BookHotelExecution_TC()
        {
            LoginPage loginPage = new (Page);
            SearchPage searchPage = new (Page);
            SelectPage selectPage = new (Page);
            BookingPage bookingPage = new (Page);

            await loginPage.Login("https://adactinhotelapp.com/", "icam1961", "igcA2822.135");
            await searchPage.SearchHotel("Sydney");
            await selectPage.SelectHotel();
            await bookingPage.BooktHotel("Amir", "Imam", "123 Street", "1234567890123456", "VISA", "2", "2025", "123");
        }
    }
}