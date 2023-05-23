namespace RoomManagementEntityFramework
{
    partial class FrmMultipleDateEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerEntryDateMeal = new System.Windows.Forms.DateTimePicker();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridViewMeal = new System.Windows.Forms.DataGridView();
            this.ClmPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMealNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmMealRowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMealPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMealPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMealEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Entry Date:";
            // 
            // dateTimePickerEntryDateMeal
            // 
            this.dateTimePickerEntryDateMeal.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerEntryDateMeal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEntryDateMeal.Location = new System.Drawing.Point(88, 30);
            this.dateTimePickerEntryDateMeal.Name = "dateTimePickerEntryDateMeal";
            this.dateTimePickerEntryDateMeal.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerEntryDateMeal.TabIndex = 18;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.White;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(282, 30);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 34;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dataGridViewMeal
            // 
            this.dataGridViewMeal.AllowUserToAddRows = false;
            this.dataGridViewMeal.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMeal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmPersonID,
            this.ClmPersonName,
            this.ClmMealNo,
            this.ClmEntryDate});
            this.dataGridViewMeal.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewMeal.Name = "dataGridViewMeal";
            this.dataGridViewMeal.RowHeadersVisible = false;
            this.dataGridViewMeal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMeal.Size = new System.Drawing.Size(346, 174);
            this.dataGridViewMeal.TabIndex = 35;
            this.dataGridViewMeal.TabStop = false;
            this.dataGridViewMeal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeal_CellValueChanged);
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
            this.ClmPersonName.DataPropertyName = "PersonName";
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Tan;
            this.ClmPersonName.DefaultCellStyle = dataGridViewCellStyle23;
            this.ClmPersonName.HeaderText = "Person Name";
            this.ClmPersonName.Name = "ClmPersonName";
            this.ClmPersonName.ReadOnly = true;
            this.ClmPersonName.Width = 120;
            // 
            // ClmMealNo
            // 
            this.ClmMealNo.DataPropertyName = "MealNo";
            this.ClmMealNo.HeaderText = "Meal No";
            this.ClmMealNo.Name = "ClmMealNo";
            // 
            // ClmEntryDate
            // 
            this.ClmEntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClmEntryDate.DefaultCellStyle = dataGridViewCellStyle24;
            this.ClmEntryDate.HeaderText = "Entry Date";
            this.ClmEntryDate.Name = "ClmEntryDate";
            this.ClmEntryDate.ReadOnly = true;
            this.ClmEntryDate.Width = 120;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewMeal);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Location = new System.Drawing.Point(10, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 235);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Multiple Date Entry List";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(280, 199);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerEntryDateMeal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonShow);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 65);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutiple Date Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 195);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmMealRowID,
            this.ClmMealPersonID,
            this.ClmMealPersonName,
            this.dataGridViewTextBoxColumn1,
            this.ClmMealEntryDate});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(344, 167);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.TabStop = false;
            // 
            // ClmMealRowID
            // 
            this.ClmMealRowID.DataPropertyName = "rowID";
            this.ClmMealRowID.HeaderText = "Row ID";
            this.ClmMealRowID.Name = "ClmMealRowID";
            this.ClmMealRowID.ReadOnly = true;
            this.ClmMealRowID.Visible = false;
            this.ClmMealRowID.Width = 50;
            // 
            // ClmMealPersonID
            // 
            this.ClmMealPersonID.DataPropertyName = "PersonID";
            this.ClmMealPersonID.HeaderText = "Person ID";
            this.ClmMealPersonID.Name = "ClmMealPersonID";
            this.ClmMealPersonID.ReadOnly = true;
            this.ClmMealPersonID.Visible = false;
            this.ClmMealPersonID.Width = 80;
            // 
            // ClmMealPersonName
            // 
            this.ClmMealPersonName.DataPropertyName = "Name";
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Tan;
            this.ClmMealPersonName.DefaultCellStyle = dataGridViewCellStyle26;
            this.ClmMealPersonName.HeaderText = "Person Name";
            this.ClmMealPersonName.Name = "ClmMealPersonName";
            this.ClmMealPersonName.ReadOnly = true;
            this.ClmMealPersonName.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MealNo";
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.SpringGreen;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn1.HeaderText = "Meal No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ClmMealEntryDate
            // 
            this.ClmMealEntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle28.Format = "dd-MMM-yyyy";
            this.ClmMealEntryDate.DefaultCellStyle = dataGridViewCellStyle28;
            this.ClmMealEntryDate.HeaderText = "Entry Date";
            this.ClmMealEntryDate.Name = "ClmMealEntryDate";
            this.ClmMealEntryDate.ReadOnly = true;
            // 
            // FrmMultipleDateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(484, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmMultipleDateEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Date Entry";
            this.Load += new System.EventHandler(this.FrmMultipleDateEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDateMeal;
        public System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridViewMeal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMealRowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMealPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMealPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMealEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMealNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEntryDate;
    }
}