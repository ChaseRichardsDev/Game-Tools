using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;

namespace DialogBuilder;
public class Bootstrapper : Bootstrapper<MainWindowViewModel>
{
    protected override void OnStart()
    {
        // This is called just after the application is started, but before the IoC container is set up.
        // Set up things like logging, etc
        base.OnStart();
    }

    protected override void ConfigureIoC(IStyletIoCBuilder builder)
    {
        // Bind your own types. Concrete types are automatically self-bound.
        base.ConfigureIoC(builder);
    }

    protected override void Configure()
    {
        // This is called after Stylet has created the IoC container, so this.Container exists, but before the
        // Root ViewModel is launched.
        // Configure your services, etc, in here
        base.Configure();
    }

    protected override void OnLaunch()
    {
        // This is called just after the root ViewModel has been launched
        // Something like a version check that displays a dialog might be launched from here
        base.OnLaunch();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        // Called on Application.Exit
        base.OnExit(e);
    }

    protected override void OnUnhandledException(DispatcherUnhandledExceptionEventArgs e)
    {
        // Called on Application.DispatcherUnhandledException
        base.OnUnhandledException(e);
    }
}
