using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.MAUI.ViewModels {
    public class LoginViewModel : BaseViewModel {
        string userName;
        string password = string.Empty;
        string errorText;
        bool hasError;
        bool isAuthInProcess;

        public LoginViewModel() {
            LoginCommand = new Command(OnLoginClicked);
            SignUpCommand = new Command(OnSignUpClicked);
            PropertyChanged +=
                (_, __) => LoginCommand.ChangeCanExecute();

        }

        public string UserName {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        public string Password {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string ErrorText {
            get => errorText;
            set => SetProperty(ref errorText, value);
        }

        public bool HasError {
            get => hasError;
            set => SetProperty(ref hasError, value);
        }

        public bool IsAuthInProcess {
            get => isAuthInProcess;
            set {
                SetProperty(ref isAuthInProcess, value);
                OnPropertyChanged(nameof(AllowNewAuthRequests));
            }
        }
        public bool AllowNewAuthRequests {
            get { return !IsAuthInProcess; }
        }

        public Command LoginCommand { get; }
        public Command SignUpCommand { get; }

        async void OnLoginClicked() {
            IsAuthInProcess = true;
            await Task.Delay(1000);
            IsAuthInProcess = false;
            if (UserName == "User" && Password == "123") {
                await Shell.Current.GoToAsync("///Blogs");
                HasError = false;
            }
            else {
                ErrorText = "Incorrect username or password";
                HasError = true;
            }

        }
        async void OnSignUpClicked() {
            await Application.Current.MainPage.DisplayAlert("Sign in", "We will demonstrate this functionality in another example", "OK");
        }
    }
}
