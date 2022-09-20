using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlaUI
{
    public class FlaUITest
    {
        public static void Test1()
        {
            var application = Application.Launch(@"C:\Data\Visual Studio Workspace\KLAPreparation\TestedProject\bin\Debug\net5.0-windows\TestedProject.exe");
            var automation = new UIA3Automation();
            var mainWindow = application.GetMainWindow(automation);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByAutomationId("firstNameTextBox")).AsTextBox().Enter("Snwnw");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("lastNameTextBox")).AsTextBox().Enter("Soso");
            mainWindow.FindFirstDescendant(cf.ByName("Save")).AsButton().Click();
            
        }

        public static void Test2()
        {
            Application.Launch(@"C:\Data\Visual Studio Workspace\KLAPreparation\TestedProject\bin\Debug\net5.0-windows\TestedProject.exe", "5000");
        }

        public static void Test3()
        {
            Random rnd = new Random();
            string parameter = rnd.Next(2000, 10000).ToString();
            Application.Launch(@"C:\Data\Visual Studio Workspace\KLAPreparation\TestedProject\bin\Debug\net5.0-windows\TestedProject.exe", parameter);
        }

        public static void Test4()
        {
            var application = Application.Launch(@"C:\Data\Visual Studio Workspace\KLAPreparation\TestedProject\bin\Debug\net5.0-windows\TestedProject.exe");
            var automation = new UIA3Automation();
            var mainWindow = application.GetMainWindow(automation);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByName("Create And Remove")).AsButton().Click();
            var tabpage = mainWindow.FindFirstDescendant(cf.ByName("tabPage1").And(cf.ByControlType(Core.Definitions.ControlType.Pane)));
            var element = tabpage.FindFirst(FlaUI.Core.Definitions.TreeScope.Children,
                new PropertyCondition(automation.PropertyLibrary.Element.ControlType, FlaUI.Core.Definitions.ControlType.Edit));
            element.AsTextBox().Enter("asd");

        }

        public static void Test5()
        {
            var application = Application.Launch(@"C:\Data\Visual Studio Workspace\KLAPreparation\TestedProject\bin\Debug\net5.0-windows\TestedProject.exe");
            var automation = new UIA3Automation();
            var mainWindow = application.GetMainWindow(automation);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByName("Create And Remove All Time")).AsButton().Click();
            var tabpage = mainWindow.FindFirstDescendant(cf.ByName("tabPage1").And(cf.ByControlType(Core.Definitions.ControlType.Pane)));
            var timer = new Timer(TimerMethod, null, 0, 50);
            
            void TimerMethod(object o)
            {
                var element = tabpage.FindFirst(FlaUI.Core.Definitions.TreeScope.Children,
                    new PropertyCondition(automation.PropertyLibrary.Element.ControlType, FlaUI.Core.Definitions.ControlType.Edit));
                if (element != null)
                    element.AsTextBox().Enter("add " + element.AsTextBox().Text);
            }
        }

       
    }
}
