using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Settings : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
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
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            Label5 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label4 = new Label();
            txtUserID = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            GroupBox1 = new GroupBox();
            RBUser = new RadioButton();
            RBAdmin = new RadioButton();
            GBTest = new GroupBox();
            DGVSettings = new DataGridView();
            DGVSettings.CellDoubleClick += new DataGridViewCellEventHandler(DGVSettings_CellDoubleClick);
            btnAdd = new Button();
            btnAdd.Click += new EventHandler(Button2_Click_1);
            btnsave = new Button();
            btnsave.Click += new EventHandler(Button3_Click);
            btndelete = new Button();
            btndelete.Click += new EventHandler(Button1_Click);
            btncancel = new Button();
            btncancel.Click += new EventHandler(btncancel_Click);
            GroupBox1.SuspendLayout();
            GBTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSettings).BeginInit();
            SuspendLayout();
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape3 });
            ShapeContainer1.Size = new Size(1189, 613);
            ShapeContainer1.TabIndex = 0;
            ShapeContainer1.TabStop = false;
            // 
            // RectangleShape3
            // 
            RectangleShape3.CornerRadius = 5;
            RectangleShape3.Location = new Point(17, 529);
            RectangleShape3.Name = "RectangleShape3";
            RectangleShape3.Size = new Size(1157, 63);
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(101, 114);
            Label5.Name = "Label5";
            Label5.Size = new Size(77, 21);
            Label5.TabIndex = 35;
            Label5.Text = "User ID :-";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(74, 172);
            Label1.Name = "Label1";
            Label1.Size = new Size(104, 21);
            Label1.TabIndex = 36;
            Label1.Text = "User Name :-";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(85, 234);
            Label2.Name = "Label2";
            Label2.Size = new Size(93, 21);
            Label2.TabIndex = 37;
            Label2.Text = "Password :-";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(76, 297);
            Label4.Name = "Label4";
            Label4.Size = new Size(102, 21);
            Label4.TabIndex = 38;
            Label4.Text = "Permission :-";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(224, 111);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(268, 29);
            txtUserID.TabIndex = 39;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(224, 169);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(268, 29);
            txtUserName.TabIndex = 40;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(224, 231);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(268, 29);
            txtPassword.TabIndex = 41;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.White;
            GroupBox1.Controls.Add(RBUser);
            GroupBox1.Controls.Add(RBAdmin);
            GroupBox1.ForeColor = Color.Black;
            GroupBox1.Location = new Point(224, 284);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(174, 49);
            GroupBox1.TabIndex = 42;
            GroupBox1.TabStop = false;
            // 
            // RBUser
            // 
            RBUser.AutoSize = true;
            RBUser.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold);
            RBUser.ForeColor = Color.Black;
            RBUser.Location = new Point(17, 16);
            RBUser.Name = "RBUser";
            RBUser.Size = new Size(61, 25);
            RBUser.TabIndex = 10;
            RBUser.TabStop = true;
            RBUser.Text = "User";
            RBUser.UseVisualStyleBackColor = true;
            // 
            // RBAdmin
            // 
            RBAdmin.AutoSize = true;
            RBAdmin.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold);
            RBAdmin.ForeColor = Color.Black;
            RBAdmin.Location = new Point(90, 17);
            RBAdmin.Name = "RBAdmin";
            RBAdmin.Size = new Size(76, 25);
            RBAdmin.TabIndex = 11;
            RBAdmin.TabStop = true;
            RBAdmin.Text = "Admin";
            RBAdmin.UseVisualStyleBackColor = true;
            // 
            // GBTest
            // 
            GBTest.Controls.Add(DGVSettings);
            GBTest.Controls.Add(Label5);
            GBTest.Controls.Add(GroupBox1);
            GBTest.Controls.Add(Label1);
            GBTest.Controls.Add(txtPassword);
            GBTest.Controls.Add(Label2);
            GBTest.Controls.Add(txtUserName);
            GBTest.Controls.Add(Label4);
            GBTest.Controls.Add(txtUserID);
            GBTest.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBTest.Location = new Point(16, 19);
            GBTest.Name = "GBTest";
            GBTest.Size = new Size(1156, 500);
            GBTest.TabIndex = 116;
            GBTest.TabStop = false;
            GBTest.Text = "User Settings";
            // 
            // DGVSettings
            // 
            DGVSettings.AllowUserToAddRows = false;
            DGVSettings.AllowUserToDeleteRows = false;
            DGVSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSettings.Location = new Point(646, 92);
            DGVSettings.Name = "DGVSettings";
            DGVSettings.ReadOnly = true;
            DGVSettings.Size = new Size(439, 241);
            DGVSettings.TabIndex = 43;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 57, 93);
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(961, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 47);
            btnAdd.TabIndex = 108;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(55, 57, 93);
            btnsave.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(761, 538);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(174, 47);
            btnsave.TabIndex = 108;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(55, 57, 93);
            btndelete.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(553, 538);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(174, 47);
            btndelete.TabIndex = 117;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.FromArgb(55, 57, 93);
            btncancel.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.ForeColor = Color.White;
            btncancel.Location = new Point(351, 538);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(174, 47);
            btncancel.TabIndex = 118;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btncancel);
            Controls.Add(btndelete);
            Controls.Add(btnsave);
            Controls.Add(btnAdd);
            Controls.Add(GBTest);
            Controls.Add(ShapeContainer1);
            Name = "Settings";
            Size = new Size(1189, 613);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GBTest.ResumeLayout(false);
            GBTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSettings).EndInit();
            Load += new EventHandler(Test_Load);
            ResumeLayout(false);

        }
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape3;
        internal Label Label5;
        internal Label Label1;
        internal Label Label2;
        internal Label Label4;
        internal TextBox txtUserID;
        internal TextBox txtUserName;
        internal TextBox txtPassword;
        internal GroupBox GroupBox1;
        internal RadioButton RBUser;
        internal RadioButton RBAdmin;
        internal GroupBox GBTest;
        internal DataGridView DGVSettings;
        internal Button btnAdd;
        internal Button btnsave;
        internal Button btndelete;
        internal Button btncancel;
    }
}