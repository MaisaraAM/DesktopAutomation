using DesktopAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using System;
using WinAppDriver.Utilities;

namespace DesktopAutomation.Tests
{
    [TestFixture]
    public class RunCaculator : TestFixtureBase
    {
        [Test]
        public void runCalculator()
        {
            openApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

            CalculatorPage calculatorPage = new CalculatorPage(_session);
            calculatorPage.Calculate();
        }
    }
}
