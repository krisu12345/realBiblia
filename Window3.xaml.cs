using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            this.Hide();                    ///chowa aktualne okno
            MainWindow x = new MainWindow();/// tworzę funkcje x odwołującą się donastępnego okna
            x.ShowDialog();                 /// pokazuje nowe okno
            this.Close();                   /// zamykam poprzednie oknko, które zostało schowane
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string myConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\48510\\Source\\Repos\\krisu12345\\realBiblia\\Database1.mdf;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(myConnection);/// przypisywanie sciezki do bazy do zmiennej, tworzenie adaptera który pozwala nam sie laczyc
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();///tworzenie adaptera aby moglo to funkcjonwoac z baza
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", myConn);///zapytanie do bazy danych
            cmd.Connection = myConn;

            var reader = cmd.ExecuteReader();///czytanie z bazy danych

             wypisz.Text = "";///zmiena aby dodawac tutaj tezxt aby wypisac dane z bazy ktore chemy wyszukac

            while (reader.Read())///czytamy dane petla 
            {
                string line = $"{reader["Tytul"]} {reader["Autor"]}{reader["Id"]}";
                if (
                    reader["Tytul"].ToString().Contains(tytul1.Text) &&///branie danych z tytulu i zamienienie na stringa 
                    reader["Autor"].ToString().Contains(autor1.Text))///branie danych z autora i zamiana na stringa
                    wypisz.AppendText(line + "\r\n");///dodanie do wyzej zmiennej texty aby wypisac dane
             }
        myConn.Close();///zamkniece polaczenia
        }
    }
}
