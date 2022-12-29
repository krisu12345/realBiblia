using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
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
            string myConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\48510\Source\Repos\krisu12345\realBiblia\Database1.mdf; Integrated Security = True";
            var myConn = new SqlConnection(myConnection);/// przypisywanie sciezki do bazy do zmiennej, tworzenie adaptera który pozwala nam sie laczyc
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();/// otwieranie polaczenia z baza danych
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(myConnection);///laczenie sie z baza danych
            cmd.Connection = myConn;
            cmd.CommandText = "INSERT INTO [Table](Tytul, Autor) values ('" + tytul1.Text + "','" + autor1.Text + "')";///zapytanie do bazy
            cmd.ExecuteNonQuery();///wykonywanei zapytania

            myConn.Close();///zamykaneie polaczenia z baza
        }
    }
}
