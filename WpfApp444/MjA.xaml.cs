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
    /// Логика взаимодействия для MjA.xaml
    /// </summary>
    public partial class MjA : Window
    {
        class rend
        {
            public string noc { get; set; }
            public string nf { get; set; }
            public string adr { get; set; }
        }
        public MjA()
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=1234;" +
          "database=bd;port=3306;persistsecurityinfo=True;sslmode=None");
            InitializeComponent();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Название, Номер, Адрес FROM арендаторы", conn);

                conn.Open();

                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    dataGridMjA.Items.Add(new rend { noc = read[0].ToString(), nf = read[1].ToString(), adr = read[2].ToString()});
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

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eddit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }
