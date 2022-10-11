
using System.Collections.Generic;
using System.Web;

using Clientapp_Tester.TestScenarios;
using Clientapp_Tester.Selenium.Factories;
using Clientapp_Tester.Selenium.Common;
using Clientapp_Tester.Selenium.PageObjects;
using ClassGloballibrary;
using DNata.TestData;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

using TestFramework.Extensions;
using Testdata = DNata.TestData.Config;
using Shouldly;

using KillSystemProcess = TestFramework.Extensions.KillSystemProcess;
using Logger = NLog.Logger;

using ProcessNames = Clientapp_Tester.TestData.ConfigAssessment.ProcessNames;

using Clientapp_Tester.Selenium.PageObjects.DynamicPageObjects;


namespace DNata_Testing.TestPages
{
    public class DNata_Pages_Objects
    {
        public class DNataPages
        {

            private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
            public static IWebDriver _driver;

            ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

            public DNataPages(IWebDriver _driver)
            {
                PageFactory.InitElements(_driver, this);
                _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            }

            public string PageTitle { set; get; } = "Home";

            public static class homepagelist
            {
                public static List<string> homepagelistitems = new List<string>();
            }
            public static class homepagelist_muliple
            {
                public static List<IWebElement> homepagelistitems_multiple = new List<IWebElement>();
            }

            public class homepageitems
            {
                [FindsBy(How = How.XPath, Using = @"//div[(@class='c-header__logo')]")]
                [CacheLookup]
                public IWebElement dnata_homepage_logo { get; set; }
                public static string element_dnata_homepage_logo = @"//div[(@class='c-header__logo')]";

             //   [FindsBy(How = How.XPath, Using = @"//div[(@class='c-header__tablinks hide-tablet')]")]
             //   [CacheLookup]
             //   public IWebElement dnata_buttontravel;
             //   public static string element_dnata_buttontravel = "//button[(@class='c-header__navbtn show-tablet')]";

                [FindsBy(How = How.XPath, Using = @"//button[(@class='c-header__navbtn show-tablet')]")]
                [CacheLookup]
                public IWebElement dnata_buttontravel;
                public static string element_dnata_buttontravel = @"//div[(@class='c-header__tablinks hide-tablet')]";

                [FindsBy(How = How.XPath, Using = @"//input[@class='c-header-search__input']")]
                [CacheLookup]
                public IWebElement dnata_search;
                public static string element_dnata_search = @"//input[@class='c-header-search__input']";

             // [FindsBy(How = How.XPath, Using = @"//ul[@class='topNavS']")]
             // [CacheLookup]
             // public IWebElement dnata_about;
             // public static string element_dnata_about = @"//ul[@class='topNavS']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/news']")]
                [CacheLookup]
                public IWebElement dnata_news;
                public static string element_dnata_news = @"//a[@href='/en/news']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/careers']")]
                [CacheLookup]
                public IWebElement dnata_careers;
                public static string element_dnata_careers = @"//a[@href='/en/careers']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/contact-us']")]
                [CacheLookup]
                public IWebElement dnata_contact_us;
                public static string element_dnata_contact_us = @"//a[@href='/en/contact-us']";

                /// home page header links

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/ground-handling']")]
                [CacheLookup]
                public IWebElement dnata_ground_handling;
                public static string element_dnata_ground_handling = @"//a[@href='/en/ground-handling']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/cargo']")]
                [CacheLookup]
                public IWebElement dnata_cargo;
                public static string element_dnata_cargo = @"//a[@href='/en/cargo']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/catering']")]
                [CacheLookup]
                public IWebElement dnata_catering;
                public static string element_dnata_catering = @"//a[@href='/en/catering']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/travel']")]
                [CacheLookup]
                public IWebElement dnata_travel;
                public static string element_dnata_travel = @"//a[@href='/en/travel']";

                [FindsBy(How = How.XPath, Using = @"//a[@href='/en/global-network']")]
                [CacheLookup]
                public IWebElement dnata_global_network;
                public static string element_dnata_global_network = @"//a[@href='/en/global-network']";


                /// home page upper links
                [FindsBy(How = How.XPath, Using = @"//a[contains(@href,'https://www.youtube.com/watch?')]")]
                [CacheLookup]
                public IWebElement dnata_content_seeourvideo;
                public static string element_dnata_seeourvideo = @"//a[contains(@href,'https://www.youtube.com/watch?')]";

                [FindsBy(How = How.XPath, Using = @"//span[contains(@class,'swiper-pagination-bullet swiper-pagination-bullet-active')]")]
                [CacheLookup]
                public IWebElement dnata_pagination_bullet;
                public static string element_dnata_pagination_bullet = @"//span[contains(@class,'swiper-pagination-bullet swiper-pagination-bullet-active')]";

                ///Info line

                // images

                [FindsBy(How = How.XPath, Using = @"//div[(@class='row justar')]/div[4]")]
                [CacheLookup]
                public IWebElement dnata_image_part1;
                public static string element_dnata_image1 = @"//img[contains(@src,'/en/media/v-4')]";

            }

            public static List<string> DNata_Homepage(IWebDriver _driver)
            {
                homepagelist.homepagelistitems.Clear();
                
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_homepage_logo);
             // homepagelist.homepagelistitems.Add(homepageitems.element_dnata_buttontravel);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_search);
             // homepagelist.homepagelistitems.Add(homepageitems.element_dnata_about);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_news);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_careers);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_contact_us);
                                
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_ground_handling);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_cargo);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_catering);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_travel);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_global_network);
                
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_seeourvideo);
                homepagelist.homepagelistitems.Add(homepageitems.element_dnata_pagination_bullet);
  
                return homepagelist.homepagelistitems;
            }

            public static List<IWebElement> DNata_HomepageElements(IWebDriver _driver)
            {
                homepagelist_muliple.homepagelistitems_multiple.Clear();
                
                var results = _driver.FindElements(By.XPath("//a[@href='/en/about']"));
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }

                results = _driver.FindElements(By.XPath("//div[@class='hero-content-text']")); 
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }

                results = _driver.FindElements(By.XPath("//div[(@class='statWrap')]"));
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }

                results = _driver.FindElements(By.XPath("//div[@class='linkbox']"));
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }
                
                results = _driver.FindElements(By.XPath("//a[(@class='probox--list--link')]"));
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }
                
                /*
                var results = _driver.FindElements(By.XPath("//span[(@itemprop='name')]"));
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }

                results = _driver.FindElements(By.XPath("//i[(@ng-if='mbi.hasMegamenu')]"));
                for (int groupIndex = 0; groupIndex < results.Count; groupIndex++)
                {
                    homepagelist_muliple.homepagelistitems_multiple.Add(results[groupIndex]);
                }*/
                
                return homepagelist_muliple.homepagelistitems_multiple;
            }

        }
    }
}

