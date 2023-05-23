namespace RoomManagementEntityFramework.Setup
{
    partial class FrmQualificationMaster
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textQualificationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewQualificationMaster = new System.Windows.Forms.DataGridView();
            this.contextMenuStripQualification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClmQualificationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQualificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQualificationMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(198, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(117, 67);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(198, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(117, 55);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 16;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textQualificationName
            // 
            this.textQualificationName.Location = new System.Drawing.Point(115, 19);
            this.textQualificationName.Name = "textQualificationName";
            this.textQualificationName.Size = new System.Drawing.Size(161, 20);
            this.textQualificationName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Qualification Name:";
            // 
            // dataGridViewQualificationMaster
            // 
            this.dataGridViewQualificationMaster.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQualificationMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewQualificationMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQualificationMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmQualificationCode,
            this.ClmQualificationName});
            this.dataGridViewQualificationMaster.Location = new System.Drawing.Point(9, 128);
            this.dataGridViewQualificationMaster.Name = "dataGridViewQualificationMaster";
            this.dataGridViewQualificationMaster.ReadOnly = true;
            this.dataGridViewQualificationMaster.RowHeadersVisible = false;
            this.dataGridViewQualificationMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQualificationMaster.Size = new System.Drawing.Size(303, 150);
            this.dataGridViewQualificationMaster.TabIndex = 20;
            this.dataGridViewQualificationMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQualificationMaster_CellClick);
            this.dataGridViewQualificationMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewQualificationMaster_MouseDown);
            // 
            // contextMenuStripQualification
            // 
            this.contextMenuStripQualification.Name = "contextMenuStripQualification";
            this.contextMenuStripQualification.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripQualification.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripQualification_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textQualificationName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 110);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qualification Entry";
            // 
            // ClmQualificationCode
            // 
            this.ClmQualificationCode.DataPropertyName = "qualificationCode";
            this.ClmQualificationCode.HeaderText = "Qualification Code";
            this.ClmQualificationCode.Name = "ClmQualificationCode";
            this.ClmQualificationCode.ReadOnly = true;
            this.ClmQualificationCode.Visible = false;
            // 
            // ClmQualificationName
            // 
            this.ClmQualificationName.DataPropertyName = "qualificationName";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            this.ClmQualificationName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClmQualificationName.HeaderText = "Qualification Name";
            this.ClmQualificationName.Name = "ClmQualificationName";
            this.ClmQualificationName.ReadOnly = true;
            this.ClmQualificationName.Width = 200;
            // 
            // FrmQualificationMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(336, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewQualificationMaster);
            this.Name = "FrmQualificationMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qualification Entry Form";
            this.Load += new System.EventHandler(this.FrmQualificationMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQualificationMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textQualificationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewQualificationMaster;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQualification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQualificationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmQualificationName;
    }
}