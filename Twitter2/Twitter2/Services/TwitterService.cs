using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Twitter2.Models;
using Xamarin.Essentials;

namespace Twitter2.Services
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string utilisateur, string password)
        {
           
            if (utilisateur.Equals("nakim") && password.Equals("nakim"))
            {
                return true;
            }
            return false;
        }

        public  ObservableCollection<Tweet> GetTweets()
        {
            User user = new User() { Login = "test", Password = "password" };


            return new ObservableCollection<Tweet>()
                {
                    new Tweet(){User = user, Texte ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", DateCreation = DateTime.Now},
                    new Tweet(){User = user, Texte ="Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar, lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae", DateCreation = DateTime.Now},
                    new Tweet(){User = user, Texte ="maximus arcu lectus at lectus", DateCreation = DateTime.Now},
                    new Tweet(){User = user, Texte ="Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce ipsum nisl, accumsan ac diam sed, scelerisque tempus sapien.", DateCreation = DateTime.Now},
                    new Tweet(){User = user, Texte ="Praesent eu", DateCreation = DateTime.Now}
                };
        }
 
        
    }
}
