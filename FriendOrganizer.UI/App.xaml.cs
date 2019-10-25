using Autofac;
using FriendOrganizer.UI.Startup;
using System.Windows;
using System.Windows.Threading;

namespace FriendOrganizer.UI
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DependencyInjector bootstrapper = new DependencyInjector();
            IContainer container = bootstrapper.Configure();

            MainWindow mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            string message = $"Unexpected error occured. Please inform the admin:\r\n {e.Exception.Message}";
            const string title = "Unexpected error";
            MessageBox.Show(message, title);

            e.Handled = true;
        }
    }
}
