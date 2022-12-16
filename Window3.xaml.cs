using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();///chowa aktualne okno
            MainWindow x = new MainWindow();/// tworzę funkcje x odwołującą się donastępnego okna
            x.ShowDialog();/// pokazuje nowe okno
            this.Close();/// zamykam poprzednie oknko, które zostało schowane
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*string myConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\student\source\repos\LibraryProject\LibraryProject\Biblioteka.mdf; Integrated Security = True";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(myConnection);
            cmd.Connection = myConn;
            cmd.CommandText = "INSERT INTO [books](Tytul, Autor, Gatunek) values ('" + tytul.Text + "','" + autor.Text + "','" + gatunek.Text + "')";
            cmd.ExecuteNonQuery();

            myConn.Close();*/
        }
    }
}
