using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter2.Models;
using Twitter2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twitter2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTweets : ContentPage
    {
        TwitterService TwitterService = new TwitterService();
        ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
        public ListTweets()
        {
            InitializeComponent();

            this.listetweets.ItemsSource = TwitterService.GetTweets();
        }
    }
}