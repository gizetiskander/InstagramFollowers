using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace InstagramFollowers.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public static InstFollowersEntities dbEntities = new InstFollowersEntities();
        public Registration()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "" || Login.Text == "" || About.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Введите ваши данные");
            }
            else
            {
                C_User user = new C_User();

                user.Login = Login.Text;
                user.Password = Password.Text;
                user.User_Name = UserName.Text;
                user.User_text = About.Text;
                OpenFileDialog ofdImage = new OpenFileDialog();
                ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
                ofdImage.FilterIndex = 1;
                if (ofdImage.ShowDialog() == true)
                {
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(ofdImage.FileName);
                    image.EndInit();
                    playim.Source = image;
                    user.User_Image = File.ReadAllBytes(ofdImage.FileName);
                }
                MainWindow.dbEntities.C_User.Add(user);
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
                    MainWindow mainWindow = new MainWindow();
                    this.Close();
                    mainWindow.Show();
                }
            }
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            ofdImage.FilterIndex = 1;
            if (ofdImage.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdImage.FileName);
                image.EndInit();
                C_User cu = new C_User();
                playim.Source = image;
                cu.User_Image = File.ReadAllBytes(ofdImage.FileName);
            }
        }
    }
}
