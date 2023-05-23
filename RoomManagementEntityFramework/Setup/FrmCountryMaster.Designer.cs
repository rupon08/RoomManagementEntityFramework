namespace RoomManagementEntityFramework.Setup
{
    partial class FrmCountryMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCountryMaster = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripCountry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClmCountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountryMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCountryMaster
            // 
            this.dataGridViewCountryMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCountryMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCountryMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountryMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCountryCode,
            this.ClmCountryName});
            this.dataGridViewCountryMaster.Location = new System.Drawing.Point(9, 117);
            this.dataGridViewCountryMaster.Name = "dataGridViewCountryMaster";
            this.dataGridViewCountryMaster.ReadOnly = true;
            this.dataGridViewCountryMaster.RowHeadersVisible = false;
            this.dataGridViewCountryMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountryMaster.Size = new System.Drawing.Size(283, 150);
            this.dataGridViewCountryMaster.TabIndex = 22;
            this.dataGridViewCountryMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountryMaster_CellClick);
            this.dataGridViewCountryMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCountryMaster_MouseDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(179, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(98, 67);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(179, 59);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(98, 59);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(98, 19);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(161, 20);
            this.textBoxCountryName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Country Name:";
            // 
            // contextMenuStripCountry
            // 
            this.contextMenuStripCountry.Name = "contextMenuStripCountry";
            this.contextMenuStripCountry.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripCountry.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripCountry_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCountryName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 97);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country Entry";
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            this.ClmCountryName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClmCountryName.HeaderText = "Country Name";
            this.ClmCountryName.Name = "ClmCountryName";
            this.ClmCountryName.ReadOnly = true;
            this.ClmCountryName.Width = 200;
            // 
            // FrmCountryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(319, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCountryMaster);
            this.Name = "FrmCountryMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Entry Form";
            this.Load += new System.EventHandler(this.FrmCountryMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountryMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountryMaster;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCountryName;
    }
}