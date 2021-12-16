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
using InstagramFollowers.db;
using InstagramFollowers.Pages;

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
            Unsub.ItemsSource = dbEntities.Unsubscribed.ToList();
            Sub.ItemsSource = dbEntities.Subscribed.ToList();
        }

        private void OpenHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
