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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
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
            string myConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\student\source\repos\realBiblia\Database1.mdf; Integrated Security = True";
            SqlConnection myConn = new SqlConnection(myConnection); /// przypisywanie sciezki do bazy do zmiennej, tworzenie adaptera który pozwala nam sie laczyc
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();/// otwieranie polaczenia z baza danych
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(myConnection);///laczenie z baza danych
            cmd.Connection = myConn;
            try///probujemy wykonac dany kod lecz gdy pierwszy warunek się nie spelni wykona się catch
            {
                cmd.CommandText = "DELETE FROM [Table] WHERE Tytul = '" + tytul1.Text + "' AND Autor = '" + autor1.Text + "'";///zapyanie do bazy danych suuwajace ksiazke
                cmd.ExecuteNonQuery();///egzekucja zapytania
            }catch(Exception er)
            {
                MessageBox.Show("Nie ma");///jezeli nie wykona sie
            }
            myConn.Close();///zamykanie polaczenia z baza
        }
    }
}
