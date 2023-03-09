using AMONIC_airlines.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Windows;
using System.Windows.Documents;

namespace AMONIC_airlines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String connection = "Data Source=DESKTOP-CDAE4UR;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial catalog=Session1_XX;";
        String initialCMD = "select Users.Email as 'l', Users.Password as 'p', Roles.Title as 'role' from Users inner join Roles on Users.RoleID = Roles.ID";
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        List<user_> users = new List<user_>();

        public class user_
        {
            public String login, password, role;

            public user_(string login, string password, string role)
            {
                this.login = login;
                this.password = password;
                this.role = role;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(initialCMD, con);

                adapter.Fill(ds);
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    user_ user_ = new user_(dr["l"].ToString()!, dr["p"].ToString()!, dr["role"].ToString()!);
                    users.Add(user_);    
                }

            }

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            bool t1 = false;
            bool t2 = false;

            foreach(user_ u in users)
            {
                if(u.login.Equals(tb_login.Text))
                {
                    if(u.password.Equals(pb_password.Password))
                    {
                        if (u.role.Equals("Administrator"))
                        {
                            t1 = true;
                            t2 = true;

                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();

                            this.Close();
                        } else
                        {
                            t2 = true;
                            break;
                        }
                    } else
                    {
                        t1 = true;
                        break;
                    }
                }
            }

            if(!t1 && !t2)
                MessageBox.Show("Пользователь не найден");
            if(t1 && !t2)
                MessageBox.Show("Неверный пароль");
            if(t2 && !t1)
                MessageBox.Show("Обычный пользовтель");
        }
    }
}
