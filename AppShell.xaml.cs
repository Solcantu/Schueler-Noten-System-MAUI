namespace Schueler_Noten_System_MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("addPage", typeof(addPage));
	}
}
