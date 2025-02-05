using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;

using Vaishnavi_Garment.CustomStyles;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaishnavi_Garment.UI
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            //GradientPanel myPanel = new GradientPanel
            //{
            //    StartColor = Color.OrangeRed,  // Customize gradient colors
            //    EndColor = Color.Yellow,
            //    Size = new Size(300, 200),
            //    Location = new Point(50, 50)
            //};

            //RoundedButton myButton = new RoundedButton
            //{
            //    Text = "Click Me",
            //    Size = new Size(150, 50),
            //    Location = new Point(50, 50),
            //    BorderRadius = 30 // Set rounded corners
            //};

            //this.Controls.Add(myButton);

            //this.Controls.Add(myPanel); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Enable Anti-Aliasing for smooth gradients
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Define Gradient Brush
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel1.ClientRectangle, // Panel area
                Color.Black,  // Start Color
                Color.Brown,  // End Color
                LinearGradientMode.Horizontal)) // Change to Vertical if needed
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
