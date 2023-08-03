using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ControlStudentsPayment.Helpers
{
    public static class AlertsHalper
    {

        public static async Task ShowSuccessSnackBar(string msg)
        {
            await ShowBaseSnackBar(msg, Colors.Green);
        }

        public static async Task ShowErrorSnackBar(string msg)
        {
            await ShowBaseSnackBar(msg, Colors.Red);
        }

        private async static Task ShowBaseSnackBar(string msg, Color color)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = color,
                TextColor = Colors.White,
                Font = Microsoft.Maui.Font.SystemFontOfWeight(FontWeight.Bold),
                ActionButtonFont = Microsoft.Maui.Font.SystemFontOfWeight(FontWeight.Bold),
                ActionButtonTextColor = Colors.White,
                CornerRadius = new CornerRadius(10),
            };

            string actionButtonText = "Dismiss";
            TimeSpan duration = TimeSpan.FromSeconds(5);

            var snackbar = Snackbar.Make(msg, null, actionButtonText, duration, snackbarOptions);

            await snackbar.Show(cancellationTokenSource.Token);
        }

    }
}
