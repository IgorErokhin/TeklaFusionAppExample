using Fusion;
using System;
using Tekla.Structures;

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
    [LocalizedResources("Locales/ru-RU.xaml", Culture ="ru-RU")]
    public class ExampleApp : App
    {
        [STAThread]
        public static void Main()
        {
            string lang = string.Empty;
            string culture = "en-US";
            if (TeklaStructuresSettings.GetAdvancedOption("XS_LANGUAGE", ref lang))
            {
                switch (lang)
                {
                    case "ENGLISH":
                        culture = "en-US";
                        break;
                    case "RUSSIAN":
                        culture = "ru-RU";
                        break;
                    default:
                        culture = "en-US";
                        break;
                }
            }

            Start(new ExampleApp(), new SettingsOverrides() { Culture = culture });
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
