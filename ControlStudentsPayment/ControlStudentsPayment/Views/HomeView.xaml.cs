using ControlStudentsPayment.ViewModels;

namespace ControlStudentsPayment.Views;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		BindingContext = homeViewModel;
	}
}