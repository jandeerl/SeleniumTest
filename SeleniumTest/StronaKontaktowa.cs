using OpenQA.Selenium;

namespace SeleniumTest
{
        public class StronaKontaktowa
        {
            public IWebDriver driver;

            public StronaKontaktowa(IWebDriver driver)
            {
                this.driver = driver;
            }

            #region Elementy strony
            By imieNazwisko = By.Name("imie-i-nazwisko");
            By email = By.Name("e-mail");
            By wybierzTemat = By.Id("select2-id_wybierz-temat-container");
            By tresc = By.Name("tresc");
            By cookies = By.XPath("/html/body/div[1]/a");
            By zgoda = By.XPath("/html/body/div[2]/section/div[2]/div/div/div[1]/div/form/div/div[6]/div[1]/div/label");
            By wyslij = By.XPath("/html/body/div/section/div[2]/div/div/div[1]/div/form/div/div[7]/div/div/button");
            #endregion

            public void wypelnijImieNazwisko(string tekst)
            {
                driver.FindElement(imieNazwisko).SendKeys(tekst);
            }
        
            public void wypelnijEmail(string tekst)
            {
            driver.FindElement(email).SendKeys(tekst);
            }
            
            public void wybierzTematZListy(string tekst)
            {
            driver.FindElement(wybierzTemat).Click();
            driver.FindElement(By.XPath("//*[text()=\"" +tekst+ "\"]")).Click();
            }

            public void wypelnijTresc(string tekst)
            {
            driver.FindElement(tresc).SendKeys(tekst);
            }

            //funkcja potrzebna, żeby kliknięcia myszki nie były przechwytywane
            public void schowajInformacjeCookies()
            {
            driver.FindElement(cookies).Click();
            }
            public void zaznaczZgode()
            {
            driver.FindElement(zgoda).Click();
            }
            
            public void kliknijWyslij()
            {
            driver.FindElement(wyslij).Click();
            }
        }
}
