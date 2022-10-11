﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using System;

namespace DNata.TestData
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 10;

        public static string BaseURL_DNata = "http://www.DNata.com";    
        public static string BaseURL = BaseURL_DNata;

        public static string ChromeDriverDirectory = @"C:\Users\icamm\.nuget\packages\selenium.webdriver.chromedriver\105.0.5195.5200\driver\win32";
        public static string ChromeDirectory = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        // public static string ChromeDriverDirectory = @"C:\Users\ian.campbell\.nuget\packages\selenium.webdriver.chromedriver\87.0.4280.8800\driver\win32";

        public static string FirefoxDriverDirectory = @"C:\Users\icamm\.nuget\packages\selenium.firefox.webdriver\0.26.0\driver";

        public static string TestUser = String.Empty;
        public static string TestUserPassword   = String.Empty;

        static Random r = new Random();

        public static string GenerateRandomId()
        {
            string x = "ID" + r.Next(9999, 99999999).ToString();
            return x;

        }

        //scroll values
        public static class ScrollDetails
        {
            public static string ScrollToObject = "100";
            public static string ScrollDownToElement = "100";
            public static string ScrollUpToElement = "100";
            public static readonly TimeSpan timeout = new TimeSpan(0, 10, 0);

            public static int ScrollModulus = 10;
            public static int Scrollslow = 100;
            public static int Scrollmedium = 50;
        }

        //credentials
        public static class Credentials
        {

            public static string TestUseremail = string.Empty;
            public static string TestUsername = string.Empty;
            public static string TestUserpassword = string.Empty;

            public static string SimTestManager = "SimTestWflMgr @example.com";

        }

        public static class EnvironmentVARIABLE
        {
            public static string PrimeKEY = "IASCLIENTAPP_";
        }

            //Link a prospect to an existing client

        public static class ProcessNames
        {
            public static string processnameChromeDriver = "chromedriver";
            public static string processnameGoogleChrome = "chrome";
        }
    }
}
