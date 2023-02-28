namespace MAUIExample;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTE5NDk4OUAzMjMwMmUzNDJlMzBBOXdpRFlrQThlenBkYjFON1N2cEFOSzhSeFVNb1k0ZUtsZ0RiWG1LRXFRPQ==");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
