using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter2.Services;
using Twitter2.View;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Twitter2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        TwitterService twitterService = new TwitterService();

        public MainPage()
        {
            InitializeComponent();
            //this.tweet.IsVisible = false;
            
        }

        public void Connection_Clicked(Object sender, EventArgs e)
        {
            Console.WriteLine(" Vous avez cliqué sur le bouton se connecter");
            string identifiant = this.identifiant.Text;
            string password = this.password.Text;
            Boolean souvenir = this.souvenir.IsToggled;

            this.error.IsVisible = false;

            if (String.IsNullOrEmpty(identifiant) || identifiant.Length < 4) {
                this.error.Text = "Veuillez entrer un identifiant valide";
                this.error.IsVisible = true;
                return;
            }


            if (String.IsNullOrEmpty(password) || password.Length < 4)
            {
                this.error.Text = "Veuillez entrer un password valide";
                this.error.IsVisible = true;
                return;
            }

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {


                if (!twitterService.authenticate(identifiant, password))
                {
                    this.error.Text = "Vos identifiants ne sont pas valides";
                    this.error.IsVisible = true;
                    return;
                }
            }
            else {
                this.error.Text = "Vous n'êtes pas connecté à internet";
                this.error.IsVisible = true;
                return;
            }

            this.AfficherPageListeAsync();

        }

        public async void AfficherPageListeAsync() {
            await Navigation.PushAsync(new ListTweets());
        }
    }
}
