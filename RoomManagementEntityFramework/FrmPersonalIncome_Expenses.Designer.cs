namespace RoomManagementEntityFramework
{
    partial class FrmPersonalIncome_Expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPersonal = new System.Windows.Forms.DataGridView();
            this.ClmRowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDailyMarket = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxIsExpense = new System.Windows.Forms.CheckBox();
            this.checkBoxIsUtility = new System.Windows.Forms.CheckBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNewPerson = new System.Windows.Forms.Button();
            this.buttonPersonalUpdate = new System.Windows.Forms.Button();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEntryDatePersonal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPersonalCancel = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonPersonalSave = new System.Windows.Forms.Button();
            this.buttonPersonalNew = new System.Windows.Forms.Button();
            this.contextMenuStripPersonal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonPreviousMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentMonth = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonal)).BeginInit();
            this.groupBoxDailyMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPersonal);
            this.groupBox1.Location = new System.Drawing.Point(11, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 253);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income && Expenses List";
            // 
            // dataGridViewPersonal
            // 
            this.dataGridViewPersonal.AllowUserToAddRows = false;
            this.dataGridViewPersonal.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmRowID,
            this.ClmPersonID,
            this.ClmPersonName,
            this.ClmItemName,
            this.ClmItemID,
            this.ClmAmount,
            this.ClmEntryDate,
            this.ClmDescription});
            this.dataGridViewPersonal.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewPersonal.Name = "dataGridViewPersonal";
            this.dataGridViewPersonal.ReadOnly = true;
            this.dataGridViewPersonal.RowHeadersVisible = false;
            this.dataGridViewPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonal.Size = new System.Drawing.Size(395, 225);
            this.dataGridViewPersonal.TabIndex = 16;
            this.dataGridViewPersonal.TabStop = false;
            this.dataGridViewPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonal_CellClick);
            this.dataGridViewPersonal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPersonal_MouseDown);
            // 
            // ClmRowID
            // 
            this.ClmRowID.DataPropertyName = "rowID";
            this.ClmRowID.HeaderText = "Row ID";
            this.ClmRowID.Name = "ClmRowID";
            this.ClmRowID.ReadOnly = true;
            this.ClmRowID.Visible = false;
            this.ClmRowID.Width = 50;
            // 
            // ClmPersonID
            // 
            this.ClmPersonID.DataPropertyName = "PersonID";
            this.ClmPersonID.HeaderText = "Person ID";
            this.ClmPersonID.Name = "ClmPersonID";
            this.ClmPersonID.ReadOnly = true;
            this.ClmPersonID.Visible = false;
            // 
            // ClmPersonName
            // 
            this.ClmPersonName.DataPropertyName = "Name";
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Tan;
            this.ClmPersonName.DefaultCellStyle = dataGridViewCellStyle22;
            this.ClmPersonName.HeaderText = "Person Name";
            this.ClmPersonName.Name = "ClmPersonName";
            this.ClmPersonName.ReadOnly = true;
            this.ClmPersonName.Width = 120;
            // 
            // ClmItemName
            // 
            this.ClmItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClmItemName.DefaultCellStyle = dataGridViewCellStyle23;
            this.ClmItemName.HeaderText = "Item Name";
            this.ClmItemName.Name = "ClmItemName";
            this.ClmItemName.ReadOnly = true;
            // 
            // ClmItemID
            // 
            this.ClmItemID.DataPropertyName = "ExtraItemID";
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
            dataGridViewCellStyle24.Format = "dd-MMM-yyyy";
            this.ClmEntryDate.DefaultCellStyle = dataGridViewCellStyle24;
            this.ClmEntryDate.HeaderText = "Entry Date";
            this.ClmEntryDate.Name = "ClmEntryDate";
            this.ClmEntryDate.ReadOnly = true;
            // 
            // ClmDescription
            // 
            this.ClmDescription.DataPropertyName = "Description";
            this.ClmDescription.HeaderText = "Description";
            this.ClmDescription.Name = "ClmDescription";
            this.ClmDescription.ReadOnly = true;
            // 
            // groupBoxDailyMarket
            // 
            this.groupBoxDailyMarket.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBoxDailyMarket.Controls.Add(this.buttonSearch);
            this.groupBoxDailyMarket.Controls.Add(this.label6);
            this.groupBoxDailyMarket.Controls.Add(this.textBoxDescription);
            this.groupBoxDailyMarket.Controls.Add(this.checkBoxIsExpense);
            this.groupBoxDailyMarket.Controls.Add(this.checkBoxIsUtility);
            this.groupBoxDailyMarket.Controls.Add(this.comboBoxItem);
            this.groupBoxDailyMarket.Controls.Add(this.label4);
            this.groupBoxDailyMarket.Controls.Add(this.buttonNewPerson);
            this.groupBoxDailyMarket.Controls.Add(this.radioButtonCurrentMonth);
            this.groupBoxDailyMarket.Controls.Add(this.radioButtonPreviousMonth);
            this.groupBoxDailyMarket.Controls.Add(this.buttonPersonalUpdate);
            this.groupBoxDailyMarket.Controls.Add(this.comboBoxPerson);
            this.groupBoxDailyMarket.Controls.Add(this.label1);
            this.groupBoxDailyMarket.Controls.Add(this.label2);
            this.groupBoxDailyMarket.Controls.Add(this.dateTimePickerEntryDatePersonal);
            this.groupBoxDailyMarket.Controls.Add(this.label3);
            this.groupBoxDailyMarket.Controls.Add(this.buttonPersonalCancel);
            this.groupBoxDailyMarket.Controls.Add(this.textBoxAmount);
            this.groupBoxDailyMarket.Controls.Add(this.buttonPersonalSave);
            this.groupBoxDailyMarket.Controls.Add(this.buttonPersonalNew);
            this.groupBoxDailyMarket.Location = new System.Drawing.Point(13, 3);
            this.groupBoxDailyMarket.Name = "groupBoxDailyMarket";
            this.groupBoxDailyMarket.Size = new System.Drawing.Size(408, 219);
            this.groupBoxDailyMarket.TabIndex = 48;
            this.groupBoxDailyMarket.TabStop = false;
            this.groupBoxDailyMarket.Text = "Income && Expenses Entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(111, 132);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(148, 30);
            this.textBoxDescription.TabIndex = 55;
            // 
            // checkBoxIsExpense
            // 
            this.checkBoxIsExpense.AutoSize = true;
            this.checkBoxIsExpense.Checked = true;
            this.checkBoxIsExpense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsExpense.Location = new System.Drawing.Point(270, 73);
            this.checkBoxIsExpense.Name = "checkBoxIsExpense";
            this.checkBoxIsExpense.Size = new System.Drawing.Size(84, 17);
            this.checkBoxIsExpense.TabIndex = 54;
            this.checkBoxIsExpense.Text = "Is Expense?";
            this.checkBoxIsExpense.UseVisualStyleBackColor = true;
            this.checkBoxIsExpense.CheckedChanged += new System.EventHandler(this.checkBoxIsExpense_CheckedChanged);
            // 
            // checkBoxIsUtility
            // 
            this.checkBoxIsUtility.AutoSize = true;
            this.checkBoxIsUtility.Location = new System.Drawing.Point(270, 50);
            this.checkBoxIsUtility.Name = "checkBoxIsUtility";
            this.checkBoxIsUtility.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsUtility.TabIndex = 53;
            this.checkBoxIsUtility.Text = "Is Utility?";
            this.checkBoxIsUtility.UseVisualStyleBackColor = true;
            this.checkBoxIsUtility.CheckedChanged += new System.EventHandler(this.checkBoxIsUtility_CheckedChanged);
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
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxExpenses_SelectedIndexChanged);
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
            // buttonPersonalUpdate
            // 
            this.buttonPersonalUpdate.BackColor = System.Drawing.Color.White;
            this.buttonPersonalUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonalUpdate.Image = global::RoomManagementEntityFramework.Properties.Resources.editS;
            this.buttonPersonalUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalUpdate.Location = new System.Drawing.Point(105, 176);
            this.buttonPersonalUpdate.Name = "buttonPersonalUpdate";
            this.buttonPersonalUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonalUpdate.TabIndex = 14;
            this.buttonPersonalUpdate.Text = "Update";
            this.buttonPersonalUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPersonalUpdate.UseVisualStyleBackColor = false;
            this.buttonPersonalUpdate.Visible = false;
            this.buttonPersonalUpdate.Click += new System.EventHandler(this.buttonPersonalUpdate_Click);
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
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Date:";
            // 
            // dateTimePickerEntryDatePersonal
            // 
            this.dateTimePickerEntryDatePersonal.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerEntryDatePersonal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEntryDatePersonal.Location = new System.Drawing.Point(111, 106);
            this.dateTimePickerEntryDatePersonal.Name = "dateTimePickerEntryDatePersonal";
            this.dateTimePickerEntryDatePersonal.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerEntryDatePersonal.TabIndex = 2;
            this.dateTimePickerEntryDatePersonal.ValueChanged += new System.EventHandler(this.dateTimePickerEntryDatePersonal_ValueChanged);
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
            // buttonPersonalCancel
            // 
            this.buttonPersonalCancel.BackColor = System.Drawing.Color.White;
            this.buttonPersonalCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonalCancel.Location = new System.Drawing.Point(183, 176);
            this.buttonPersonalCancel.Name = "buttonPersonalCancel";
            this.buttonPersonalCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonalCancel.TabIndex = 13;
            this.buttonPersonalCancel.Text = "Cancel";
            this.buttonPersonalCancel.UseVisualStyleBackColor = false;
            this.buttonPersonalCancel.Visible = false;
            this.buttonPersonalCancel.Click += new System.EventHandler(this.buttonPersonalCancel_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(111, 75);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(148, 20);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // buttonPersonalSave
            // 
            this.buttonPersonalSave.BackColor = System.Drawing.Color.White;
            this.buttonPersonalSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonalSave.Image = global::RoomManagementEntityFramework.Properties.Resources.Gnome_List_Add_48;
            this.buttonPersonalSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalSave.Location = new System.Drawing.Point(180, 170);
            this.buttonPersonalSave.Name = "buttonPersonalSave";
            this.buttonPersonalSave.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonalSave.TabIndex = 12;
            this.buttonPersonalSave.Text = "Add";
            this.buttonPersonalSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPersonalSave.UseVisualStyleBackColor = false;
            this.buttonPersonalSave.Click += new System.EventHandler(this.buttonPersonalSave_Click);
            // 
            // buttonPersonalNew
            // 
            this.buttonPersonalNew.BackColor = System.Drawing.Color.White;
            this.buttonPersonalNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonalNew.Location = new System.Drawing.Point(105, 170);
            this.buttonPersonalNew.Name = "buttonPersonalNew";
            this.buttonPersonalNew.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonalNew.TabIndex = 15;
            this.buttonPersonalNew.Text = "New";
            this.buttonPersonalNew.UseVisualStyleBackColor = false;
            this.buttonPersonalNew.Click += new System.EventHandler(this.buttonPersonalNew_Click);
            // 
            // contextMenuStripPersonal
            // 
            this.contextMenuStripPersonal.Name = "contextMenuStripPersonal";
            this.contextMenuStripPersonal.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripPersonal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripPersonal_ItemClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Total Expenses:";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(232, 489);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(96, 20);
            this.textBoxTotalAmount.TabIndex = 51;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(270, 172);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 57;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // radioButtonPreviousMonth
            // 
            this.radioButtonPreviousMonth.AutoSize = true;
            this.radioButtonPreviousMonth.Location = new System.Drawing.Point(270, 145);
            this.radioButtonPreviousMonth.Name = "radioButtonPreviousMonth";
            this.radioButtonPreviousMonth.Size = new System.Drawing.Size(99, 17);
            this.radioButtonPreviousMonth.TabIndex = 34;
            this.radioButtonPreviousMonth.Text = "Previous Month";
            this.radioButtonPreviousMonth.UseVisualStyleBackColor = true;
            this.radioButtonPreviousMonth.CheckedChanged += new System.EventHandler(this.radioButtonPreviousMonth_CheckedChanged);
            // 
            // radioButtonCurrentMonth
            // 
            this.radioButtonCurrentMonth.AutoSize = true;
            this.radioButtonCurrentMonth.Checked = true;
            this.radioButtonCurrentMonth.Location = new System.Drawing.Point(270, 122);
            this.radioButtonCurrentMonth.Name = "radioButtonCurrentMonth";
            this.radioButtonCurrentMonth.Size = new System.Drawing.Size(92, 17);
            this.radioButtonCurrentMonth.TabIndex = 33;
            this.radioButtonCurrentMonth.TabStop = true;
            this.radioButtonCurrentMonth.Text = "Current Month";
            this.radioButtonCurrentMonth.UseVisualStyleBackColor = true;
            this.radioButtonCurrentMonth.CheckedChanged += new System.EventHandler(this.radioButtonCurrentMonth_CheckedChanged);
            // 
            // FrmPersonalIncome_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(441, 524);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDailyMarket);
            this.Name = "FrmPersonalIncome_Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Income & Expenses Entry";
            this.Load += new System.EventHandler(this.FrmPersonalIncome_Expenses_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonal)).EndInit();
            this.groupBoxDailyMarket.ResumeLayout(false);
            this.groupBoxDailyMarket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPersonal;
        private System.Windows.Forms.GroupBox groupBoxDailyMarket;
        public System.Windows.Forms.Button buttonNewPerson;
        private System.Windows.Forms.Button buttonPersonalUpdate;
        public System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDatePersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPersonalCancel;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonPersonalSave;
        private System.Windows.Forms.Button buttonPersonalNew;
        public System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPersonal;
        private System.Windows.Forms.CheckBox checkBoxIsUtility;
        private System.Windows.Forms.CheckBox checkBoxIsExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescription;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonCurrentMonth;
        private System.Windows.Forms.RadioButton radioButtonPreviousMonth;
    }
}