using planitfinal.ViewModel;

namespace planitfinal.View;

public partial class SprintDetailsView : ContentPage
{
	public SprintDetailsView(SprintDetailsViewModel sprintDetailsViewModel)
	{
		InitializeComponent();
        BindingContext = sprintDetailsViewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as SprintDetailsViewModel).Refresh();
    }
}