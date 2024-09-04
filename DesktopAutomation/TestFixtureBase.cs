using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using WinAppDriver.Utilities;

namespace DesktopAutomation
{
    public class TestFixtureBase
    {
        public static WindowsDriver<WindowsElement> _session;
        driverActions driverActions;
        DriverFactory driverFactory = new DriverFactory();
        Waits waits;

        public string WinDriver_Path = ConfigurationManager.AppSettings["WinDriver_Path"];
        //public string appPath;
              
        public void openApp(string path) 
        {
            _session = driverFactory.InitializeDriver("HC-TRAINEE29-NB", new Uri("http://127.0.0.1:" + "4723"), path);
        }

        [TearDown]
        public void closeProgram()
        {
            driverFactory.TestCleanup(_session);
        }
    }
}
