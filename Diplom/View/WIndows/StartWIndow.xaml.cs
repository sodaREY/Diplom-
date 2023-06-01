﻿using Diplom.View.Pages;
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

namespace Diplom.View.WIndows
{
    /// <summary>
    /// Логика взаимодействия для StartWIndow.xaml
    /// </summary>
    public partial class StartWIndow : Window
    {
        
        ProfilePage profilePage = new ProfilePage();
        public StartWIndow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoursesPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(new ProfilePage());
            //MessageBox.Show("Выберите уровень");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoursesPage2());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoursesPage3());

        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
