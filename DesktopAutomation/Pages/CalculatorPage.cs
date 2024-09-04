using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriver.Utilities;
using By = WinAppDriver.Utilities.ElementFactory.By;

namespace DesktopAutomation.Pages
{
    public class CalculatorPage : TestFixtureBase
    {
        WindowsUIActions windowsUIActions;
        driverActions driverActions;
        Waits waits;

        WindowsUIElement navigationPaneButton = new WindowsUIElement(By.AccessibilityId, "TogglePaneButton");
        WindowsUIElement scientificButton = new WindowsUIElement(By.AccessibilityId, "Scientific");
        WindowsUIElement num4Button = new WindowsUIElement(By.AccessibilityId, "num4Button");
        WindowsUIElement num5Button = new WindowsUIElement(By.AccessibilityId, "num5Button");
        WindowsUIElement trigButton = new WindowsUIElement(By.AccessibilityId, "trigButton");
        WindowsUIElement sineButton = new WindowsUIElement(By.AccessibilityId, "sinButton");
        WindowsUIElement squareButton = new WindowsUIElement(By.AccessibilityId, "xpower2Button");
        WindowsUIElement multiplyButton = new WindowsUIElement(By.AccessibilityId, "multiplyButton");
        WindowsUIElement num2Button = new WindowsUIElement(By.AccessibilityId, "num2Button");
        WindowsUIElement equalButton = new WindowsUIElement(By.AccessibilityId, "equalButton");

        public CalculatorPage(WindowsDriver<WindowsElement> session)
        {
            windowsUIActions = new WindowsUIActions(session);
            driverActions = new driverActions(session);
            waits = new Waits(session);
        }

        public void Calculate()
        {
            windowsUIActions.clickOnElement(navigationPaneButton);
            windowsUIActions.clickOnElement(scientificButton);
            windowsUIActions.clickOnElement(num4Button);
            windowsUIActions.clickOnElement(num5Button);
            windowsUIActions.clickOnElement(trigButton);
            windowsUIActions.clickOnElement(sineButton);
            windowsUIActions.clickOnElement(squareButton);
            windowsUIActions.clickOnElement(multiplyButton);
            windowsUIActions.clickOnElement(num2Button);
            windowsUIActions.clickOnElement(equalButton);
        }
    }
}
