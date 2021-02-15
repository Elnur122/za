using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WpfApp444
{
    public partial class MainWindow : Window
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=1234;" +
           "database=bd;port=3306;persistsecurityinfo=True;sslmode=None");
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] Roli = { "Менеджер А", "Менеджер С", "Администратор" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT Логин, Пароль, Роль FROM сотрудники", conn);
                conn.Open();
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    if (log.Text == read[0].ToString() && pas.Password == read[1].ToString())
                    {
                        if (Roli[2] == read[2].ToString())
                        {
                            this.Hide();
                            Admin admin = new Admin();
                            admin.Show();
                        }
                        if (Roli[0] == read[2].ToString())
                        {
                            this.Hide();
                            MjA mja = new MjA();
                            mja.Show();
                        }
                        if (Roli[1] == read[2].ToString())
                        {
                            this.Hide();
                            MjC mjc = new MjC();
                            mjc.Show();
                        }    
                    }
                    else
                    {
                        NlNp.Content = "Неверное имя пользователя или пароль";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\nПодрабнее:\n" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
