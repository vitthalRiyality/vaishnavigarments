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
    public partial class addEmployee : Form
    {
        string dbPath = System.IO.Path.Combine(Application.StartupPath, "vaishnavi.accdb");
        string connectionString;
        public addEmployee()
        {
            InitializeComponent();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + dbPath + "';";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empName = txtName.Text.Trim();
            string empPosition = txtPosition.Text.Trim();
            string empSalary = txtSalary.Text.Trim();
            string empContact = txtContact.Text.Trim();

            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(empPosition) ||
                string.IsNullOrWhiteSpace(empSalary) || string.IsNullOrWhiteSpace(empContact))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Use [position] in square brackets to avoid syntax errors
                string query = "INSERT INTO Employee (name, [position], salary, contact) VALUES (@Name, @Position, @Salary, @Contact)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@Name", empName);
                command.Parameters.AddWithValue("@Position", empPosition);
                command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(empSalary));
                command.Parameters.AddWithValue("@Contact", empContact);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtPosition.Clear();
                    txtSalary.Clear();
                    txtContact.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void addEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
