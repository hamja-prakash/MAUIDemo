using MAUISampleDemo.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUISampleDemo.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private string _loginBtnName = "Login";
        public string LoginBtnName
        {
            get { return _loginBtnName; }
            set
            {
                _loginBtnName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LoginBtnName"));
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Email == "abc@gmail.com" && Password == "1234")
                {
                    App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                else
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}  

