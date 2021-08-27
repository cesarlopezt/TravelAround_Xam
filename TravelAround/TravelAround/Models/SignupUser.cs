using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAround.Models
{
    class SignupUser
    {
        public string Name { get; set; }
        public string NativeCountry { get; set; }
        public string FavoriteCountry { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public string ConfirmPassword { get; set; } 
    }
}
