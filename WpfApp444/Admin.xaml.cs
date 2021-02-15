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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        class Staff
        {
            public string surname { get; set; }
            public string name { get; set; }
            public string middle_name { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public string role { get; set; }
            public string number_of_phone { get; set; }
        }
        public Admin()
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=1234;" +
          "database=bd;port=3306;persistsecurityinfo=True;sslmode=None");
            InitializeComponent();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Фамилия, Имя, Отчество, Логин, Пароль, Роль, НомерТелефона FROM сотрудники", conn);

                conn.Open();

                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    dataGrid1.Items.Add(new Staff { surname = read[0].ToString(), name = read[1].ToString(), middle_name = read[2].ToString(), login = read[3].ToString(), password = read[4].ToString(), role = read[5].ToString(), number_of_phone = read[6].ToString()});
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

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Eddit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
