using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Twitter2.Models;

namespace Twitter2.Services
{
    interface ITwitterService
    {
         Boolean authenticate(string utilisateur, string password);

         ObservableCollection<Tweet> GetTweets();
    }
}
