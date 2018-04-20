using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using DBManager.Ui.ViewModels;
using DBManager.Ui.Views;

namespace DBManager.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
