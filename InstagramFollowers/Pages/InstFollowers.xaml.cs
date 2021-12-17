using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using InstagramFollowers.db;
using InstagramFollowers.Pages;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using InstLibrary;


namespace InstagramFollowers.Pages
{
    /// <summary>
    /// Логика взаимодействия для InstFollowers.xaml
    /// </summary>
    public partial class InstFollowers : Window
    {
        public static InstFollowersEntities dbEntities = new InstFollowersEntities();
        public InstFollowers()
        {
            InitializeComponent();
            dbEntities = new InstFollowersEntities();
            foreach(var follower in InstFollowers.dbEntities.Follower)
            {
                if(MainWindow.authUser.ID_User == 1)
                {
                    Sub.ItemsSource = dbEntities.Follower.Where(x => x.ID_Role == 1 && x.ID_User == 1).ToList();
                    Unsub.ItemsSource = dbEntities.Follower.Where(x => x.ID_Role == 2 && x.ID_User == 1).ToList();
                }
                else if(MainWindow.authUser.ID_User == 5)
                {
                    Sub.ItemsSource = dbEntities.Follower.Where(x => x.ID_Role == 1 && x.ID_User == 5).ToList();
                    Unsub.ItemsSource = dbEntities.Follower.Where(x => x.ID_Role == 2 && x.ID_User == 5).ToList();
                }
            }
        }

        private void OpenHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private async void View_APi_Click(object sender, RoutedEventArgs e)
        {
            var clientID = "Myclient";
            var clientSecret = "Mysecret";

            InstLibrary.InstApi api = new InstLibrary.InstApi(clientID, clientSecret);
            var location = new InstLibrary.Endpoints.Locations(api);

            var result = await location.Search(45.759723, 4.842223);
            foreach (InstLibrary.Models.Location l in result.Data)
            {
                MessageBox.Show(l.Name);
            }
        }
    }
}
