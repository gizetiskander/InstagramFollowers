﻿using System;
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

namespace InstagramFollowers.Pages
{
    /// <summary>
    /// Логика взаимодействия для InstFollowers.xaml
    /// </summary>
    public partial class InstFollowers : Window
    {
        public InstFollowers()
        {
            InitializeComponent();
        }

        private void OpenHome_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            this.Close();
            home.Show();
        }
    }
}