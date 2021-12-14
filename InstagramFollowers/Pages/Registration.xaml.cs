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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
       
        public Registration()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "" || Login.Text == "")
            {
                MessageBox.Show("Введите ваши данные");
            }
            else
            {
                User user = new User();

                user.Login = Login.Text;
                user.Password = Password.Text;
                user.User_Name = UserName.Text;
                MainWindow.dbEntities.User.Add(user);
                try
                {
                    MainWindow.dbEntities.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Такой логин уже существует!");
                }
                finally
                {
                    MessageBox.Show("Вы зарегистрировались!");
                }
            }
        } 
    }
}
