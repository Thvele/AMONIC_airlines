using AMONIC_airlines.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AMONIC_airlines
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        String initialCMD = "select Users.ID as 'ID', Users.FirstName as 'Name', Users.LastName as 'LastName', (DATEDIFF(YEAR, CONVERT(DATE, Users.Birthdate),CONVERT(DATE, GETDATE()))) as 'Age', Roles.Title as 'Role', Users.Email as 'EmailAddress', Offices.Title as 'Office', Users.Active from Users inner join Roles on Users.RoleID = Roles.ID inner join Offices on Users.OfficeID = Offices.ID";
        String connection = "Data Source=DESKTOP-CDAE4UR;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial catalog=Session1_XX;";
        DataSet usersDS = new DataSet();

        public AdminPage()
        {
            InitializeComponent();
            
            using(SqlConnection  con = new SqlConnection(connection)) 
            {
                con.Open();
                SqlDataAdapter adapter =  new SqlDataAdapter(initialCMD, connection);
                adapter.Fill(usersDS);

                foreach(DataTable dt in usersDS.Tables) 
                {
                    dg_users.ItemsSource = dt.DefaultView;
                }

                con.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow authorization = new MainWindow();
            authorization.Show();

            this.Close();
        }

        private void btn_unLock_Click(object sender, RoutedEventArgs e)
        {
            if(dg_users.SelectedItem != null)
            {
                DataRowView? drt = dg_users.SelectedItem as DataRowView;
                drt!.Row["Active"] = drt.Row["Active"].ToString()!.Equals("False") ? true : (object)false;
                int id = int.Parse(drt!.Row["ID"].ToString()!);

                using (SqlConnection con = new SqlConnection(connection))
                {
                    try
                    {
                        con.Open();

                        SqlCommand sqlCommand = new SqlCommand("update users set Active=@active where id=@id;", con);
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.Parameters.AddWithValue("@active", drt!.Row["Active"]);

                        sqlCommand.ExecuteNonQuery();

                        con.Close();
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
