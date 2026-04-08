using UXDivers.Popups.Services;

namespace UXDiversInputTransparent;

public partial class PopupToast2
{
	public PopupToast2()
	{
		InitializeComponent();
	}

    private async Task CloseThePopup()
    {
        try
        {
            if (IPopupService.Current.NavigationStack.Contains(this))
            {
                await IPopupService.Current.PopAsync(this);
            }
        }
        catch (Exception ex)
        {
        }
    }

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await CloseThePopup();
    }
}