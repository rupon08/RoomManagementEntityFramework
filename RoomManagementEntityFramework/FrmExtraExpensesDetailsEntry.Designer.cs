namespace RoomManagementEntityFramework
{
    partial class FrmExtraExpensesDetailsEntry
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExtExpDtl = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxExtExpDesc = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbExtExpItem = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.contextMenuStripExtraExpenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxPersonMarket = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtExpDtl)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExtExpDtl
            // 
            this.dgvExtExpDtl.AllowUserToAddRows = false;
            this.dgvExtExpDtl.AllowUserToDeleteRows = false;
            this.dgvExtExpDtl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExtExpDtl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExtExpDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtExpDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowID,
            this.ClmPersonID,
            this.ClmPersonName,
            this.extraItemName,
            this.expAmt,
            this.entryDate,
            this.Description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExtExpDtl.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExtExpDtl.Location = new System.Drawing.Point(12, 245);
            this.dgvExtExpDtl.Name = "dgvExtExpDtl";
            this.dgvExtExpDtl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExtExpDtl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExtExpDtl.RowHeadersVisible = false;
            this.dgvExtExpDtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtExpDtl.Size = new System.Drawing.Size(331, 150);
            this.dgvExtExpDtl.TabIndex = 11;
            this.dgvExtExpDtl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtExpDtl_CellClick);
            this.dgvExtExpDtl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvExtExpDtl_MouseDown);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.comboBoxPersonMarket);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.textBoxExtExpDesc);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.cmbExtExpItem);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.dtpDate);
            this.GroupBox1.Controls.Add(this.txtAmt);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(12, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(331, 233);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Extra Expenses Details  Entry";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Description:";
            // 
            // textBoxExtExpDesc
            // 
            this.textBoxExtExpDesc.Location = new System.Drawing.Point(117, 131);
            this.textBoxExtExpDesc.Multiline = true;
            this.textBoxExtExpDesc.Name = "textBoxExtExpDesc";
            this.textBoxExtExpDesc.Size = new System.Drawing.Size(148, 30);
            this.textBoxExtExpDesc.TabIndex = 62;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnCancel);
            this.GroupBox2.Controls.Add(this.btnUpdate);
            this.GroupBox2.Controls.Add(this.btnNew);
            this.GroupBox2.Controls.Add(this.btnSave);
            this.GroupBox2.Location = new System.Drawing.Point(15, 163);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(209, 63);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Operations";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(101, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(101, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbExtExpItem
            // 
            this.cmbExtExpItem.FormattingEnabled = true;
            this.cmbExtExpItem.Location = new System.Drawing.Point(117, 45);
            this.cmbExtExpItem.Name = "cmbExtExpItem";
            this.cmbExtExpItem.Size = new System.Drawing.Size(121, 21);
            this.cmbExtExpItem.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(2, 48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Extra Expenses  Item:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(65, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Amount:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(117, 104);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(148, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(117, 75);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(121, 20);
            this.txtAmt.TabIndex = 3;
            this.txtAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmt_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(78, 108);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(33, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Date:";
            // 
            // contextMenuStripExtraExpenses
            // 
            this.contextMenuStripExtraExpenses.Name = "contextMenuStripExtraExpenses";
            this.contextMenuStripExtraExpenses.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripExtraExpenses.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripExtraExpenses_ItemClicked);
            // 
            // comboBoxPersonMarket
            // 
            this.comboBoxPersonMarket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPersonMarket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPersonMarket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonMarket.FormattingEnabled = true;
            this.comboBoxPersonMarket.Location = new System.Drawing.Point(117, 18);
            this.comboBoxPersonMarket.Name = "comboBoxPersonMarket";
            this.comboBoxPersonMarket.Size = new System.Drawing.Size(148, 21);
            this.comboBoxPersonMarket.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Person Name:";
            // 
            // rowID
            // 
            this.rowID.DataPropertyName = "rowID";
            this.rowID.HeaderText = "Row ID";
            this.rowID.Name = "rowID";
            this.rowID.ReadOnly = true;
            this.rowID.Visible = false;
            // 
            // ClmPersonID
            // 
            this.ClmPersonID.DataPropertyName = "PersonName";
            this.ClmPersonID.HeaderText = "Person ID";
            this.ClmPersonID.Name = "ClmPersonID";
            this.ClmPersonID.ReadOnly = true;
            this.ClmPersonID.Visible = false;
            // 
            // ClmPersonName
            // 
            this.ClmPersonName.DataPropertyName = "Name";
            this.ClmPersonName.HeaderText = "Person Name";
            this.ClmPersonName.Name = "ClmPersonName";
            this.ClmPersonName.ReadOnly = true;
            // 
            // extraItemName
            // 
            this.extraItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            this.extraItemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.extraItemName.HeaderText = "Item Name";
            this.extraItemName.Name = "extraItemName";
            this.extraItemName.ReadOnly = true;
            // 
            // expAmt
            // 
            this.expAmt.DataPropertyName = "expAmt";
            this.expAmt.HeaderText = "Expenses Amount";
            this.expAmt.Name = "expAmt";
            this.expAmt.ReadOnly = true;
            this.expAmt.Width = 130;
            // 
            // entryDate
            // 
            this.entryDate.DataPropertyName = "entryDate";
            this.entryDate.HeaderText = "Entry Date";
            this.entryDate.Name = "entryDate";
            this.entryDate.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FrmExtraExpensesDetailsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(372, 401);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dgvExtExpDtl);
            this.Name = "FrmExtraExpensesDetailsEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExtraExpensesDetailsEntry";
            this.Load += new System.EventHandler(this.FrmExtraExpensesDetailsEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtExpDtl)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvExtExpDtl;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.ComboBox cmbExtExpItem;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.TextBox txtAmt;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripExtraExpenses;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxExtExpDesc;
        public System.Windows.Forms.ComboBox comboBoxPersonMarket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn expAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}