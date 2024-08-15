using System.Windows.Input;

namespace planitfinal.ViewModel;

[INotifyPropertyChanged]
public partial class MainPageViewModel :BaseViewModel
{

    public MainPageViewModel()
    {
    
    }

    [RelayCommand]
    async void GotoTodoView()
    {
        if (IsBusy) return;
        IsBusy = true;
        await Shell.Current.GoToAsync("MainToTodoView");
        IsBusy = false;
    }

    public ICommand NavigateToPrivacyPolicyCommand => new Command(async () =>
    {
        await Application.Current.MainPage.Navigation.PushAsync(new PrivacyPolicy());
    });

    private bool isPrivacyPolicyAccepted;
    public bool IsPrivacyPolicyAccepted
    {
        get => isPrivacyPolicyAccepted;
        set => SetProperty(ref isPrivacyPolicyAccepted, value);
    }
}
