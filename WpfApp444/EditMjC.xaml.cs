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
using MySql.Data.MySqlClient;

namespace WpfApp444
{
    /// <summary>
    /// Логика взаимодействия для EditMjC.xaml
    /// </summary>
    public partial class EditMjC : Window
    {
        public EditMjC()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=1234;" +
"database=bd;port=3306;persistsecurityinfo=True;sslmode=None");
            try
            {

                MySqlCommand cmd = new MySqlCommand("INSERT INTO тц (Название, Статус, КоличествоПовильонов, Город, Стоимость, КоофицентДобавочнойСтоимости, Этажность) VALUES ('" + NameTCBox.Text + "','" + StatusBox.Text + "','" + ColPowBox.Text + "','" + CityBox.Text + "','" + StoiBox.Text + "','" + CoofBox.Text + "','" + FloorBox.Text + "');", conn);

                conn.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                this.Hide();
                MjC mjc = new MjC();
                mjc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
