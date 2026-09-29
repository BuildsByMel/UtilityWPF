using System.Windows;

namespace UtilityWPF.TestApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var window = new UtilityWPF.MainWindow();

            window.Show();
        }
    }
}