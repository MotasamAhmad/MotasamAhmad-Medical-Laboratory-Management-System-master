using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Result_1 : UserControl
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
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.RectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtPatient_ID = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPatient_Name = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtpResult = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.DGVResult = new System.Windows.Forms.DataGridView();
            this.Test_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sample_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mini_Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max_Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBResult = new System.Windows.Forms.GroupBox();
            this.txtBill_No = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).BeginInit();
            this.GBResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.RectangleShape3});
            this.ShapeContainer1.Size = new System.Drawing.Size(1585, 754);
            this.ShapeContainer1.TabIndex = 0;
            this.ShapeContainer1.TabStop = false;
            // 
            // RectangleShape3
            // 
            this.RectangleShape3.CornerRadius = 5;
            this.RectangleShape3.Location = new System.Drawing.Point(17, 529);
            this.RectangleShape3.Name = "RectangleShape3";
            this.RectangleShape3.Size = new System.Drawing.Size(1157, 63);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(168, 118);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 28);
            this.Label5.TabIndex = 69;
            this.Label5.Text = "Patient ID :-";
            // 
            // txtPatient_ID
            // 
            this.txtPatient_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient_ID.Location = new System.Drawing.Point(337, 118);
            this.txtPatient_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatient_ID.Name = "txtPatient_ID";
            this.txtPatient_ID.Size = new System.Drawing.Size(536, 34);
            this.txtPatient_ID.TabIndex = 74;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(132, 172);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(154, 28);
            this.Label9.TabIndex = 83;
            this.Label9.Text = "Patient Name :-";
            // 
            // txtPatient_Name
            // 
            this.txtPatient_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient_Name.Location = new System.Drawing.Point(337, 169);
            this.txtPatient_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatient_Name.Name = "txtPatient_Name";
            this.txtPatient_Name.Size = new System.Drawing.Size(536, 34);
            this.txtPatient_Name.TabIndex = 84;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(936, 73);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(73, 28);
            this.Label10.TabIndex = 85;
            this.Label10.Text = "Date :-";
            // 
            // dtpResult
            // 
            this.dtpResult.CustomFormat = "dd/MM/yyyy";
            this.dtpResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResult.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResult.Location = new System.Drawing.Point(1057, 69);
            this.dtpResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpResult.Name = "dtpResult";
            this.dtpResult.Size = new System.Drawing.Size(265, 34);
            this.dtpResult.TabIndex = 86;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1015, 662);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(232, 58);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1281, 662);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(232, 58);
            this.btnPrint.TabIndex = 89;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(737, 662);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 58);
            this.btnSave.TabIndex = 90;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(909, 126);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(98, 28);
            this.Label8.TabIndex = 91;
            this.Label8.Text = "Gender :-";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(1057, 122);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(265, 34);
            this.txtGender.TabIndex = 92;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(941, 176);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(67, 28);
            this.Label6.TabIndex = 93;
            this.Label6.Text = "Age :-";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(1057, 176);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(265, 34);
            this.txtAge.TabIndex = 94;
            // 
            // DGVResult
            // 
            this.DGVResult.AllowUserToAddRows = false;
            this.DGVResult.AllowUserToDeleteRows = false;
            this.DGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Test_ID,
            this.Test_Name,
            this.Result,
            this.Sample_Unit,
            this.State,
            this.Mini_Range,
            this.Max_Range});
            this.DGVResult.Location = new System.Drawing.Point(284, 231);
            this.DGVResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVResult.Name = "DGVResult";
            this.DGVResult.RowHeadersWidth = 51;
            this.DGVResult.Size = new System.Drawing.Size(1060, 380);
            this.DGVResult.TabIndex = 95;
            this.DGVResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVResult_CellContentClick);
            this.DGVResult.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVResult_CellEndEdit);
            // 
            // Test_ID
            // 
            this.Test_ID.HeaderText = "Test ID";
            this.Test_ID.MinimumWidth = 6;
            this.Test_ID.Name = "Test_ID";
            this.Test_ID.Visible = false;
            this.Test_ID.Width = 125;
            // 
            // Test_Name
            // 
            this.Test_Name.HeaderText = "Test_Name";
            this.Test_Name.MinimumWidth = 6;
            this.Test_Name.Name = "Test_Name";
            this.Test_Name.ReadOnly = true;
            this.Test_Name.Width = 200;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.Width = 110;
            // 
            // Sample_Unit
            // 
            this.Sample_Unit.HeaderText = "Sample Unit";
            this.Sample_Unit.MinimumWidth = 6;
            this.Sample_Unit.Name = "Sample_Unit";
            this.Sample_Unit.ReadOnly = true;
            this.Sample_Unit.Width = 110;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.Width = 110;
            // 
            // Mini_Range
            // 
            this.Mini_Range.HeaderText = "Mini Range";
            this.Mini_Range.MinimumWidth = 6;
            this.Mini_Range.Name = "Mini_Range";
            this.Mini_Range.ReadOnly = true;
            this.Mini_Range.Width = 110;
            // 
            // Max_Range
            // 
            this.Max_Range.HeaderText = "Max Range";
            this.Max_Range.MinimumWidth = 6;
            this.Max_Range.Name = "Max_Range";
            this.Max_Range.ReadOnly = true;
            this.Max_Range.Width = 110;
            // 
            // GBResult
            // 
            this.GBResult.Controls.Add(this.txtBill_No);
            this.GBResult.Controls.Add(this.Label2);
            this.GBResult.Controls.Add(this.Label5);
            this.GBResult.Controls.Add(this.DGVResult);
            this.GBResult.Controls.Add(this.txtPatient_ID);
            this.GBResult.Controls.Add(this.txtAge);
            this.GBResult.Controls.Add(this.Label9);
            this.GBResult.Controls.Add(this.Label6);
            this.GBResult.Controls.Add(this.txtPatient_Name);
            this.GBResult.Controls.Add(this.txtGender);
            this.GBResult.Controls.Add(this.Label10);
            this.GBResult.Controls.Add(this.Label8);
            this.GBResult.Controls.Add(this.dtpResult);
            this.GBResult.Enabled = false;
            this.GBResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GBResult.Location = new System.Drawing.Point(23, 16);
            this.GBResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBResult.Name = "GBResult";
            this.GBResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBResult.Size = new System.Drawing.Size(1544, 619);
            this.GBResult.TabIndex = 97;
            this.GBResult.TabStop = false;
            this.GBResult.Text = "Result Details";
            // 
            // txtBill_No
            // 
            this.txtBill_No.Enabled = false;
            this.txtBill_No.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill_No.Location = new System.Drawing.Point(337, 65);
            this.txtBill_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBill_No.Name = "txtBill_No";
            this.txtBill_No.Size = new System.Drawing.Size(536, 34);
            this.txtBill_No.TabIndex = 97;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(199, 69);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 28);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Bill No :-";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(468, 662);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(232, 58);
            this.btnCancel.TabIndex = 98;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Result_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.GBResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ShapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Result_1";
            this.Size = new System.Drawing.Size(1585, 754);
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).EndInit();
            this.GBResult.ResumeLayout(false);
            this.GBResult.PerformLayout();
            this.ResumeLayout(false);

        }
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape3;
        internal Label Label5;
        internal TextBox txtPatient_ID;
        internal Label Label9;
        internal TextBox txtPatient_Name;
        internal Label Label10;
        internal DateTimePicker dtpResult;
        internal Button btnSearch;
        internal Button btnPrint;
        internal Button btnSave;
        internal Label Label8;
        internal TextBox txtGender;
        internal Label Label6;
        internal TextBox txtAge;
        internal DataGridView DGVResult;
        internal GroupBox GBResult;
        internal TextBox txtBill_No;
        internal Label Label2;
        internal Button btnCancel;
        internal DataGridViewTextBoxColumn Unit;
        internal DataGridViewTextBoxColumn Test_ID;
        internal DataGridViewTextBoxColumn Test_Name;
        internal DataGridViewTextBoxColumn Result;
        internal DataGridViewTextBoxColumn Sample_Unit;
        internal DataGridViewTextBoxColumn State;
        internal DataGridViewTextBoxColumn Mini_Range;
        internal DataGridViewTextBoxColumn Max_Range;
    }
}