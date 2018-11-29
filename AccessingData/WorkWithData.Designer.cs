namespace AccessingData
{
    partial class WorkWithData
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
            this.oleDbDataSetButton = new System.Windows.Forms.Button();
            this.dataTableButton = new System.Windows.Forms.Button();
            this.pgeListBox = new System.Windows.Forms.TabPage();
            this.demoList = new System.Windows.Forms.ListBox();
            this.sqlDataReaderButton = new System.Windows.Forms.Button();
            this.sqlDataTableButton = new System.Windows.Forms.Button();
            this.pgeGrid = new System.Windows.Forms.TabPage();
            this.demoGrid = new System.Windows.Forms.DataGridView();
            this.tabDemo = new System.Windows.Forms.TabControl();
            this.pgeListBox.SuspendLayout();
            this.pgeGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demoGrid)).BeginInit();
            this.tabDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // oleDbDataSetButton
            // 
            this.oleDbDataSetButton.Location = new System.Drawing.Point(12, 57);
            this.oleDbDataSetButton.Name = "oleDbDataSetButton";
            this.oleDbDataSetButton.Size = new System.Drawing.Size(160, 28);
            this.oleDbDataSetButton.TabIndex = 20;
            this.oleDbDataSetButton.Text = "Data Set";
            this.oleDbDataSetButton.Click += new System.EventHandler(this.oleDbDataSetButton_Click);
            // 
            // dataTableButton
            // 
            this.dataTableButton.Location = new System.Drawing.Point(12, 128);
            this.dataTableButton.Name = "dataTableButton";
            this.dataTableButton.Size = new System.Drawing.Size(160, 28);
            this.dataTableButton.TabIndex = 18;
            this.dataTableButton.Text = "Create DataTable";
            this.dataTableButton.Click += new System.EventHandler(this.dataTableButton_Click);
            // 
            // pgeListBox
            // 
            this.pgeListBox.Controls.Add(this.demoList);
            this.pgeListBox.Location = new System.Drawing.Point(4, 22);
            this.pgeListBox.Name = "pgeListBox";
            this.pgeListBox.Size = new System.Drawing.Size(315, 157);
            this.pgeListBox.TabIndex = 0;
            this.pgeListBox.Text = "ListBox";
            this.pgeListBox.UseVisualStyleBackColor = true;
            // 
            // demoList
            // 
            this.demoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demoList.IntegralHeight = false;
            this.demoList.Location = new System.Drawing.Point(0, 0);
            this.demoList.Name = "demoList";
            this.demoList.Size = new System.Drawing.Size(315, 157);
            this.demoList.TabIndex = 0;
            // 
            // sqlDataReaderButton
            // 
            this.sqlDataReaderButton.Location = new System.Drawing.Point(12, 23);
            this.sqlDataReaderButton.Name = "sqlDataReaderButton";
            this.sqlDataReaderButton.Size = new System.Drawing.Size(160, 28);
            this.sqlDataReaderButton.TabIndex = 19;
            this.sqlDataReaderButton.Text = "Data Reader";
            this.sqlDataReaderButton.Click += new System.EventHandler(this.sqlDataReaderButton_Click);
            // 
            // sqlDataTableButton
            // 
            this.sqlDataTableButton.Location = new System.Drawing.Point(12, 94);
            this.sqlDataTableButton.Name = "sqlDataTableButton";
            this.sqlDataTableButton.Size = new System.Drawing.Size(160, 28);
            this.sqlDataTableButton.TabIndex = 21;
            this.sqlDataTableButton.Text = "Data Table";
            this.sqlDataTableButton.Click += new System.EventHandler(this.sqlDataSetButton_Click);
            // 
            // pgeGrid
            // 
            this.pgeGrid.Controls.Add(this.demoGrid);
            this.pgeGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgeGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pgeGrid.Location = new System.Drawing.Point(4, 22);
            this.pgeGrid.Name = "pgeGrid";
            this.pgeGrid.Size = new System.Drawing.Size(315, 157);
            this.pgeGrid.TabIndex = 1;
            this.pgeGrid.Text = "DataGridView";
            this.pgeGrid.UseVisualStyleBackColor = true;
            // 
            // demoGrid
            // 
            this.demoGrid.AllowUserToAddRows = false;
            this.demoGrid.AllowUserToDeleteRows = false;
            this.demoGrid.AllowUserToResizeRows = false;
            this.demoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.demoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demoGrid.Location = new System.Drawing.Point(0, 0);
            this.demoGrid.MultiSelect = false;
            this.demoGrid.Name = "demoGrid";
            this.demoGrid.ReadOnly = true;
            this.demoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.demoGrid.Size = new System.Drawing.Size(315, 157);
            this.demoGrid.TabIndex = 0;
            // 
            // tabDemo
            // 
            this.tabDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDemo.Controls.Add(this.pgeListBox);
            this.tabDemo.Controls.Add(this.pgeGrid);
            this.tabDemo.Location = new System.Drawing.Point(195, 23);
            this.tabDemo.Name = "tabDemo";
            this.tabDemo.SelectedIndex = 0;
            this.tabDemo.Size = new System.Drawing.Size(323, 183);
            this.tabDemo.TabIndex = 22;
            // 
            // WorkWithData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 331);
            this.Controls.Add(this.oleDbDataSetButton);
            this.Controls.Add(this.dataTableButton);
            this.Controls.Add(this.sqlDataReaderButton);
            this.Controls.Add(this.sqlDataTableButton);
            this.Controls.Add(this.tabDemo);
            this.Name = "WorkWithData";
            this.Text = "Form1";
            this.pgeListBox.ResumeLayout(false);
            this.pgeGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.demoGrid)).EndInit();
            this.tabDemo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button oleDbDataSetButton;
        internal System.Windows.Forms.Button dataTableButton;
        internal System.Windows.Forms.TabPage pgeListBox;
        internal System.Windows.Forms.ListBox demoList;
        internal System.Windows.Forms.Button sqlDataReaderButton;
        internal System.Windows.Forms.Button sqlDataTableButton;
        internal System.Windows.Forms.TabPage pgeGrid;
        internal System.Windows.Forms.DataGridView demoGrid;
        internal System.Windows.Forms.TabControl tabDemo;
    }
}

