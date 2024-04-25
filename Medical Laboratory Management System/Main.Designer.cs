using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Main : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Panel1 = new Panel();
            Label2 = new Label();
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Panel2 = new Panel();
            btnlogout = new Button();
            btnlogout.Click += new EventHandler(btnlogout_Click);
            btnuser_settings = new Button();
            btnuser_settings.Click += new EventHandler(Button5_Click);
            btnresult = new Button();
            btnresult.Click += new EventHandler(Button4_Click);
            btnanalysis = new Button();
            btnanalysis.Click += new EventHandler(btnanalysis_Click);
            btntest = new Button();
            btntest.Click += new EventHandler(Button2_Click);
            btnpatient = new Button();
            btnpatient.Click += new EventHandler(Button1_Click);
            Panel3 = new Panel();
            Panel4 = new Panel();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(55, 57, 93);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(PictureBox1);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1189, 51);
            Panel1.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 15.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(327, 16);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(201, 30);
            Label2.TabIndex = 4;
            Label2.Text = "Management System";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(79, 10);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(254, 37);
            Label1.TabIndex = 3;
            Label1.Text = "Medical Laboratory";
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.White;
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(17, 6);
            PictureBox1.Margin = new Padding(2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(54, 41);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(btntest);
            Panel2.Controls.Add(btnlogout);
            Panel2.Controls.Add(btnuser_settings);
            Panel2.Controls.Add(btnresult);
            Panel2.Controls.Add(btnanalysis);
            Panel2.Controls.Add(btnpatient);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 51);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1189, 49);
            Panel2.TabIndex = 1;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(55, 57, 93);
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(978, 6);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(164, 34);
            btnlogout.TabIndex = 5;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnuser_settings
            // 
            btnuser_settings.BackColor = Color.FromArgb(55, 57, 93);
            btnuser_settings.FlatStyle = FlatStyle.Flat;
            btnuser_settings.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnuser_settings.ForeColor = Color.White;
            btnuser_settings.Location = new Point(786, 6);
            btnuser_settings.Name = "btnuser_settings";
            btnuser_settings.Size = new Size(164, 34);
            btnuser_settings.TabIndex = 4;
            btnuser_settings.Text = "Settings";
            btnuser_settings.UseVisualStyleBackColor = false;
            // 
            // btnresult
            // 
            btnresult.BackColor = Color.FromArgb(55, 57, 93);
            btnresult.FlatStyle = FlatStyle.Flat;
            btnresult.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresult.ForeColor = Color.White;
            btnresult.Location = new Point(415, 6);
            btnresult.Name = "btnresult";
            btnresult.Size = new Size(164, 34);
            btnresult.TabIndex = 3;
            btnresult.Text = "Result";
            btnresult.UseVisualStyleBackColor = false;
            // 
            // btnanalysis
            // 
            btnanalysis.BackColor = Color.FromArgb(55, 57, 93);
            btnanalysis.FlatStyle = FlatStyle.Flat;
            btnanalysis.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnanalysis.ForeColor = Color.White;
            btnanalysis.Location = new Point(230, 6);
            btnanalysis.Name = "btnanalysis";
            btnanalysis.Size = new Size(164, 34);
            btnanalysis.TabIndex = 2;
            btnanalysis.Text = "Bills";
            btnanalysis.UseVisualStyleBackColor = false;
            // 
            // btntest
            // 
            btntest.BackColor = Color.FromArgb(55, 57, 93);
            btntest.FlatStyle = FlatStyle.Flat;
            btntest.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntest.ForeColor = Color.White;
            btntest.Location = new Point(600, 6);
            btntest.Name = "btntest";
            btntest.Size = new Size(164, 34);
            btntest.TabIndex = 1;
            btntest.Text = "Test";
            btntest.UseVisualStyleBackColor = false;
            // 
            // btnpatient
            // 
            btnpatient.BackColor = Color.FromArgb(55, 57, 93);
            btnpatient.FlatStyle = FlatStyle.Flat;
            btnpatient.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpatient.ForeColor = Color.White;
            btnpatient.Location = new Point(44, 6);
            btnpatient.Name = "btnpatient";
            btnpatient.Size = new Size(164, 34);
            btnpatient.TabIndex = 0;
            btnpatient.Text = "Patient";
            btnpatient.UseVisualStyleBackColor = false;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(55, 57, 93);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(0, 100);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1189, 11);
            Panel3.TabIndex = 2;
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.White;
            Panel4.Dock = DockStyle.Fill;
            Panel4.Location = new Point(0, 111);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1189, 613);
            Panel4.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 724);
            Controls.Add(Panel4);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel2.ResumeLayout(false);
            Load += new EventHandler(Main_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
        internal Panel Panel2;
        internal Button btnuser_settings;
        internal Button btnresult;
        internal Button btnanalysis;
        internal Button btntest;
        internal Button btnpatient;
        internal Panel Panel3;
        internal Panel Panel4;
        internal Button btnlogout;
    }
}