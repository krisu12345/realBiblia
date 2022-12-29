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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();///chowa aktualne okno
            Window1 x = new Window1();/// tworzę funkcje x odwołującą się do następnego okna
            x.ShowDialog();/// pokazuje nowe okno
            this.Close();/// zamykam poprzednie oknko, które zostało schowane
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();///chowa aktualne okno
            Window2 x = new Window2();/// tworzę funkcje x odwołującą się do następnego okna
            x.ShowDialog();/// pokazuje nowe okno
            this.Close();/// zamykam poprzednie oknko, które zostało schowane
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();///chowa aktualne okno
            Window3 x = new Window3();/// tworzę funkcje x odwołującą się do następnego okna
            x.ShowDialog();/// pokazuje nowe okno
            this.Close();/// zamykam poprzednie oknko, które zostało schowane
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();///chowa aktualne okno
            Window4 x = new Window4();/// tworzę funkcje x odwołującą się do następnego okna
            x.ShowDialog();/// pokazuje nowe okno
            this.Close();/// zamykam poprzednie oknko, które zostało schowane
        }
    }
}
