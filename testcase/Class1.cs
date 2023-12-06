using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace testcase
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        // IWebDriver ege = new EdgeDriver(); 
        //[TestCase]
        //public void mainTitle()
        //{
        //    driver.Url = "https://58shkola.ru/";
        //    Assert.That(driver.Title, Is.EqualTo("Îáðàçîâàòåëüíàÿ ïëàòôîðìà Êàëèíèíãðàäñêîãî áèçíåñ-êîëëåäæà"));
        //    ege.Url = "https://58shkola.ru/";
        //    Assert.That(ege.Title, Is.EqualTo("Îáðàçîâàòåëüíàÿ ïëàòôîðìà Êàëèíèíãðàäñêîãî áèçíåñ-êîëëåäæà"));
        //}

        [TestCase]
        public void TC_UI_1()
        {
            //контакты
            driver.Url = "https://58shkola.ru/";
            IWebElement tc1 = driver.FindElement(By.XPath("/html/body/header/div[2]/nav/div/ul/li[2]/ul/li[5]/a"));
            tc1.Click();
        }
        [TestCase]
        public void TC_UI_2()
        {
            //поисковая строка
            driver.Url = "https://58shkola.ru/";
            IWebElement input = driver.FindElement(By.XPath("/html/body/header/div[1]/form/div/input"));
            input.SendKeys("КГТУ");
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/div[1]/form/div/i"));
            button.Click();
        }
        [TestCase]
        public void TC_UI_3()
        {
            //проверка кнопок для слабовидящих
            driver.Url = "https://58shkola.ru/";
            IWebElement tc1 = driver.FindElement(By.XPath("/html/body/div[2]/a"));
            tc1.Click();
            driver.Url = "https://58shkola.ru/";
            IWebElement tc2 = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/a[2]"));
            tc2.Click();
        }
        [TestCase]
        public void TC_UI_4()
        {
            //Электронный журнал
            driver.Url = "https://58shkola.ru/";
            IWebElement button = driver.FindElement(By.XPath("/html/body/div[2]/header/div[2]/nav/div/ul/li[3]/ul/li[19]/a"));
            button.Click();
        }
        [TestCase]
        public void TC_UI_5()
        {
            //Электроная почта
            driver.Url = "https://58shkola.ru/";
            IWebElement button = driver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/span[2]/a"));
            button.Click();
        }
    }
}
