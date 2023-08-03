using ControlStudentsPayment.ViewModels.Students;

namespace ControlStudentsPayment.Views.Students;

public partial class AddStudentsView : ContentPage
{
	public AddStudentsView(AddStudentsViewModel addStudentsViewModel)
	{
		InitializeComponent();
		BindingContext = addStudentsViewModel;
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        (sender as Entry).CursorPosition = (sender as Entry).Text.Length;
    }
}