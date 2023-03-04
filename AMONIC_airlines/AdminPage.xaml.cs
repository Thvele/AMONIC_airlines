using Microsoft.Data.SqlClient;
using System.Windows;

namespace AMONIC_airlines
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        SqlConnection connection = new SqlConnection((string)App.Current.Resources["connectionString"]);

        public AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow authorization = new MainWindow();
            authorization.Show();

            this.Close();
        }
    }
}
