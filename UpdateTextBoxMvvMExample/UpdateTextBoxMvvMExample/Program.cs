﻿using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using UpdateTextBoxMvvMExample.ViewModels;
using UpdateTextBoxMvvMExample.Views;

namespace UpdateTextBoxMvvMExample
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
