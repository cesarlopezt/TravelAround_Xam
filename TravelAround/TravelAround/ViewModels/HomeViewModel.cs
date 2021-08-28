 using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using TravelAround.Models;

namespace TravelAround.ViewModels
{
    class HomeViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MenuOption BuyTicketsOption { get; set; }
        public MenuOption CheckTrendsOption { get; set; } = new MenuOption();
        public MenuOption FastFoodOption { get; set; } = new MenuOption();
        public MenuOption TipsOption { get; set; } = new MenuOption();
        public MenuOption JournalOption { get; set; } = new MenuOption();

        public HomeViewModel() 
        {
            BuyTicketsOption = new MenuOption() { Title = "Buy a Ticket", Image = "airplane" };
            CheckTrendsOption = new MenuOption() { Title = "Check trends", Image = "chart" };
            FastFoodOption = new MenuOption() { Title = "Fast Food", Image = "food" };
            TipsOption = new MenuOption() { Title = "Tips on Trips", Image = "information" };
            JournalOption = new MenuOption() { Title = "Journal", Image = "book" };
        }
    }
}
