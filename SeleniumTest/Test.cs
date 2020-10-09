using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class Test
    {
        IWebDriver driver;

        public void otworzPrzegladarke()
        {
            driver = new ChromeDriver();
            driver.Url = "https://bluepartner.eu/pl/kontakt/";
        }

        public void wypelnijFormularz()
        {
            StronaKontaktowa strona = new StronaKontaktowa(driver);
            strona.wypelnijImieNazwisko("CloudServices Test");
            strona.wypelnijEmail(generujAdresEmail());
            strona.wybierzTematZListy("Rozliczenie");
            strona.wypelnijTresc("automat test CloudServices");
            strona.schowajInformacjeCookies();
            strona.zaznaczZgode();
            strona.kliknijWyslij();
        }

        private string generujAdresEmail()
        {
            Random random = new Random();
            int num = random.Next(0,2);
            string adres = "";

            switch (num)
            {
                case 0:
                    adres += "abcd";
                    break;
                case 1:
                    adres += "info";
                    break;
                case 2:
                    adres += "jan.kowalski";
                    break;
                default:
                    goto case 0;
            }

            adres += "@";
            num = random.Next(0, 2);

            switch (num)
            {
                case 0:
                    adres += "gmail.com";
                    break;
                case 1:
                    adres += "bluepartner.eu";
                    break;
                case 2:
                    adres += "wp.pl";
                    break;
                default:
                    goto case 0;
            }

            return adres;
        }

    }
}
