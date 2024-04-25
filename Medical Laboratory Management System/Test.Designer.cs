using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Test : UserControl
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
            Label8 = new Label();
            Label7 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label5 = new Label();
            txtTestName = new TextBox();
            txtTestID = new TextBox();
            cmbSampleUnit = new ComboBox();
            CmbSampleType = new ComboBox();
            CmbTestType = new ComboBox();
            btnSava = new Button();
            btnSava.Click += new EventHandler(Button1_Click);
            btnSearch = new Button();
            btnSearch.Click += new EventHandler(Button2_Click);
            Label6 = new Label();
            btnDelete = new Button();
            btnDelete.Click += new EventHandler(btnDelete_Click);
            txtPrice = new TextBox();
            GBTest = new GroupBox();
            Label4 = new Label();
            Label3 = new Label();
            txtMini = new TextBox();
            txtMax = new TextBox();
            btnAdd = new Button();
            btnAdd.Click += new EventHandler(Button1_Click_1);
            btnCancel = new Button();
            btnCancel.Click += new EventHandler(btnCancel_Click);
            GBTest.SuspendLayout();
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
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(98, 156);
            Label8.Name = "Label8";
            Label8.Size = new Size(100, 21);
            Label8.TabIndex = 79;
            Label8.Text = "Test Name :-";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(106, 212);
            Label7.Name = "Label7";
            Label7.Size = new Size(92, 21);
            Label7.TabIndex = 80;
            Label7.Text = "Test Type :-";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(81, 259);
            Label1.Name = "Label1";
            Label1.Size = new Size(117, 21);
            Label1.TabIndex = 81;
            Label1.Text = "Sample Type :-";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(576, 103);
            Label2.Name = "Label2";
            Label2.Size = new Size(112, 21);
            Label2.TabIndex = 82;
            Label2.Text = "Sample Unit :-";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(125, 103);
            Label5.Name = "Label5";
            Label5.Size = new Size(73, 21);
            Label5.TabIndex = 83;
            Label5.Text = "Test ID :-";
            // 
            // txtTestName
            // 
            txtTestName.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTestName.Location = new Point(236, 153);
            txtTestName.Name = "txtTestName";
            txtTestName.Size = new Size(287, 29);
            txtTestName.TabIndex = 84;
            // 
            // txtTestID
            // 
            txtTestID.Enabled = false;
            txtTestID.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTestID.Location = new Point(236, 100);
            txtTestID.Name = "txtTestID";
            txtTestID.Size = new Size(287, 29);
            txtTestID.TabIndex = 85;
            // 
            // cmbSampleUnit
            // 
            cmbSampleUnit.Font = new Font("Microsoft Tai Le", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSampleUnit.FormattingEnabled = true;
            cmbSampleUnit.Items.AddRange(new object[] { "-", "%", "fL", @"g\dl", "L", "mg/dl", "mL", "uIU/mL", "uL" });
            cmbSampleUnit.Location = new Point(706, 95);
            cmbSampleUnit.Name = "cmbSampleUnit";
            cmbSampleUnit.Size = new Size(295, 29);
            cmbSampleUnit.TabIndex = 86;
            // 
            // CmbSampleType
            // 
            CmbSampleType.Font = new Font("Microsoft Tai Le", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbSampleType.FormattingEnabled = true;
            CmbSampleType.Items.AddRange(new object[] { "Blood", "Serum", "Urian", "Stool" });
            CmbSampleType.Location = new Point(236, 258);
            CmbSampleType.Name = "CmbSampleType";
            CmbSampleType.Size = new Size(287, 29);
            CmbSampleType.TabIndex = 87;
            // 
            // CmbTestType
            // 
            CmbTestType.Font = new Font("Microsoft Tai Le", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbTestType.FormattingEnabled = true;
            CmbTestType.Items.AddRange(new object[] { "URINE", "STOOOL", "HEMATOLOGY", "SEROLOGY", "BIOCHEMSTRY", "HORMONE", "TUMOR MARKERS", "DRUGS", "MICROBIOLOGY", "BODY FLUIDS", "BLOOD BANK" });
            CmbTestType.Location = new Point(236, 204);
            CmbTestType.Name = "CmbTestType";
            CmbTestType.Size = new Size(287, 29);
            CmbTestType.TabIndex = 88;
            // 
            // btnSava
            // 
            btnSava.BackColor = Color.FromArgb(55, 57, 93);
            btnSava.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSava.ForeColor = Color.White;
            btnSava.Location = new Point(761, 538);
            btnSava.Name = "btnSava";
            btnSava.Size = new Size(174, 47);
            btnSava.TabIndex = 89;
            btnSava.Text = "Save";
            btnSava.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 57, 93);
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(553, 538);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 47);
            btnSearch.TabIndex = 90;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(628, 259);
            Label6.Name = "Label6";
            Label6.Size = new Size(60, 21);
            Label6.TabIndex = 92;
            Label6.Text = "Price :-";
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
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(706, 259);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(295, 29);
            txtPrice.TabIndex = 104;
            // 
            // GBTest
            // 
            GBTest.Controls.Add(Label4);
            GBTest.Controls.Add(Label3);
            GBTest.Controls.Add(txtMini);
            GBTest.Controls.Add(txtMax);
            GBTest.Controls.Add(Label5);
            GBTest.Controls.Add(Label8);
            GBTest.Controls.Add(Label7);
            GBTest.Controls.Add(txtPrice);
            GBTest.Controls.Add(Label1);
            GBTest.Controls.Add(Label2);
            GBTest.Controls.Add(txtTestName);
            GBTest.Controls.Add(Label6);
            GBTest.Controls.Add(txtTestID);
            GBTest.Controls.Add(cmbSampleUnit);
            GBTest.Controls.Add(CmbSampleType);
            GBTest.Controls.Add(CmbTestType);
            GBTest.Enabled = false;
            GBTest.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBTest.Location = new Point(16, 19);
            GBTest.Name = "GBTest";
            GBTest.Size = new Size(1156, 500);
            GBTest.TabIndex = 115;
            GBTest.TabStop = false;
            GBTest.Text = "Test Data";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(583, 205);
            Label4.Name = "Label4";
            Label4.Size = new Size(105, 21);
            Label4.TabIndex = 109;
            Label4.Text = "Max Range :-";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(582, 156);
            Label3.Name = "Label3";
            Label3.Size = new Size(106, 21);
            Label3.TabIndex = 108;
            Label3.Text = "Mini Range :-";
            // 
            // txtMini
            // 
            txtMini.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMini.Location = new Point(706, 153);
            txtMini.Name = "txtMini";
            txtMini.Size = new Size(295, 29);
            txtMini.TabIndex = 107;
            // 
            // txtMax
            // 
            txtMax.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMax.Location = new Point(706, 207);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(295, 29);
            txtMax.TabIndex = 106;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 57, 93);
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(961, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 47);
            btnAdd.TabIndex = 107;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(55, 57, 93);
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(155, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 47);
            btnCancel.TabIndex = 116;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(GBTest);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnSava);
            Controls.Add(ShapeContainer1);
            Name = "Test";
            Size = new Size(1189, 613);
            GBTest.ResumeLayout(false);
            GBTest.PerformLayout();
            Load += new EventHandler(Test_Load);
            ResumeLayout(false);

        }
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape3;
        internal Label Label8;
        internal Label Label7;
        internal Label Label1;
        internal Label Label2;
        internal Label Label5;
        internal TextBox txtTestName;
        internal TextBox txtTestID;
        internal ComboBox cmbSampleUnit;
        internal ComboBox CmbSampleType;
        internal ComboBox CmbTestType;
        internal Button btnSava;
        internal Button btnSearch;
        internal Label Label6;
        internal Button btnDelete;
        internal TextBox txtPrice;
        internal GroupBox GBTest;
        internal DataGridView DataGridView1;
        internal DataGridViewTextBoxColumn Test_ID;
        internal DataGridViewTextBoxColumn Test_Name;
        internal DataGridViewTextBoxColumn Test_Type;
        internal DataGridViewTextBoxColumn Sample;
        internal DataGridViewTextBoxColumn Unit;
        internal DataGridViewTextBoxColumn Normal_value;
        internal DataGridViewTextBoxColumn Price;
        internal Button btnAdd;
        internal Button btnCancel;
        internal TextBox txtMini;
        internal TextBox txtMax;
        internal Label Label4;
        internal Label Label3;
    }
}