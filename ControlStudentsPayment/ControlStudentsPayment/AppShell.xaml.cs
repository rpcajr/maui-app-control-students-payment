using ControlStudentsPayment.Views.Students;

namespace ControlStudentsPayment;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AddStudentsView), typeof(AddStudentsView));
	}
}
