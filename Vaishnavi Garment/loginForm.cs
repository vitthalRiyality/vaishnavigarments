using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Vaishnavi_Garment
{
    public partial class loginForm : Form
    {
        string dbPath = System.IO.Path.Combine(Application.StartupPath, "vaishnavi.accdb");
        string connectionString;
        public loginForm()
        {
            InitializeComponent();
             connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='"+dbPath+"';";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string role = reader["Role"].ToString();
                          MessageBox.Show("Login successful! Welcome, " + username + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Dashboard d = new Dashboard();
                       d.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
