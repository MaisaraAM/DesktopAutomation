using DesktopAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAutomation.Tests
{
    [TestFixture]
    public class RunNotepad : TestFixtureBase
    {
        [Test]
        public void runNotepad()
        {
            openApp("C:\\Windows\\notepad.exe");

            NotepadPage notepadPage = new NotepadPage(_session);
            notepadPage.writeText("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin tortor purus platea sit eu id nisi litora libero. Neque vulputate consequat ac amet augue blandit maximus aliquet congue. Pharetra vestibulum posuere ornare faucibus fusce dictumst orci aenean eu facilisis ut volutpat commodo senectus purus himenaeos fames primis convallis nisi.", "PlaceHolder Text");
        }
    }
}
