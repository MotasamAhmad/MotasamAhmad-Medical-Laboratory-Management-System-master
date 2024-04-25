using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Patient : UserControl
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
            btnSave = new Button();
            btnSave.Click += new EventHandler(Button1_Click);
            txtAge = new TextBox();
            txtphoneNO = new TextBox();
            txtAddress = new TextBox();
            txtpatientName = new TextBox();
            Label12 = new Label();
            Label6 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Guestname = new Label();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            cmbGender = new ComboBox();
            cmbMaritalStatus = new ComboBox();
            btnSearch = new Button();
            btnSearch.Click += new EventHandler(Button2_Click);
            btnDelete = new Button();
            btnDelete.Click += new EventHandler(Button3_Click);
            Label1 = new Label();
            cmbBloodGroup = new ComboBox();
            btnAdd = new Button();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            GBPatientdata = new GroupBox();
            Label5 = new Label();
            txtPatientID = new TextBox();
            btnCancel = new Button();
            btnCancel.Click += new EventHandler(btnCancel_Click);
            GBPatientdata.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(55, 57, 93);
            btnSave.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(761, 538);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 47);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(809, 122);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(148, 29);
            txtAge.TabIndex = 50;
            // 
            // txtphoneNO
            // 
            txtphoneNO.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphoneNO.Location = new Point(210, 299);
            txtphoneNO.Name = "txtphoneNO";
            txtphoneNO.Size = new Size(298, 29);
            txtphoneNO.TabIndex = 48;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(210, 212);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(407, 79);
            txtAddress.TabIndex = 47;
            // 
            // txtpatientName
            // 
            txtpatientName.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpatientName.Location = new Point(210, 169);
            txtpatientName.Name = "txtpatientName";
            txtpatientName.Size = new Size(407, 29);
            txtpatientName.TabIndex = 46;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label12.Location = new Point(638, 173);
            Label12.Name = "Label12";
            Label12.Size = new Size(122, 21);
            Label12.TabIndex = 40;
            Label12.Text = "Marital status :-";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(706, 130);
            Label6.Name = "Label6";
            Label6.Size = new Size(54, 21);
            Label6.TabIndex = 37;
            Label6.Text = "Age :-";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(88, 220);
            Label9.Name = "Label9";
            Label9.Size = new Size(84, 21);
            Label9.TabIndex = 36;
            Label9.Text = "Address :-";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(96, 345);
            Label8.Name = "Label8";
            Label8.Size = new Size(78, 21);
            Label8.TabIndex = 35;
            Label8.Text = "Gender :-";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(78, 300);
            Label7.Name = "Label7";
            Label7.Size = new Size(96, 21);
            Label7.TabIndex = 34;
            Label7.Text = "Phone No :-";
            // 
            // Guestname
            // 
            Guestname.AutoSize = true;
            Guestname.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guestname.Location = new Point(52, 177);
            Guestname.Name = "Guestname";
            Guestname.Size = new Size(122, 21);
            Guestname.TabIndex = 33;
            Guestname.Text = "Patient Name :-";
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape3 });
            ShapeContainer1.Size = new Size(1189, 613);
            ShapeContainer1.TabIndex = 58;
            ShapeContainer1.TabStop = false;
            // 
            // RectangleShape3
            // 
            RectangleShape3.CornerRadius = 5;
            RectangleShape3.Location = new Point(17, 529);
            RectangleShape3.Name = "RectangleShape3";
            RectangleShape3.Size = new Size(1157, 63);
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Microsoft Tai Le", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(210, 344);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(148, 29);
            cmbGender.TabIndex = 60;
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.Font = new Font("Microsoft Tai Le", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Items.AddRange(new object[] { "Single", "Married", "Divorced" });
            cmbMaritalStatus.Location = new Point(809, 167);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(148, 29);
            cmbMaritalStatus.TabIndex = 61;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 57, 93);
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(553, 538);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 47);
            btnSearch.TabIndex = 62;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(55, 57, 93);
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(351, 538);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 47);
            btnDelete.TabIndex = 63;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(642, 216);
            Label1.Name = "Label1";
            Label1.Size = new Size(118, 21);
            Label1.TabIndex = 65;
            Label1.Text = "Blood Group :-";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Font = new Font("Microsoft Tai Le", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "A +", "A -", "B +", "B -", "O +", "O -", "AB +", "AB -" });
            cmbBloodGroup.Location = new Point(809, 215);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(148, 29);
            cmbBloodGroup.TabIndex = 66;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 57, 93);
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(961, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 47);
            btnAdd.TabIndex = 68;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // GBPatientdata
            // 
            GBPatientdata.Controls.Add(Label5);
            GBPatientdata.Controls.Add(Guestname);
            GBPatientdata.Controls.Add(Label7);
            GBPatientdata.Controls.Add(cmbBloodGroup);
            GBPatientdata.Controls.Add(Label8);
            GBPatientdata.Controls.Add(Label1);
            GBPatientdata.Controls.Add(Label9);
            GBPatientdata.Controls.Add(Label6);
            GBPatientdata.Controls.Add(Label12);
            GBPatientdata.Controls.Add(cmbMaritalStatus);
            GBPatientdata.Controls.Add(txtpatientName);
            GBPatientdata.Controls.Add(cmbGender);
            GBPatientdata.Controls.Add(txtAddress);
            GBPatientdata.Controls.Add(txtPatientID);
            GBPatientdata.Controls.Add(txtphoneNO);
            GBPatientdata.Controls.Add(txtAge);
            GBPatientdata.Enabled = false;
            GBPatientdata.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBPatientdata.Location = new Point(17, 14);
            GBPatientdata.Name = "GBPatientdata";
            GBPatientdata.Size = new Size(1156, 495);
            GBPatientdata.TabIndex = 69;
            GBPatientdata.TabStop = false;
            GBPatientdata.Text = "Patient Data";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(77, 126);
            Label5.Name = "Label5";
            Label5.Size = new Size(95, 21);
            Label5.TabIndex = 32;
            Label5.Text = "Patient ID :-";
            // 
            // txtPatientID
            // 
            txtPatientID.Enabled = false;
            txtPatientID.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientID.Location = new Point(210, 123);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(298, 29);
            txtPatientID.TabIndex = 59;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(55, 57, 93);
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(155, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 47);
            btnCancel.TabIndex = 68;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancel);
            Controls.Add(GBPatientdata);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(ShapeContainer1);
            Name = "Patient";
            Size = new Size(1189, 613);
            GBPatientdata.ResumeLayout(false);
            GBPatientdata.PerformLayout();
            Load += new EventHandler(Patient_Load);
            ResumeLayout(false);

        }

        internal Button btnSave;
        internal TextBox txtAge;
        internal TextBox txtphoneNO;
        internal TextBox txtAddress;
        internal TextBox txtpatientName;
        internal Label Label12;
        internal Label Label6;
        internal Label Label9;
        internal Label Label8;
        internal Label Label7;
        internal Label Guestname;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape3;
        internal ComboBox cmbGender;
        internal ComboBox cmbMaritalStatus;
        internal Button btnSearch;
        internal Button btnDelete;
        internal Label Label1;
        internal ComboBox cmbBloodGroup;
        internal Button btnAdd;
        internal GroupBox GBPatientdata;
        internal TextBox txtPatientID;
        internal Button btnCancel;
        internal Label Label5;
    }
}