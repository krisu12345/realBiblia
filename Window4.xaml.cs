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
    /// Logika interakcji dla klasy Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\48510\Source\Repos\realBiblia\Database1.mdf; Integrated Security = True";
            SqlConnection myConn = new SqlConnection(myConnection); /// przypisywanie sciezki do bazy do zmiennej, tworzenie adaptera który pozwala nam sie laczyc
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();/// otwieranie polaczenia z baza danych
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(myConnection);///laczenie z baza danych
            cmd.Connection = myConn;
            try///probujemy wykonac dany kod lecz gdy pierwszy warunek się nie spelni wykona się catch
            {
                cmd.CommandText = "UPDATE [Table] SET Wypo = 'True' WHERE Tytul ='" + tytul1.Text + "' AND Autor = '" + autor1.Text + "'";///zapyanie do bazy danych suuwajace ksiazke
                cmd.ExecuteNonQuery();///egzekucja zapytania
            }
            catch (Exception er)
            {
                MessageBox.Show("Nie udało się");///jezeli nie wykona sie
            }
            myConn.Close();///zamykanie polaczenia z baza
    }
    }
}
