using ControlStudentsPayment.ViewModels;

namespace ControlStudentsPayment.Views;

public partial class CashView : ContentPage
{
    public CashView(CashViewModel cashViewModel)
	{
		InitializeComponent();
        BindingContext = cashViewModel;
    }
}