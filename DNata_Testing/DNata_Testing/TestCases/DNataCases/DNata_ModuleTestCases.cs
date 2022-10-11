using System;
using System.Threading;

using NUnit.Framework;
using NLog;
using Logger = NLog.Logger;

using OpenQA.Selenium;

using KillSystemProcess = TestFramework.Extensions.KillSystemProcess;
using ProcessNames = Clientapp_Tester.TestData.ConfigAssessment.ProcessNames;
using DNata.TestScenarios;
using ClassGloballibrary;

using Microsoft.VisualStudio.Data;
using Microsoft.VisualStudio.Text.UI;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

using ClassUtilities;

// var fff = _driver.Manage().Window.Size.Height;
// DNataModuleTestScenarios.DNataCloseCookiesPopUpPanel(_driver);

namespace DNata.TestCases
{

    [TestFixture]
    [Parallelizable]

    public class DNataModuleTestCases
    {

        public const bool LoginWithOneLogin = false;
        public static IWebDriver _driver;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public class FLDR
        {

            public static string SCRIPTFLDR     = "SCRIPTFLDR";

            public static string SCRIPTFILENAME = "SCRIPTFILENAME";
            public static string SCRIPTRUNFILE  = "SCRIPTRUNFILE";

        }

      //  public NUnit.Framework.TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {

            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");

            string introformattedTime = DateTime.Now.ToString("yyyy-MM-dd");

            var disconformattedTime =  DateTime.Now.AddYears(1).ToString("yyyy-MM-dd");

            ClassGloballibrary.runTime.starttime = Convert.ToDateTime(System.DateTime.Now);

            _logger.Trace("-----Starting tests execution-----");

            KillSystemProcess.KillProcess(ProcessNames.ProcessNameChromeDriver, _driver);
            KillSystemProcess.KillProcess(ProcessNames.ProcessNameGoogleChrome, _driver);

            Displaymessagebox.defaultmsgtimer   = 1;
            Displaymessagebox.defaultlocationx  = 50;
            Displaymessagebox.defaultlocationy  = 50;

            ClassUtilities.ClassUtilitiesActions._baseURL = "http://www.DNata.com";
        //  ClassUtilities.ClassUtilitiesActions._baseURL = "https://www.dnata.com/en/travel-services";


            _driver = ClassUtilitiesActions.InitializeDriver();


          //  _driver = ActionClass.InitializeDriver();

            ClassUtilities.ClassUtilitiesCommon classUuilities = new ClassUtilities.ClassUtilitiesCommon();
            
            FLDR.SCRIPTFLDR     = DNata_Testing.Properties.Settings.Default.SCRIPTFOLDER;
            FLDR.SCRIPTFILENAME = DNata_Testing.Properties.Settings.Default.SCRIPTFILE;

            var scriptfilepath = DNata_Testing.Properties.Settings.Default.FOLDERDATASCRIPT + DNata_Testing.Properties.Settings.Default.FOLDERFILESCRIPT;
            FLDR.SCRIPTRUNFILE = FLDR.SCRIPTFLDR + FLDR.SCRIPTFILENAME;

            classUuilities.deletefile(FLDR.SCRIPTRUNFILE);
            classUuilities.copyfile(scriptfilepath, FLDR.SCRIPTRUNFILE);

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            //            if ( classcommon.processIsRunning ( Global.gloHARNESS.runprocess ) ) classcommon.processIsRunningkill ( Global.gloHARNESS.runprocess );
            //            if ( classcommon.processIsRunning ( Global.gloHARNESS.videoprocessname ) ) classcommon.processIsRunningkill ( Global.gloHARNESS.videoprocessname );
            //            if ( classcommon.processIsRunning ( "EXCEL" ) ) classcommon.processIsRunningkill ( "EXCEL" );

            //DNataModuleTestScenarios.DNataCookieAcceptpanel(_driver);

           // ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("-----DNata Test execution : " + formattedTime, System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
        }

        [TestCase, Order(0050)]
        public void DNata_0050_DisplayHomeLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
            DNataModuleTestScenarios.DNata_0050_HighlightHomeLinks(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }

        [TestCase, Order(0052)]
        public void DNata_0052_DisplayHomeLinks()
        {
            ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("Run Time  : execution " + ClassUtilities.ClassUtilitiesExtensions.RunTimeSpan(runTime.starttime), System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());
         //   DNataModuleTestScenarios.DNata_0052_HighlightHomePages(_driver);

            ClassUtilities.ClassUtilitiesExtensions.MessageBreak(_driver);
        }
        
        [OneTimeTearDown]
        public void CleanUp()
        {
            try
            {
                //_logger.Trace("-----Cleaning up after tests execution-----");
                // ClassUtilities.ClassUtilitiesExtensions.RefreshPage(_driver);

                _driver.Close();
                _driver.Quit();

                KillSystemProcess.KillProcess(ProcessNames.ProcessNameChromeDriver, _driver);

                _logger.Trace("-----Cleaning up after tests execution-----");
                ClassUtilities.ClassUtilitiesExtensions.DisplayDefaultTestMessage("-----MalinkoTech Test completed-----", System.Reflection.MethodBase.GetCurrentMethod().Name.Trim());

            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContextInstance;
        
    }
}