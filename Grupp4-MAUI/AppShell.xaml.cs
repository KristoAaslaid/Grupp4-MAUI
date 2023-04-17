namespace Grupp4_MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Uuslehekulg), typeof(Uuslehekulg));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
    }
}
