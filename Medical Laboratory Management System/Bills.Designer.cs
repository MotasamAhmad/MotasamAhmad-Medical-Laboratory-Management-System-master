using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Bills : UserControl
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
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            btnSave = new Button();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnSearch = new Button();
            btnSearch.Click += new EventHandler(Button2_Click);
            Label5 = new Label();
            txtPatient_ID = new TextBox();
            Label6 = new Label();
            txtTprice = new TextBox();
            DGVBills = new DataGridView();
            DGVBills.CellContentClick += new DataGridViewCellEventHandler(DGVBills_CellContentClick);
            Test_ID = new DataGridViewTextBoxColumn();
            Test_Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Mini_value = new DataGridViewTextBoxColumn();
            Max_value = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            txtPatient_Name = new TextBox();
            Label9 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            txtBill_No = new TextBox();
            btnAddTest = new Button();
            btnAddTest.Click += new EventHandler(btnAddTest_Click);
            btnAddPatient = new Button();
            btnAddPatient.Click += new EventHandler(btnAddPatient_Click);
            btnAdd = new Button();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnDelete = new Button();
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnCancel = new Button();
            btnCancel.Click += new EventHandler(btnCancel_Click);
            GBBills = new GroupBox();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGVBills).BeginInit();
            GBBills.SuspendLayout();
            SuspendLayout();
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape2 });
            ShapeContainer1.Size = new Size(1189, 613);
            ShapeContainer1.TabIndex = 0;
            ShapeContainer1.TabStop = false;
            // 
            // RectangleShape2
            // 
            RectangleShape2.CornerRadius = 5;
            RectangleShape2.Location = new Point(17, 529);
            RectangleShape2.Name = "RectangleShape2";
            RectangleShape2.Size = new Size(1157, 63);
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(55, 57, 93);
            btnSave.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(761, 538);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 47);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 57, 93);
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(553, 538);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 47);
            btnSearch.TabIndex = 65;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(86, 131);
            Label5.Name = "Label5";
            Label5.Size = new Size(95, 21);
            Label5.TabIndex = 68;
            Label5.Text = "Patient ID :-";
            // 
            // txtPatient_ID
            // 
            txtPatient_ID.Enabled = false;
            txtPatient_ID.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatient_ID.Location = new Point(203, 130);
            txtPatient_ID.Name = "txtPatient_ID";
            txtPatient_ID.Size = new Size(360, 29);
            txtPatient_ID.TabIndex = 73;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(81, 253);
            Label6.Name = "Label6";
            Label6.Size = new Size(99, 21);
            Label6.TabIndex = 74;
            Label6.Text = "Total Price :-";
            // 
            // txtTprice
            // 
            txtTprice.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTprice.Location = new Point(203, 245);
            txtTprice.Name = "txtTprice";
            txtTprice.Size = new Size(227, 29);
            txtTprice.TabIndex = 77;
            // 
            // DGVBills
            // 
            DGVBills.AllowUserToAddRows = false;
            DGVBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVBills.Columns.AddRange(new DataGridViewColumn[] { Test_ID, Test_Name, Price, Mini_value, Max_value, Delete });
            DGVBills.Location = new Point(600, 75);
            DGVBills.Name = "DGVBills";
            DGVBills.ReadOnly = true;
            DGVBills.Size = new Size(540, 316);
            DGVBills.TabIndex = 80;
            // 
            // Test_ID
            // 
            Test_ID.Frozen = true;
            Test_ID.HeaderText = "Test ID";
            Test_ID.Name = "Test_ID";
            Test_ID.ReadOnly = true;
            // 
            // Test_Name
            // 
            Test_Name.HeaderText = "Test Name";
            Test_Name.Name = "Test_Name";
            Test_Name.ReadOnly = true;
            Test_Name.Width = 200;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Mini_value
            // 
            Mini_value.HeaderText = "Mini value";
            Mini_value.Name = "Mini_value";
            Mini_value.ReadOnly = true;
            Mini_value.Visible = false;
            // 
            // Max_value
            // 
            Max_value.HeaderText = "Max value";
            Max_value.Name = "Max_value";
            Max_value.ReadOnly = true;
            Max_value.Visible = false;
            // 
            // Delete
            // 
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle2.ForeColor = Color.Black;
            Delete.DefaultCellStyle = DataGridViewCellStyle2;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // txtPatient_Name
            // 
            txtPatient_Name.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatient_Name.Location = new Point(203, 186);
            txtPatient_Name.Name = "txtPatient_Name";
            txtPatient_Name.Size = new Size(360, 29);
            txtPatient_Name.TabIndex = 81;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(58, 185);
            Label9.Name = "Label9";
            Label9.Size = new Size(122, 21);
            Label9.TabIndex = 82;
            Label9.Text = "Patient Name :-";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(122, 316);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 21);
            Label1.TabIndex = 88;
            Label1.Text = "Date :-";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(108, 78);
            Label2.Name = "Label2";
            Label2.Size = new Size(72, 21);
            Label2.TabIndex = 89;
            Label2.Text = "Bill No :-";
            // 
            // txtBill_No
            // 
            txtBill_No.Enabled = false;
            txtBill_No.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBill_No.Location = new Point(203, 75);
            txtBill_No.Name = "txtBill_No";
            txtBill_No.Size = new Size(360, 29);
            txtBill_No.TabIndex = 90;
            // 
            // btnAddTest
            // 
            btnAddTest.BackColor = Color.FromArgb(55, 57, 93);
            btnAddTest.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTest.ForeColor = Color.White;
            btnAddTest.Location = new Point(666, 426);
            btnAddTest.Name = "btnAddTest";
            btnAddTest.Size = new Size(174, 47);
            btnAddTest.TabIndex = 91;
            btnAddTest.Text = "Add Test";
            btnAddTest.UseVisualStyleBackColor = false;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.FromArgb(55, 57, 93);
            btnAddPatient.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.ForeColor = Color.White;
            btnAddPatient.Location = new Point(875, 426);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(174, 47);
            btnAddPatient.TabIndex = 92;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 57, 93);
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(961, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 47);
            btnAdd.TabIndex = 93;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(55, 57, 93);
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(351, 538);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 47);
            btnDelete.TabIndex = 94;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(55, 57, 93);
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(155, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 47);
            btnCancel.TabIndex = 95;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // GBBills
            // 
            GBBills.Controls.Add(dtpDate);
            GBBills.Controls.Add(Label6);
            GBBills.Controls.Add(Label5);
            GBBills.Controls.Add(txtPatient_ID);
            GBBills.Controls.Add(txtTprice);
            GBBills.Controls.Add(btnAddPatient);
            GBBills.Controls.Add(DGVBills);
            GBBills.Controls.Add(btnAddTest);
            GBBills.Controls.Add(txtPatient_Name);
            GBBills.Controls.Add(txtBill_No);
            GBBills.Controls.Add(Label9);
            GBBills.Controls.Add(Label2);
            GBBills.Controls.Add(Label1);
            GBBills.Enabled = false;
            GBBills.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
            GBBills.Location = new Point(17, 18);
            GBBills.Name = "GBBills";
            GBBills.Size = new Size(1158, 503);
            GBBills.TabIndex = 96;
            GBBills.TabStop = false;
            GBBills.Text = "Bills Details";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(203, 310);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 29);
            dtpDate.TabIndex = 93;
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(GBBills);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(ShapeContainer1);
            Name = "Bills";
            Size = new Size(1189, 613);
            ((System.ComponentModel.ISupportInitialize)DGVBills).EndInit();
            GBBills.ResumeLayout(false);
            GBBills.PerformLayout();
            Load += new EventHandler(Bills_Load);
            ResumeLayout(false);

        }

        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape2;
        internal Button btnSave;
        internal Button btnSearch;
        internal Label Label5;
        internal TextBox txtPatient_ID;
        internal Label Label6;
        internal TextBox txtTprice;
        internal DataGridView DGVBills;
        internal TextBox txtPatient_Name;
        internal Label Label9;
        internal Label Label1;
        internal Label Label2;
        internal TextBox txtBill_No;
        internal Button btnAddTest;
        internal Button btnAddPatient;
        internal Button btnAdd;
        internal Button btnDelete;
        internal Button btnCancel;
        internal GroupBox GBBills;
        internal DataGridViewTextBoxColumn Test_ID;
        internal DataGridViewTextBoxColumn Test_Name;
        internal DataGridViewTextBoxColumn Price;
        internal DataGridViewTextBoxColumn Mini_value;
        internal DataGridViewTextBoxColumn Max_value;
        internal DataGridViewButtonColumn Delete;
        internal DateTimePicker dtpDate;
    }
}