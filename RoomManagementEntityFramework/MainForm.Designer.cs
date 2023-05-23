namespace RoomManagementEntityFramework
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maritalStatusMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professionMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraExpensesMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyMarketAndMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalIncomeAndExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUser = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(840, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.countryMasterToolStripMenuItem,
            this.maritalStatusMasterToolStripMenuItem,
            this.professionMasterToolStripMenuItem,
            this.qualificationMasterToolStripMenuItem,
            this.extraExpensesMasterToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cToolStripMenuItem.Text = "City Master";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // countryMasterToolStripMenuItem
            // 
            this.countryMasterToolStripMenuItem.Name = "countryMasterToolStripMenuItem";
            this.countryMasterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.countryMasterToolStripMenuItem.Text = "Country Master";
            this.countryMasterToolStripMenuItem.Click += new System.EventHandler(this.countryMasterToolStripMenuItem_Click);
            // 
            // maritalStatusMasterToolStripMenuItem
            // 
            this.maritalStatusMasterToolStripMenuItem.Name = "maritalStatusMasterToolStripMenuItem";
            this.maritalStatusMasterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.maritalStatusMasterToolStripMenuItem.Text = "Marital Status Master";
            this.maritalStatusMasterToolStripMenuItem.Click += new System.EventHandler(this.maritalStatusMasterToolStripMenuItem_Click);
            // 
            // professionMasterToolStripMenuItem
            // 
            this.professionMasterToolStripMenuItem.Name = "professionMasterToolStripMenuItem";
            this.professionMasterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.professionMasterToolStripMenuItem.Text = "Profession Master";
            this.professionMasterToolStripMenuItem.Click += new System.EventHandler(this.professionMasterToolStripMenuItem_Click);
            // 
            // qualificationMasterToolStripMenuItem
            // 
            this.qualificationMasterToolStripMenuItem.Name = "qualificationMasterToolStripMenuItem";
            this.qualificationMasterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.qualificationMasterToolStripMenuItem.Text = "Qualification Master";
            this.qualificationMasterToolStripMenuItem.Click += new System.EventHandler(this.qualificationMasterToolStripMenuItem_Click);
            // 
            // extraExpensesMasterToolStripMenuItem
            // 
            this.extraExpensesMasterToolStripMenuItem.Name = "extraExpensesMasterToolStripMenuItem";
            this.extraExpensesMasterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.extraExpensesMasterToolStripMenuItem.Text = "Income/Expenses Master";
            this.extraExpensesMasterToolStripMenuItem.Click += new System.EventHandler(this.extraExpensesMasterToolStripMenuItem_Click);
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personInformationToolStripMenuItem,
            this.dailyMarketAndMealToolStripMenuItem,
            this.depositDetailsToolStripMenuItem,
            this.personalIncomeAndExpensesToolStripMenuItem});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // personInformationToolStripMenuItem
            // 
            this.personInformationToolStripMenuItem.Name = "personInformationToolStripMenuItem";
            this.personInformationToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.personInformationToolStripMenuItem.Text = "Person Information";
            this.personInformationToolStripMenuItem.Click += new System.EventHandler(this.personInformationToolStripMenuItem_Click);
            // 
            // dailyMarketAndMealToolStripMenuItem
            // 
            this.dailyMarketAndMealToolStripMenuItem.Name = "dailyMarketAndMealToolStripMenuItem";
            this.dailyMarketAndMealToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.dailyMarketAndMealToolStripMenuItem.Text = "Daily Market and Meal";
            this.dailyMarketAndMealToolStripMenuItem.Click += new System.EventHandler(this.dailyMarketAndMealToolStripMenuItem_Click);
            // 
            // depositDetailsToolStripMenuItem
            // 
            this.depositDetailsToolStripMenuItem.Name = "depositDetailsToolStripMenuItem";
            this.depositDetailsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.depositDetailsToolStripMenuItem.Text = "Depo Details";
            this.depositDetailsToolStripMenuItem.Click += new System.EventHandler(this.depositDetailsToolStripMenuItem_Click);
            // 
            // personalIncomeAndExpensesToolStripMenuItem
            // 
            this.personalIncomeAndExpensesToolStripMenuItem.Name = "personalIncomeAndExpensesToolStripMenuItem";
            this.personalIncomeAndExpensesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.personalIncomeAndExpensesToolStripMenuItem.Text = "Personal Income and Expenses";
            this.personalIncomeAndExpensesToolStripMenuItem.Click += new System.EventHandler(this.personalIncomeAndExpensesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalCalculationToolStripMenuItem,
            this.personalCalculationToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // finalCalculationToolStripMenuItem
            // 
            this.finalCalculationToolStripMenuItem.Name = "finalCalculationToolStripMenuItem";
            this.finalCalculationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.finalCalculationToolStripMenuItem.Text = "Meal Calculation";
            this.finalCalculationToolStripMenuItem.Click += new System.EventHandler(this.finalCalculationToolStripMenuItem_Click);
            // 
            // personalCalculationToolStripMenuItem
            // 
            this.personalCalculationToolStripMenuItem.Name = "personalCalculationToolStripMenuItem";
            this.personalCalculationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.personalCalculationToolStripMenuItem.Text = "Personal Calculation";
            this.personalCalculationToolStripMenuItem.Click += new System.EventHandler(this.personalCalculationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(344, 40);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(840, 458);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Management System-Main User Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maritalStatusMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professionMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyMarketAndMealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalCalculationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ToolStripMenuItem extraExpensesMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalIncomeAndExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositDetailsToolStripMenuItem;
    }
}