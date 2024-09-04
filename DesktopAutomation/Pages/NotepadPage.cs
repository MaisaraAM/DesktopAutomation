using OpenQA.Selenium;
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
    public class NotepadPage : TestFixtureBase
    {
        WindowsUIActions windowsUIActions;
        driverActions driverActions;
        Waits waits;

        WindowsUIElement textField = new WindowsUIElement(By.ClassName, "RichEditD2DPT");
        WindowsUIElement openFileMenu = new WindowsUIElement(By.AccessibilityId, "File");
        WindowsUIElement saveFile = new WindowsUIElement(By.Name, "Save");
        WindowsUIElement addressBar = new WindowsUIElement(By.AccessibilityId, "1001");
        WindowsUIElement fileName = new WindowsUIElement(By.AccessibilityId, "1001");
        WindowsUIElement saveButton = new WindowsUIElement(By.AccessibilityId, "1");

        public NotepadPage(WindowsDriver<WindowsElement> session)
        {
            windowsUIActions = new WindowsUIActions(session);
            driverActions = new driverActions(session);
            waits = new Waits(session);
        }

        public void writeText(string text, string fileN)
        {
            waits.WaitTillToUIElementPresent(textField);

            windowsUIActions.moveToElementAndClickAndSendText(textField, text);
            //IWebElement editBox = _session.FindElementByClassName("RichEditD2DPT");
            //editBox.Click();
            //editBox.SendKeys(text);

            windowsUIActions.moveToElementAndClickMenus(openFileMenu);
            windowsUIActions.moveToElementAndClick(saveFile);
            //windowsUIActions.moveToElementAndClick(addressBar);
            //windowsUIActions.setText(addressBar, "C:\\Users\\t-mamaher\\Desktop");
            //windowsUIActions.moveToElementAndDoubleClick(fileName);

            waits.WaitTillToUIElementPresent(fileName);

            windowsUIActions.setText(fileName, fileN);
            windowsUIActions.moveToElementAndClick(saveButton);
        }
    }
}
