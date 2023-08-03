using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ControlStudentsPayment.Models;
using ControlStudentsPayment.Services;
using CommunityToolkit.Maui.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlStudentsPayment.Helpers;

namespace ControlStudentsPayment.ViewModels.Students
{
    public partial class AddStudentsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = String.Empty;

        [ObservableProperty]
        private string _cpf = String.Empty;

        [ObservableProperty]
        private int _dayExpiration = 0;

        [ObservableProperty]
        private string _value = String.Empty;

        [ObservableProperty]
        private List<int> _dayList = new();


        private readonly StudentService studentService;

        public AddStudentsViewModel(StudentService studentService)
        {
            PopulateDayList();
            this.studentService = studentService;
        }

        private void PopulateDayList()
        {
            for (int i = 1; i <= 31; i++)
            {
                DayList.Add(i);
            }
        }

        [RelayCommand]
        private async Task SaveAsync()
        {
            var valid = await ValidateStudentAsync();

            if (!valid) { return; }

            _ = double.TryParse(Value, out var value);

            Student student = new()
            {
                Name = Name,
                Cpf = Cpf,
                DayExpiration = DayExpiration,
                Value = value
            };

            await studentService.AddItemAsync(student);

            await AlertsHalper.ShowSuccessSnackBar("A student was created!");

            await CancelAsync();
        }

        [RelayCommand]
        private async Task CancelAsync()
        {
            await Shell.Current.GoToAsync("..");
        }

        private async Task<bool> ValidateStudentAsync()
        {
            if (Name == String.Empty) { await AlertsHalper.ShowErrorSnackBar("Inform the NAME!"); return false; }
            if (Cpf == String.Empty) { await AlertsHalper.ShowErrorSnackBar("Inform the CPF!"); return false; }
            if (Value == String.Empty || Value == ".") { await AlertsHalper.ShowErrorSnackBar("Inform the VALUE!"); return false; }
            if (DayExpiration == 0) { await AlertsHalper.ShowErrorSnackBar("Inform the DAY EXPIRATION!"); return false; }

            return true;
        }

    }
}
