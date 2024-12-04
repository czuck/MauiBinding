using Microsoft.Maui.Handlers;
#if __IOS__
using UIKit;
#endif

namespace MauiTestApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }

    public static void SetUnmodified(IEntryHandler handler, IEntry view)
    {

#if __IOS__
        handler.PlatformView.AutocapitalizationType = UITextAutocapitalizationType.None;
#endif
    }
}