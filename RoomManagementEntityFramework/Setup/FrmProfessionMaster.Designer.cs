namespace RoomManagementEntityFramework.Setup
{
    partial class FrmProfessionMaster
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textProfessionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProfessionMaster = new System.Windows.Forms.DataGridView();
            this.ClmProfessionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProfessionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripProfession = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessionMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(199, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(118, 66);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(199, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(118, 55);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 22;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textProfessionName
            // 
            this.textProfessionName.Location = new System.Drawing.Point(111, 19);
            this.textProfessionName.Name = "textProfessionName";
            this.textProfessionName.Size = new System.Drawing.Size(161, 20);
            this.textProfessionName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Profession Name:";
            // 
            // dataGridViewProfessionMaster
            // 
            this.dataGridViewProfessionMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfessionMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfessionMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessionMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmProfessionCode,
            this.ClmProfessionName});
            this.dataGridViewProfessionMaster.Location = new System.Drawing.Point(13, 128);
            this.dataGridViewProfessionMaster.Name = "dataGridViewProfessionMaster";
            this.dataGridViewProfessionMaster.ReadOnly = true;
            this.dataGridViewProfessionMaster.RowHeadersVisible = false;
            this.dataGridViewProfessionMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProfessionMaster.Size = new System.Drawing.Size(297, 150);
            this.dataGridViewProfessionMaster.TabIndex = 26;
            this.dataGridViewProfessionMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewProfessionMaster_MouseDown);
            // 
            // ClmProfessionCode
            // 
            this.ClmProfessionCode.DataPropertyName = "professionCode";
            this.ClmProfessionCode.HeaderText = "Profession Code";
            this.ClmProfessionCode.Name = "ClmProfessionCode";
            this.ClmProfessionCode.ReadOnly = true;
            this.ClmProfessionCode.Visible = false;
            // 
            // ClmProfessionName
            // 
            this.ClmProfessionName.DataPropertyName = "professionName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            this.ClmProfessionName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmProfessionName.HeaderText = "Profession Name";
            this.ClmProfessionName.Name = "ClmProfessionName";
            this.ClmProfessionName.ReadOnly = true;
            this.ClmProfessionName.Width = 250;
            // 
            // contextMenuStripProfession
            // 
            this.contextMenuStripProfession.Name = "contextMenuStripProfession";
            this.contextMenuStripProfession.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripProfession.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripProfession_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textProfessionName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 105);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profession Entry";
            // 
            // FrmProfessionMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(337, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProfessionMaster);
            this.Name = "FrmProfessionMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profession Entry Form";
            this.Load += new System.EventHandler(this.FrmProfessionMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessionMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textProfessionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProfessionMaster;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProfession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProfessionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProfessionName;
    }
}