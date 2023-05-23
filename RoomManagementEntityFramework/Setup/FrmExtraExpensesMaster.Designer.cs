namespace RoomManagementEntityFramework.Setup
{
    partial class FrmExtraExpensesMaster
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.checkBoxIsExpense = new System.Windows.Forms.CheckBox();
            this.checkBoxIsUtility = new System.Windows.Forms.CheckBox();
            this.textBoxExpensesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewExtraExpenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStripExtraExpenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClmRowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmExpensesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmIsUtilities = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtraExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.checkBoxIsExpense);
            this.groupBox1.Controls.Add(this.checkBoxIsUtility);
            this.groupBox1.Controls.Add(this.textBoxExpensesName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 132);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income/Expenses Entry";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Location = new System.Drawing.Point(142, 68);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(73, 17);
            this.checkBoxIsActive.TabIndex = 28;
            this.checkBoxIsActive.Text = "Is Active?";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsExpense
            // 
            this.checkBoxIsExpense.AutoSize = true;
            this.checkBoxIsExpense.Checked = true;
            this.checkBoxIsExpense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsExpense.Location = new System.Drawing.Point(140, 45);
            this.checkBoxIsExpense.Name = "checkBoxIsExpense";
            this.checkBoxIsExpense.Size = new System.Drawing.Size(84, 17);
            this.checkBoxIsExpense.TabIndex = 27;
            this.checkBoxIsExpense.Text = "Is Expense?";
            this.checkBoxIsExpense.UseVisualStyleBackColor = true;
            this.checkBoxIsExpense.CheckedChanged += new System.EventHandler(this.checkBoxIsExpense_CheckedChanged);
            // 
            // checkBoxIsUtility
            // 
            this.checkBoxIsUtility.AutoSize = true;
            this.checkBoxIsUtility.Checked = true;
            this.checkBoxIsUtility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsUtility.Location = new System.Drawing.Point(232, 45);
            this.checkBoxIsUtility.Name = "checkBoxIsUtility";
            this.checkBoxIsUtility.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsUtility.TabIndex = 26;
            this.checkBoxIsUtility.Text = "Is Utility?";
            this.checkBoxIsUtility.UseVisualStyleBackColor = true;
            this.checkBoxIsUtility.CheckedChanged += new System.EventHandler(this.checkBoxIsUtility_CheckedChanged);
            // 
            // textBoxExpensesName
            // 
            this.textBoxExpensesName.Location = new System.Drawing.Point(139, 19);
            this.textBoxExpensesName.Name = "textBoxExpensesName";
            this.textBoxExpensesName.Size = new System.Drawing.Size(161, 20);
            this.textBoxExpensesName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Income/Expenses Name:";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(133, 92);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(214, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(214, 92);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(133, 100);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewExtraExpenses
            // 
            this.dataGridViewExtraExpenses.AllowUserToAddRows = false;
            this.dataGridViewExtraExpenses.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExtraExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExtraExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtraExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmRowID,
            this.ClmExpensesName,
            this.ClmType,
            this.ClmIsUtilities});
            this.dataGridViewExtraExpenses.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewExtraExpenses.Name = "dataGridViewExtraExpenses";
            this.dataGridViewExtraExpenses.ReadOnly = true;
            this.dataGridViewExtraExpenses.RowHeadersVisible = false;
            this.dataGridViewExtraExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExtraExpenses.Size = new System.Drawing.Size(337, 245);
            this.dataGridViewExtraExpenses.TabIndex = 24;
            this.dataGridViewExtraExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExtraExpenses_CellClick);
            this.dataGridViewExtraExpenses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewExtraExpenses_MouseDown);
            // 
            // contextMenuStripExtraExpenses
            // 
            this.contextMenuStripExtraExpenses.Name = "contextMenuStripExtraExpenses";
            this.contextMenuStripExtraExpenses.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripExtraExpenses.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripExtraExpenses_ItemClicked);
            // 
            // ClmRowID
            // 
            this.ClmRowID.DataPropertyName = "rowID";
            this.ClmRowID.HeaderText = "Row ID";
            this.ClmRowID.Name = "ClmRowID";
            this.ClmRowID.ReadOnly = true;
            this.ClmRowID.Visible = false;
            // 
            // ClmExpensesName
            // 
            this.ClmExpensesName.DataPropertyName = "ItemName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            this.ClmExpensesName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmExpensesName.HeaderText = "Name";
            this.ClmExpensesName.Name = "ClmExpensesName";
            this.ClmExpensesName.ReadOnly = true;
            this.ClmExpensesName.Width = 130;
            // 
            // ClmType
            // 
            this.ClmType.DataPropertyName = "IsExpenses";
            this.ClmType.HeaderText = "IsExpenses?";
            this.ClmType.Name = "ClmType";
            this.ClmType.ReadOnly = true;
            // 
            // ClmIsUtilities
            // 
            this.ClmIsUtilities.DataPropertyName = "IsUtilities";
            this.ClmIsUtilities.HeaderText = "IsUtilities?";
            this.ClmIsUtilities.Name = "ClmIsUtilities";
            this.ClmIsUtilities.ReadOnly = true;
            // 
            // FrmExtraExpensesMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(366, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewExtraExpenses);
            this.Name = "FrmExtraExpensesMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income/Expenses Master";
            this.Load += new System.EventHandler(this.FrmExtraExpensesMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtraExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxExpensesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewExtraExpenses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripExtraExpenses;
        private System.Windows.Forms.CheckBox checkBoxIsUtility;
        private System.Windows.Forms.CheckBox checkBoxIsExpense;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmExpensesName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmIsUtilities;
    }
}