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
using System.Windows.Navigation;
using System.Windows.Shapes;
using InstagramFollowers.db;
using InstagramFollowers.Pages;

namespace InstagramFollowers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static InstFollowersEntities dbEntities = new InstFollowersEntities();
        public static C_User authUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Close();
            registration.Show();
        }

        private void Sign_in_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            foreach (var user in MainWindow.dbEntities.C_User)
            {
                if(user.Login == Login.Text.Trim())
                {
                    if (user.Password == Password.Text.Trim())
                    {
                        MessageBox.Show($"Привет, Пользователь: {user.Login}");
                        MainWindow.authUser = user;
                        InstFollowers inst = new InstFollowers();
                        this.Close();
                        inst.Show();
                    }
                }
                if (user.Login != Login.Text.Trim())
                {
                    if(user.Password != Password.Text.Trim())
                    {
                        MessageBox.Show("Пользователь не найден!");
                    }
                }
            }
        }
    }
}
