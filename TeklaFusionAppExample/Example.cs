using Fusion;
using System;

[assembly: App.Settings(
    Culture = "en-US",
    EnableExceptionHandling = false, // Enable on production
    EnableMessageLogging = true, // Disable on production
    EnableRecoveryAndRestart = false, // Enable on production
    EnableSingleInstanceMode = true,
    EnableWindowGhosting = true,
    FeatureFolder = "Features",
    LocalizationMode = LocalizationMode.Normal,
    Theme = "Cloud")]

namespace TeklaFusionAppExample
{
    [LocalizedResources("Locales/en-US.xaml")]
    [LocalizedResources("Locales/ru-RU.xaml")]
    public class ExampleApp : App
    {
        [STAThread]
        public static void Main()
        {
            Start(new ExampleApp());
        }

        [PublishedView("App.MainWindow")]
        public ViewModel CreateMainWindow(object parameter)
        {
            return new MainWindowViewModel();
        }

        [PublishedView("Example.Example")]
        public ViewModel Example(object parameter)
        {
            return new ExampleViewModel();
        }
    }
}
