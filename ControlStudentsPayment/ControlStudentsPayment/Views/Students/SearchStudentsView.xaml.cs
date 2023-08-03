using ControlStudentsPayment.ViewModels.Students;

namespace ControlStudentsPayment.Views;

public partial class SearchStudentsView : ContentPage
{
	public SearchStudentsView(SearchStudentsViewModel searchStudentsViewModel)
	{
		InitializeComponent();
		BindingContext = searchStudentsViewModel;
	}
}