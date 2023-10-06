using Foundation;

namespace ScanbotSDKMVVM;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => CreateMauiApplication();

    private MauiApp CreateMauiApplication()
    {
        BarcodeSDK.MAUI.iOS.Services.DependencyManager.Register();
        return MauiProgram.CreateMauiApp();
    }
}