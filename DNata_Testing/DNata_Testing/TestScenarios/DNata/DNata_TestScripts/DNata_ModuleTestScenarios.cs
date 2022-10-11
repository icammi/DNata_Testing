using System;
using System.Threading;
using System.Collections.Generic;
using Clientapp_Tester.Selenium.Common;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

using TestFramework.Extensions;
using Testdata = DNata.TestData.Config;
using Shouldly;

using KillSystemProcess = TestFramework.Extensions.KillSystemProcess;
using Logger = NLog.Logger;

using ProcessNames = Clientapp_Tester.TestData.ConfigAssessment.ProcessNames;

using Clientapp_Tester.Selenium.PageObjects.DynamicPageObjects;

using ClassUtilities;
using DNata_Testing.TestPages;
using NUnit.Framework;

namespace DNata.TestScenarios
{
    public class DNataModuleTestScenarios
    {
        private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public static IWebDriver _driver;

        ClassUtilities.WaitOnObjects waitonobjects = new ClassUtilities.WaitOnObjects();

        public DNataModuleTestScenarios(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public static void DNata_0050_HighlightHomeLinks(IWebDriver _driver)
        {
            _logger.Trace("Home Page : Started");

            try
            {
           //   var pageobject = new DNata_Pages_Objects.DNataPages(_driver);

                ClassUtilitiesHighlight utilitieshightlight = new ClassUtilitiesHighlight();

                var waitonobjects       = new WaitOnObjects();
                waitonobjects.PageTitle = _driver.Title;
                waitonobjects.ValidatePageLoaded(_driver);

             //   var dnata_homepage          = DNata_Pages_Objects.DNataPages.DNata_Homepage(_driver);
             //   var dnata_HomepageElements  = DNata_Pages_Objects.DNataPages.DNata_HomepageElements(_driver);

                var action = new Action(() =>
                {
                    var currentURL = _driver.Url;

                    WaitOnObjects.ElementEnabled(_driver, null, "byXpath", DNata_Pages_Objects.DNataPages.homepageitems.element_dnata_homepage_logo).Click();
                    ClassUtilitiesScrolling.ScrollWindowBottom(_driver);
                    ClassUtilitiesScrolling.ScrollWindowTop(_driver);

                    //  WaitOnObjects.ElementEnabled(_driver, null, "byXpath", DNata_Pages_Objects.DNataPages.homepageitems.element_homepage_logo);
                    //  Thread.Sleep(500);
                    //  WaitOnObjects.ElementEnabled(_driver, null, "byXpath", pageobject.header_home);
                    //  Thread.Sleep(2000);
                    //  var locationvalueY = _driver.FindElement(By.XPath(usefullinks._ABOUT_DNATA)).Location.Y;
                    //  ClassUtilitiesScrolling.ScrollDownPage(_driver, 0, locationvalueY, 50);
                    //  Thread.Sleep(2000);

                    // var results = _driver.FindElements(By.XPath("//div[@class='linkbox']"));
                    
                    var dnata_homepage = DNata_Pages_Objects.DNataPages.DNata_Homepage(_driver);
                    for (int groupIndex = 0; groupIndex < dnata_homepage.Count; groupIndex++)
                    {
                        WaitOnObjects.ElementEnabledScrollTo(_driver, null, "byXpath", dnata_homepage[groupIndex]);
                    }

                    // results = _driver.FindElements(By.XPath("//div[@class='probox--list--link"));
                    var dnata_homepageelements = DNata_Pages_Objects.DNataPages.DNata_HomepageElements(_driver);
                    for (int groupIndex = 0; groupIndex < dnata_homepageelements.Count; groupIndex++)
                    {
                        utilitieshightlight.highlightElement(_driver, dnata_homepageelements[groupIndex], string.Empty, string.Empty);
                    }
                    
                    ClassUtilitiesScrolling.ScrollWindowTop(_driver);

            //      utilitieshightlight.highlightElement(_driver, null, "byXpath", DNata_Pages_Objects.DNataPages.homepageitems.element_dnata_buttontravel).Click();
                   
             //       var resultsmenu = _driver.FindElements(By.XPath("//a[(@class='sc-c-menubar-link') and (@role='menuitem')]"));
             //       for (int groupIndex = 0; groupIndex < resultsmenu.Count; groupIndex++)
             //       {
             //           utilitieshightlight.highlightElement(_driver, resultsmenu[groupIndex], string.Empty, string.Empty);
             //       }

             //    ClassUtilitiesCommand.BrowserPageBack(_driver);

              // _driver.Navigate().GoToUrl(currentURL);
              // _driver.Navigate().Refresh();

                  _logger.Trace("Home Page : completed");

                });
                ExceptionHandler.HandleStaleException(action); 
            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }
    }
}
