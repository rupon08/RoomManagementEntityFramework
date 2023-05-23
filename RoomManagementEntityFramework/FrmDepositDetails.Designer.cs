namespace RoomManagementEntityFramework
{
    partial class FrmDepositDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDailyMarket = new System.Windows.Forms.GroupBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRemaining = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotYear = new System.Windows.Forms.TextBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNewPerson = new System.Windows.Forms.Button();
            this.buttonDepositUpdate = new System.Windows.Forms.Button();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEntryDateDeposit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDepositCancel = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonDepositSave = new System.Windows.Forms.Button();
            this.buttonDepositNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDeposit = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDeposit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClmRowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDailyMarket.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDailyMarket
            // 
            this.groupBoxDailyMarket.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBoxDailyMarket.Controls.Add(this.checkBoxAll);
            this.groupBoxDailyMarket.Controls.Add(this.textBoxTotalAmount);
            this.groupBoxDailyMarket.Controls.Add(this.label6);
            this.groupBoxDailyMarket.Controls.Add(this.textBoxRemaining);
            this.groupBoxDailyMarket.Controls.Add(this.label5);
            this.groupBoxDailyMarket.Controls.Add(this.textBoxTotYear);
            this.groupBoxDailyMarket.Controls.Add(this.comboBoxItem);
            this.groupBoxDailyMarket.Controls.Add(this.label4);
            this.groupBoxDailyMarket.Controls.Add(this.buttonNewPerson);
            this.groupBoxDailyMarket.Controls.Add(this.buttonDepositUpdate);
            this.groupBoxDailyMarket.Controls.Add(this.comboBoxPerson);
            this.groupBoxDailyMarket.Controls.Add(this.label1);
            this.groupBoxDailyMarket.Controls.Add(this.label2);
            this.groupBoxDailyMarket.Controls.Add(this.dateTimePickerEntryDateDeposit);
            this.groupBoxDailyMarket.Controls.Add(this.label3);
            this.groupBoxDailyMarket.Controls.Add(this.buttonDepositCancel);
            this.groupBoxDailyMarket.Controls.Add(this.textBoxAmount);
            this.groupBoxDailyMarket.Controls.Add(this.buttonDepositSave);
            this.groupBoxDailyMarket.Controls.Add(this.buttonDepositNew);
            this.groupBoxDailyMarket.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDailyMarket.Name = "groupBoxDailyMarket";
            this.groupBoxDailyMarket.Size = new System.Drawing.Size(417, 188);
            this.groupBoxDailyMarket.TabIndex = 49;
            this.groupBoxDailyMarket.TabStop = false;
            this.groupBoxDailyMarket.Text = "Deposit Entry";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(270, 101);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(42, 17);
            this.checkBoxAll.TabIndex = 59;
            this.checkBoxAll.Text = "Tot";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(332, 98);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(75, 20);
            this.textBoxTotalAmount.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Remaining:";
            // 
            // textBoxRemaining
            // 
            this.textBoxRemaining.Location = new System.Drawing.Point(332, 72);
            this.textBoxRemaining.Name = "textBoxRemaining";
            this.textBoxRemaining.Size = new System.Drawing.Size(75, 20);
            this.textBoxRemaining.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Total Year:";
            // 
            // textBoxTotYear
            // 
            this.textBoxTotYear.Location = new System.Drawing.Point(332, 46);
            this.textBoxTotYear.Name = "textBoxTotYear";
            this.textBoxTotYear.Size = new System.Drawing.Size(75, 20);
            this.textBoxTotYear.TabIndex = 55;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(111, 46);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(148, 21);
            this.comboBoxItem.TabIndex = 51;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Item Name:";
            // 
            // buttonNewPerson
            // 
            this.buttonNewPerson.Location = new System.Drawing.Point(270, 19);
            this.buttonNewPerson.Name = "buttonNewPerson";
            this.buttonNewPerson.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPerson.TabIndex = 33;
            this.buttonNewPerson.Text = "New Person";
            this.buttonNewPerson.UseVisualStyleBackColor = true;
            // 
            // buttonDepositUpdate
            // 
            this.buttonDepositUpdate.BackColor = System.Drawing.Color.White;
            this.buttonDepositUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositUpdate.Image = global::RoomManagementEntityFramework.Properties.Resources.editS;
            this.buttonDepositUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepositUpdate.Location = new System.Drawing.Point(106, 152);
            this.buttonDepositUpdate.Name = "buttonDepositUpdate";
            this.buttonDepositUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositUpdate.TabIndex = 14;
            this.buttonDepositUpdate.Text = "Update";
            this.buttonDepositUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDepositUpdate.UseVisualStyleBackColor = false;
            this.buttonDepositUpdate.Visible = false;
            this.buttonDepositUpdate.Click += new System.EventHandler(this.buttonDepositUpdate_Click);
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(111, 20);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(148, 21);
            this.comboBoxPerson.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Date:";
            // 
            // dateTimePickerEntryDateDeposit
            // 
            this.dateTimePickerEntryDateDeposit.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerEntryDateDeposit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEntryDateDeposit.Location = new System.Drawing.Point(112, 106);
            this.dateTimePickerEntryDateDeposit.Name = "dateTimePickerEntryDateDeposit";
            this.dateTimePickerEntryDateDeposit.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerEntryDateDeposit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // buttonDepositCancel
            // 
            this.buttonDepositCancel.BackColor = System.Drawing.Color.White;
            this.buttonDepositCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositCancel.Location = new System.Drawing.Point(184, 152);
            this.buttonDepositCancel.Name = "buttonDepositCancel";
            this.buttonDepositCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositCancel.TabIndex = 13;
            this.buttonDepositCancel.Text = "Cancel";
            this.buttonDepositCancel.UseVisualStyleBackColor = false;
            this.buttonDepositCancel.Visible = false;
            this.buttonDepositCancel.Click += new System.EventHandler(this.buttonDepositCancel_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(111, 75);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(148, 20);
            this.textBoxAmount.TabIndex = 1;
            // 
            // buttonDepositSave
            // 
            this.buttonDepositSave.BackColor = System.Drawing.Color.White;
            this.buttonDepositSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositSave.Image = global::RoomManagementEntityFramework.Properties.Resources.Gnome_List_Add_48;
            this.buttonDepositSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepositSave.Location = new System.Drawing.Point(181, 146);
            this.buttonDepositSave.Name = "buttonDepositSave";
            this.buttonDepositSave.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositSave.TabIndex = 12;
            this.buttonDepositSave.Text = "Add";
            this.buttonDepositSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDepositSave.UseVisualStyleBackColor = false;
            this.buttonDepositSave.Click += new System.EventHandler(this.buttonDepositSave_Click);
            // 
            // buttonDepositNew
            // 
            this.buttonDepositNew.BackColor = System.Drawing.Color.White;
            this.buttonDepositNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositNew.Location = new System.Drawing.Point(106, 146);
            this.buttonDepositNew.Name = "buttonDepositNew";
            this.buttonDepositNew.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositNew.TabIndex = 15;
            this.buttonDepositNew.Text = "New";
            this.buttonDepositNew.UseVisualStyleBackColor = false;
            this.buttonDepositNew.Click += new System.EventHandler(this.buttonDepositNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDeposit);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 253);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit Entry List";
            // 
            // dataGridViewDeposit
            // 
            this.dataGridViewDeposit.AllowUserToAddRows = false;
            this.dataGridViewDeposit.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeposit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmRowID,
            this.ClmItemName,
            this.ClmItemID,
            this.ClmAmount,
            this.ClmEntryDate});
            this.dataGridViewDeposit.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewDeposit.Name = "dataGridViewDeposit";
            this.dataGridViewDeposit.ReadOnly = true;
            this.dataGridViewDeposit.RowHeadersVisible = false;
            this.dataGridViewDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeposit.Size = new System.Drawing.Size(406, 225);
            this.dataGridViewDeposit.TabIndex = 16;
            this.dataGridViewDeposit.TabStop = false;
            this.dataGridViewDeposit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeposit_CellClick);
            this.dataGridViewDeposit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDeposit_MouseDown);
            // 
            // contextMenuStripDeposit
            // 
            this.contextMenuStripDeposit.Name = "contextMenuStripDeposit";
            this.contextMenuStripDeposit.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripDeposit.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripDeposit_ItemClicked);
            // 
            // ClmRowID
            // 
            this.ClmRowID.DataPropertyName = "rowID";
            this.ClmRowID.HeaderText = "Row ID";
            this.ClmRowID.Name = "ClmRowID";
            this.ClmRowID.ReadOnly = true;
            this.ClmRowID.Visible = false;
            // 
            // ClmItemName
            // 
            this.ClmItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClmItemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmItemName.HeaderText = "Item Name";
            this.ClmItemName.Name = "ClmItemName";
            this.ClmItemName.ReadOnly = true;
            this.ClmItemName.Width = 200;
            // 
            // ClmItemID
            // 
            this.ClmItemID.DataPropertyName = "ItemID";
            this.ClmItemID.HeaderText = "Item ID";
            this.ClmItemID.Name = "ClmItemID";
            this.ClmItemID.ReadOnly = true;
            this.ClmItemID.Visible = false;
            // 
            // ClmAmount
            // 
            this.ClmAmount.DataPropertyName = "Amount";
            this.ClmAmount.HeaderText = "Amount";
            this.ClmAmount.Name = "ClmAmount";
            this.ClmAmount.ReadOnly = true;
            this.ClmAmount.Width = 70;
            // 
            // ClmEntryDate
            // 
            this.ClmEntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle3.Format = "dd-MMM-yyyy";
            this.ClmEntryDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClmEntryDate.HeaderText = "Entry Date";
            this.ClmEntryDate.Name = "ClmEntryDate";
            this.ClmEntryDate.ReadOnly = true;
            this.ClmEntryDate.Width = 120;
            // 
            // FrmDepositDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDailyMarket);
            this.Name = "FrmDepositDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Details Entry";
            this.Load += new System.EventHandler(this.FrmDepositDetails_Load);
            this.groupBoxDailyMarket.ResumeLayout(false);
            this.groupBoxDailyMarket.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDailyMarket;
        public System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonNewPerson;
        private System.Windows.Forms.Button buttonDepositUpdate;
        public System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDateDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDepositCancel;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonDepositSave;
        private System.Windows.Forms.Button buttonDepositNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRemaining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDeposit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDeposit;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEntryDate;
    }
}