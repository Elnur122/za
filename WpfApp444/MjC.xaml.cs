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
    /// Логика взаимодействия для MjC.xaml
    /// </summary>
    public partial class MjC : Window
    {
        class Tc
        {
            public string NameTC { get; set; }
            public string Status { get; set; }
            public string CountPow { get; set; }
            public string CityName { get; set; }
            public string Stoi { get; set; }
            public string Coof { get; set; }
            public string Floors { get; set; }
        }
        public MjC()
        {

        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=1234;" +
         "database=bd;port=3306;persistsecurityinfo=True;sslmode=None");
            InitializeComponent();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Название, Статус, КоличествоПовильонов, Город, Стоимость, КоофицентДобавочнойСтоимости, Этажность FROM тц", conn);

                conn.Open();

                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    dataGridMjC.Items.Add(new Tc { NameTC = read[0].ToString(), Status = read[1].ToString(), CountPow = read[2].ToString(), CityName = read[3].ToString(), Stoi = read[4].ToString(), Coof = read[5].ToString(), Floors = read[6].ToString() });
                }
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

        private void DeleteA_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=1234;" +
"database=bd;port=3306;persistsecurityinfo=True;sslmode=None");
            try
            {

                MySqlCommand cmd = new MySqlCommand("DELETE FROM тц WHERE Название ='" + textBoxDeleteMjC.Text + "';", conn);

                conn.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                textBoxDeleteMjC.Text = "";
                
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

        private void AddA_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EditMjC editmjc = new EditMjC();
            editmjc.Show();
        }

        private void dataGridMjC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
