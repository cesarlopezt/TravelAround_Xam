using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using TravelAround.Models;
using TravelAround.Views;

namespace TravelAround.ViewModels
{
    class SignUpViewModel
    {
        public SignupUser NewUser { get; set; } = new SignupUser();
        public Command RegisterCommand { get; }
        
        async public void OnRegister()
        {
            if (string.IsNullOrEmpty(NewUser.Name)
                || string.IsNullOrEmpty(NewUser.Username)
                || string.IsNullOrEmpty(NewUser.Password)
                || string.IsNullOrEmpty(NewUser.ConfirmPassword)
                || string.IsNullOrEmpty(NewUser.NativeCountry)
                || string.IsNullOrEmpty(NewUser.FavoriteCountry)
                )
            {
                await App.Current.MainPage.DisplayAlert("Error", "You have empty fields!", "Ok");
            }
            else
            {
                if(NewUser.Password == NewUser.ConfirmPassword)
                {
                    await App.Current.MainPage.DisplayAlert("Welcome to Travel Around", $"Hi {NewUser.Name}!", "Ok");
                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Passwords do not match!", "Ok");
                }
            }
        }

        public SignUpViewModel()
        {
            RegisterCommand = new Command(OnRegister);
        }
    }
}
