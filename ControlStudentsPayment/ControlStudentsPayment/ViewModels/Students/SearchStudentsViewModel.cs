using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ControlStudentsPayment.Models;
using ControlStudentsPayment.Views.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStudentsPayment.ViewModels.Students
{
    public partial class SearchStudentsViewModel : ObservableObject
    {

        [RelayCommand]
        private async Task AddStudentAsync()
        {
            await Shell.Current.GoToAsync(nameof(AddStudentsView));
        }

    }
}
