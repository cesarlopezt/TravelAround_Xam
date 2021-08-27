using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using TravelAround.Models;
using TravelAround.Views;

namespace TravelAround.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LoginUser User { get; set; } = new LoginUser();
        public Command LoginCommand { get; }
        public Command MoveToSignupCommand { get; }
        
        public async void OnLogin()
        {
            if (string.IsNullOrEmpty(User.Username))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Username shouldn't be empty!", "Ok");
            }
            else if (string.IsNullOrEmpty(User.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Password shouldn't be empty", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome back", $"Hi {User.Username}!", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
        }

        public async void OnMoveToSignup()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignupPage());
        }


        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            MoveToSignupCommand = new Command(OnMoveToSignup);
        }
    }
}
