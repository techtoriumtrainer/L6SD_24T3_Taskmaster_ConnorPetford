using Microsoft.Maui.Controls;

namespace planitfinal;

public partial class PrivacyPolicy : ContentPage
{
    public PrivacyPolicy()
    {
        InitializeComponent();
    }

    private async void OnAcceptButtonClicked(object sender, EventArgs e)
    {
        // Assuming PrivacyPolicyCheckBox and ErrorLabel are defined in XAML and linked properly
        if (PrivacyPolicyCheckBox.IsChecked == false)
        {
            // Show the error label
            ErrorLabel.IsVisible = true;
        }
        else
        {
            // Close the Privacy Policy page
            await Navigation.PopAsync();
        }
    }
}
