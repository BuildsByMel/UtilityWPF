// Launches the Utilities
using Autodesk.AutoCAD.ApplicationServices.Core;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Windows.Media;

[assembly: CommandClass(typeof(UtilityWPF.CadCommands))]

namespace UtilityWPF
{
    public class CadCommands
    {
        [CommandMethod("RUNATTRCHECK")] //AutoCAD, when the user types RUNATTRCHECK, open my WPF utility.
        public void OpenUtilityWindow()
        {
            try
            {
                MainWindow view = new MainWindow();
                view.DataContext = new MainViewModel();

                // 2. FIXED: Use ShowModalWindow instead of ShowModalDialog for WPF!
                Autodesk.AutoCAD.ApplicationServices.Application.ShowModalWindow(view);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error launching window: {ex.Message}");
            }
        }
    }
}