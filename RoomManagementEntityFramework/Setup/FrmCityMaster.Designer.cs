namespace RoomManagementEntityFramework.Setup
{
    partial class FrmCityMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCountryName = new System.Windows.Forms.ComboBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNewCountry = new System.Windows.Forms.Button();
            this.contextMenuStripCity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCityMaster = new System.Windows.Forms.DataGridView();
            this.ClmCityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCityMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name:";
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Location = new System.Drawing.Point(98, 19);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(161, 20);
            this.textBoxCityName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zip Code:";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(98, 48);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(161, 20);
            this.textBoxZipCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country Name:";
            // 
            // comboBoxCountryName
            // 
            this.comboBoxCountryName.FormattingEnabled = true;
            this.comboBoxCountryName.Location = new System.Drawing.Point(98, 83);
            this.comboBoxCountryName.Name = "comboBoxCountryName";
            this.comboBoxCountryName.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCountryName.TabIndex = 5;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(98, 110);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(179, 110);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(98, 119);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(179, 119);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNewCountry
            // 
            this.buttonNewCountry.Location = new System.Drawing.Point(265, 86);
            this.buttonNewCountry.Name = "buttonNewCountry";
            this.buttonNewCountry.Size = new System.Drawing.Size(87, 23);
            this.buttonNewCountry.TabIndex = 11;
            this.buttonNewCountry.Text = "New Country";
            this.buttonNewCountry.UseVisualStyleBackColor = true;
            this.buttonNewCountry.Click += new System.EventHandler(this.buttonNewCountry_Click);
            // 
            // contextMenuStripCity
            // 
            this.contextMenuStripCity.Name = "contextMenuStripCity";
            this.contextMenuStripCity.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripCity.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripCity_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCityName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNewCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxZipCode);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.comboBoxCountryName);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 156);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Entry";
            // 
            // dataGridViewCityMaster
            // 
            this.dataGridViewCityMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCityMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCityMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCityMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCityCode,
            this.ClmCityName,
            this.ClmZipCode,
            this.ClmCountryCode,
            this.ClmCountryName});
            this.dataGridViewCityMaster.Location = new System.Drawing.Point(12, 174);
            this.dataGridViewCityMaster.Name = "dataGridViewCityMaster";
            this.dataGridViewCityMaster.ReadOnly = true;
            this.dataGridViewCityMaster.RowHeadersVisible = false;
            this.dataGridViewCityMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCityMaster.Size = new System.Drawing.Size(374, 150);
            this.dataGridViewCityMaster.TabIndex = 13;
            this.dataGridViewCityMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCityMaster_CellClick_1);
            this.dataGridViewCityMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCityMaster_MouseDown_1);
            // 
            // ClmCityCode
            // 
            this.ClmCityCode.DataPropertyName = "cityCode";
            this.ClmCityCode.HeaderText = "City Code";
            this.ClmCityCode.Name = "ClmCityCode";
            this.ClmCityCode.ReadOnly = true;
            this.ClmCityCode.Visible = false;
            // 
            // ClmCityName
            // 
            this.ClmCityName.DataPropertyName = "cityName";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Tan;
            this.ClmCityName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClmCityName.HeaderText = "City Name";
            this.ClmCityName.Name = "ClmCityName";
            this.ClmCityName.ReadOnly = true;
            // 
            // ClmZipCode
            // 
            this.ClmZipCode.DataPropertyName = "zipCode";
            this.ClmZipCode.HeaderText = "Zip Code";
            this.ClmZipCode.Name = "ClmZipCode";
            this.ClmZipCode.ReadOnly = true;
            // 
            // ClmCountryCode
            // 
            this.ClmCountryCode.DataPropertyName = "countryCode";
            this.ClmCountryCode.HeaderText = "Country Code";
            this.ClmCountryCode.Name = "ClmCountryCode";
            this.ClmCountryCode.ReadOnly = true;
            this.ClmCountryCode.Visible = false;
            // 
            // ClmCountryName
            // 
            this.ClmCountryName.DataPropertyName = "countryName";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Wheat;
            this.ClmCountryName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClmCountryName.HeaderText = "Country Name";
            this.ClmCountryName.Name = "ClmCountryName";
            this.ClmCountryName.ReadOnly = true;
            this.ClmCountryName.Width = 150;
            // 
            // FrmCityMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(409, 343);
            this.Controls.Add(this.dataGridViewCityMaster);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCityMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Entry Form";
            this.Load += new System.EventHandler(this.FrmCityMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCityMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCountryName;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNewCountry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewCityMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCountryName;
    }
}