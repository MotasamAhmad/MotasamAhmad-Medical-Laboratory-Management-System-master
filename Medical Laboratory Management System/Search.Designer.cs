using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Search : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            TextBox2 = new TextBox();
            TextBox2.TextChanged += new EventHandler(TextBox2_TextChanged);
            Label7 = new Label();
            _DGVSearch = new DataGridView();
            _DGVSearch.CellContentClick += new DataGridViewCellEventHandler(DGVSearch_CellContentClick);
            btnok = new Button();
            btnok.Click += new EventHandler(btnresult_Click);
            btncancel = new Button();
            btncancel.Click += new EventHandler(Button1_Click);
            ((System.ComponentModel.ISupportInitialize)_DGVSearch).BeginInit();
            SuspendLayout();
            // 
            // TextBox2
            // 
            resources.ApplyResources(TextBox2, "TextBox2");
            TextBox2.Name = "TextBox2";
            // 
            // Label7
            // 
            resources.ApplyResources(Label7, "Label7");
            Label7.Name = "Label7";
            // 
            // DGVSearch
            // 
            _DGVSearch.AllowUserToAddRows = false;
            resources.ApplyResources(_DGVSearch, "DGVSearch");
            _DGVSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGVSearch.Name = "_DGVSearch";
            _DGVSearch.ReadOnly = true;
            // 
            // btnok
            // 
            btnok.BackColor = Color.FromArgb(55, 57, 93);
            resources.ApplyResources(btnok, "btnok");
            btnok.ForeColor = Color.White;
            btnok.Name = "btnok";
            btnok.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.FromArgb(55, 57, 93);
            resources.ApplyResources(btncancel, "btncancel");
            btncancel.ForeColor = Color.White;
            btncancel.Name = "btncancel";
            btncancel.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btncancel);
            Controls.Add(btnok);
            Controls.Add(Label7);
            Controls.Add(_DGVSearch);
            Controls.Add(TextBox2);
            Name = "Search";
            ((System.ComponentModel.ISupportInitialize)_DGVSearch).EndInit();
            Load += new EventHandler(Search_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TextBox2;
        internal Label Label7;
        internal Button btnok;
        internal Button btncancel;
        private DataGridView _DGVSearch;

        public virtual DataGridView DGVSearch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGVSearch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGVSearch != null)
                {
                    _DGVSearch.CellContentClick -= DGVSearch_CellContentClick;
                }

                _DGVSearch = value;
                if (_DGVSearch != null)
                {
                    _DGVSearch.CellContentClick += DGVSearch_CellContentClick;
                }
            }
        }
    }
}