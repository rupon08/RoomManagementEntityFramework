namespace RoomManagementEntityFramework.Setup
{
    partial class FrmMaritalStatusMaster
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
            this.textMaritalStatusName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewMaritalStatusMaster = new System.Windows.Forms.DataGridView();
            this.ClmMaritalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMaritalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripMaritalStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaritalStatusMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMaritalStatusName
            // 
            this.textMaritalStatusName.Location = new System.Drawing.Point(126, 19);
            this.textMaritalStatusName.Name = "textMaritalStatusName";
            this.textMaritalStatusName.Size = new System.Drawing.Size(161, 20);
            this.textMaritalStatusName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marital Status Name:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(207, 65);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(126, 65);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(207, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(126, 55);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewMaritalStatusMaster
            // 
            this.dataGridViewMaritalStatusMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaritalStatusMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMaritalStatusMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaritalStatusMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmMaritalCode,
            this.ClmMaritalName});
            this.dataGridViewMaritalStatusMaster.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewMaritalStatusMaster.Name = "dataGridViewMaritalStatusMaster";
            this.dataGridViewMaritalStatusMaster.ReadOnly = true;
            this.dataGridViewMaritalStatusMaster.RowHeadersVisible = false;
            this.dataGridViewMaritalStatusMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaritalStatusMaster.Size = new System.Drawing.Size(293, 150);
            this.dataGridViewMaritalStatusMaster.TabIndex = 14;
            this.dataGridViewMaritalStatusMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaritalStatusMaster_CellClick);
            this.dataGridViewMaritalStatusMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMaritalStatusMaster_MouseDown);
            // 
            // ClmMaritalCode
            // 
            this.ClmMaritalCode.DataPropertyName = "marialCode";
            this.ClmMaritalCode.HeaderText = "Marital Code";
            this.ClmMaritalCode.Name = "ClmMaritalCode";
            this.ClmMaritalCode.ReadOnly = true;
            this.ClmMaritalCode.Visible = false;
            // 
            // ClmMaritalName
            // 
            this.ClmMaritalName.DataPropertyName = "maritalName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            this.ClmMaritalName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmMaritalName.HeaderText = "Marital Name";
            this.ClmMaritalName.Name = "ClmMaritalName";
            this.ClmMaritalName.ReadOnly = true;
            this.ClmMaritalName.Width = 200;
            // 
            // contextMenuStripMaritalStatus
            // 
            this.contextMenuStripMaritalStatus.Name = "contextMenuStripMaritalStatus";
            this.contextMenuStripMaritalStatus.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripMaritalStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripMaritalStatus_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMaritalStatusName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 104);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marital Status Entry";
            // 
            // FrmMaritalStatusMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(325, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMaritalStatusMaster);
            this.Name = "FrmMaritalStatusMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marital Status Entry Form";
            this.Load += new System.EventHandler(this.FrmMaritalStatusMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaritalStatusMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textMaritalStatusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewMaritalStatusMaster;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMaritalStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMaritalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMaritalName;
    }
}