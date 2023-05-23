using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RoomManagementEntityFramework.Setup;
using RoomManagementEntityFramework.Report;

namespace RoomManagementEntityFramework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonEntry objFrmPersonEntry = new FrmPersonEntry();
            objFrmPersonEntry.ShowDialog();
        }

        private void dailyMarketAndMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code to Show Market and Meal....
            FrmDailyMarket_Meal objFrmDailyMarket_Meal = new FrmDailyMarket_Meal();
            objFrmDailyMarket_Meal.ShowDialog();
           
       }

        private void extraExpensesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExtraExpensesDetailsEntry objFrmExtraExpensesDetailsEntry = new FrmExtraExpensesDetailsEntry();
            objFrmExtraExpensesDetailsEntry.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogIn objLogIn = new LogIn();
            objLogIn.Show();
        }

      

        private void countryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCountryMaster objfrmCountryMaster = new FrmCountryMaster();
            objfrmCountryMaster.ShowDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCityMaster objFrmCityMaster = new FrmCityMaster();
            objFrmCityMaster.ShowDialog();
        }

        private void maritalStatusMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaritalStatusMaster objFrmMaritalStatusMaster = new FrmMaritalStatusMaster();
            objFrmMaritalStatusMaster.ShowDialog();
        }

        private void professionMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessionMaster objFrmProfessionMaster = new FrmProfessionMaster();
            objFrmProfessionMaster.ShowDialog();
        }

        private void qualificationMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQualificationMaster objFrmQualificationMaster = new FrmQualificationMaster();
            objFrmQualificationMaster.ShowDialog();
        }

        private void finalCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalCalculationReportForm objFinalCalculationReportForm = new FinalCalculationReportForm();
            objFinalCalculationReportForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "LogOut Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LogIn objLogIn = new LogIn();
                objLogIn.Show();
            }
        }

        private void cityMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityImportFromExcelForm objCityImportFromExcelForm = new CityImportFromExcelForm();
            objCityImportFromExcelForm.ShowDialog();
        }

        private void extraExpensesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExtraExpensesMaster objFrmExtraExpensesMaster = new FrmExtraExpensesMaster();
            objFrmExtraExpensesMaster.ShowDialog();
        }

        private void personalIncomeAndExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalIncome_Expenses objFrmPersonalIncome_Expenses = new FrmPersonalIncome_Expenses();
            objFrmPersonalIncome_Expenses.ShowDialog();
        }

        private void personalCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalCalculationReportForm objPersonalCalculationReportForm = new PersonalCalculationReportForm();
            objPersonalCalculationReportForm.ShowDialog();
        }

        private void depositDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepositDetails objFrmDepositDetails = new FrmDepositDetails();
            objFrmDepositDetails.ShowDialog();
        }
    }
}
