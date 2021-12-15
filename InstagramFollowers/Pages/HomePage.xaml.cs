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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public static InstFollowersEntities dbEntities = new InstFollowersEntities();
        public HomePage()
        {
            InitializeComponent();
            dbEntities = new InstFollowersEntities();

            Follower.ItemsSource = dbEntities.C_User.ToList();
            Follower1.ItemsSource = dbEntities.C_User.ToList();
        }
    }
}
