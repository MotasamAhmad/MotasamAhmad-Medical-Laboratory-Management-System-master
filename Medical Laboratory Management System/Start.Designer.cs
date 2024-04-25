using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Start : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            Label2 = new Label();
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 18.0f, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(41, 317);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(234, 32);
            Label2.TabIndex = 5;
            Label2.Text = "Management System";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.FromArgb(55, 57, 93);
            Label1.Font = new Font("Segoe UI Semibold", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(23, 264);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(272, 40);
            Label1.TabIndex = 4;
            Label1.Text = "Medical Laboratory";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(56, 52);
            PictureBox1.Margin = new Padding(2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(209, 186);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 3;
            PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 10;
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape1 });
            ShapeContainer1.Size = new Size(322, 522);
            ShapeContainer1.TabIndex = 6;
            ShapeContainer1.TabStop = false;
            // 
            // RectangleShape1
            // 
            RectangleShape1.BackColor = Color.White;
            RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            RectangleShape1.BorderColor = Color.White;
            RectangleShape1.CornerRadius = 3;
            RectangleShape1.FillColor = Color.White;
            RectangleShape1.Location = new Point(10, 476);
            RectangleShape1.Name = "RectangleShape1";
            RectangleShape1.Size = new Size(17, 11);
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 57, 93);
            ClientSize = new Size(322, 522);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Controls.Add(ShapeContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label2;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Timer Timer1;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;
    }
}