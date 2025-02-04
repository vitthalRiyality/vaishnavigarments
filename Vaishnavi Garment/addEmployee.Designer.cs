namespace Vaishnavi_Garment
{
    partial class addEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(281, 161);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(801, 164);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(176, 26);
            this.txtPosition.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(281, 300);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(173, 26);
            this.txtSalary.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(801, 294);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(176, 26);
            this.txtContact.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(281, 373);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 56);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 688);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "addEmployee";
            this.Text = "addEmployee";
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button saveBtn;
    }
}