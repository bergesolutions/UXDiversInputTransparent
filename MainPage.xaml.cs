using UXDivers.Popups.Services;
using static System.Net.Mime.MediaTypeNames;

namespace UXDiversInputTransparent
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnToastClicked(object sender, EventArgs e)
        {
            var popup = new PopupToast();
            await IPopupService.Current.PushAsync(popup);
        }

        private async void OnToast2Clicked(object sender, EventArgs e)
        {
            var popup = new PopupToast2();
            await IPopupService.Current.PushAsync(popup);
        }
    }
}
