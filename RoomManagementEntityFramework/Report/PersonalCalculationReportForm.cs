using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RoomData;
using RoomService;
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace RoomManagementEntityFramework.Report
{
    public partial class PersonalCalculationReportForm : Form
    {
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        List<PersonalFinalCalculation> lstPersonalFinalCalculationList = new List<PersonalFinalCalculation>();
        Qry_PersonalIncomeExpensesEntryService objQry_PersonalIncomeExpensesEntryService = new Qry_PersonalIncomeExpensesEntryService();
        DateTime fromDate;
        DateTime toDate;
        Tbl_extraExpensesMstService objTbl_extraExpensesMstService = new Tbl_extraExpensesMstService();
        public PersonalCalculationReportForm()
        {
            InitializeComponent();
        }

        private void PersonalCalculationReportForm_Load(object sender, EventArgs e)
        {
            LoadAllPerson();
            LoadExtraExpensesMaster();
        }
        private void LoadAllPerson()
        {
            try
            {
                List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList = new List<Tbl_PersonDetailsEntry>();
                lstPersonDetailEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true && x.IsPersonalIncomeExpenses == true).ToList();
                if (lstPersonDetailEntryList.Count > 0)
                {
                    Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry = new Tbl_PersonDetailsEntry();
                    objTbl_PersonDetailsEntry.rowID = 0;
                    objTbl_PersonDetailsEntry.Name = "Select Person";
                    lstPersonDetailEntryList.Add(objTbl_PersonDetailsEntry);
                    lstPersonDetailEntryList = lstPersonDetailEntryList.OrderBy(x => x.rowID).ToList();
                    //This Code is not working for selected value in ComboBox.....
                    //comboBoxPersonMarket.DataSource = null;
                    //comboBoxPersonMarket.DisplayMember = "Name";
                    //comboBoxPersonMarket.ValueMember = "rowID";
                    //comboBoxPersonMarket.DataSource = lstPersonDetailEntryList;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("rowID");
                    dt.Columns.Add("Name");
                    foreach (Tbl_PersonDetailsEntry objPerson in lstPersonDetailEntryList)
                    {
                        dt.Rows.Add(objPerson.rowID, objPerson.Name);
                    }
                    comboBoxPerson.ValueMember = dt.Columns[0].ColumnName;
                    comboBoxPerson.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxPerson.DataSource = dt;

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

            if (comboBoxPerson.SelectedIndex == 0)
            {
                MessageBox.Show("Select a Person");
                return;
            }
            if (checkBoxAllItem.Checked==false && comboBoxItem.SelectedIndex==0)
            {
                MessageBox.Show("Select an Item");
                return;
            }
            FinalCalculation();
            this.buttonShow.Enabled = false;
            this.progressBar1.Visible = true;
            backgroundWorkerReport.RunWorkerAsync();
        }
        private void LoadExtraExpensesMaster()
        {
            try
            {
                List<Tbl_ExpensesMst> lstExtraExpensesMasterList = new List<Tbl_ExpensesMst>();
                //Coding for Utility Checked....
                if (checkBoxIsUtility.Checked)
                {

                    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsUtilities == true && x.IsExpenses == true && x.IsActive == true).ToList();
                }
                else
                {
                    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsUtilities == false && x.IsActive == true).ToList();
                }
                //Coding for Expense Checked....
                //if (checkBoxIsExpense.Checked)
                //{
                //    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsExpenses == true).ToList();
                //}
                //else
                //{
                //    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsExpenses == false).ToList();
                //}
                //Coding for Utility and Expense Checked....
                //if (checkBoxIsUtility.Checked && checkBoxIsExpense.Checked)
                //{
                //    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsExpenses == true && x.IsUtilities == true).ToList();
                //}
                //else
                //{
                //    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsExpenses == false && x.IsUtilities == false).ToList();
                //}

                if (lstExtraExpensesMasterList.Count > 0)
                {
                    Tbl_ExpensesMst objTbl_ExpensesMst = new Tbl_ExpensesMst();
                    objTbl_ExpensesMst.rowID = 0;
                    objTbl_ExpensesMst.ItemName = "Select Extra Item";
                    lstExtraExpensesMasterList.Add(objTbl_ExpensesMst);
                    lstExtraExpensesMasterList = lstExtraExpensesMasterList.OrderBy(x => x.rowID).ToList();
                    //cmbExtExpItem.DataSource = null;
                    //cmbExtExpItem.DisplayMember = "extraItemName";
                    //cmbExtExpItem.ValueMember = "rowID";
                    //cmbExtExpItem.DataSource = lstExtraExpensesMasterList;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("rowID");
                    dt.Columns.Add("extraItemName");
                    dt.Columns.Add("IsExpenses");
                    dt.Columns.Add("IsUtilities");
                    foreach (Tbl_ExpensesMst objExtraExpenses in lstExtraExpensesMasterList)
                    {
                        dt.Rows.Add(objExtraExpenses.rowID, objExtraExpenses.ItemName, objExtraExpenses.IsExpenses, objExtraExpenses.IsUtilities);
                    }
                    comboBoxItem.ValueMember = dt.Columns[0].ColumnName;
                    comboBoxItem.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxItem.DataSource = dt;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FinalCalculation()
        {
             lstPersonalFinalCalculationList.Clear();

            /*
            //Calculation for Total Personal Income Calculation....
            List<Qry_PersonalIncomeExpensesEntry> lstQry_PersonalEntryIncomeList = new List<Qry_PersonalIncomeExpensesEntry>();

            //for Bringing All Item....
            if (checkBoxAllItem.Checked == true)
            {

                lstQry_PersonalEntryIncomeList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
                   && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date
                   && x.IsExpenses == false
                   && x.PersonID == Convert.ToInt32(comboBoxPerson.SelectedValue)).ToList();
            }
            else 
            {

                lstQry_PersonalEntryIncomeList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
                   && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date
                   && x.IsExpenses == false
                   && x.PersonID == Convert.ToInt32(comboBoxPerson.SelectedValue)
                   && x.ExtraItemID==Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
            }

            
            if (lstQry_PersonalEntryIncomeList.Count > 0)
            {

                for (int i = 0; i < lstQry_PersonalEntryIncomeList.Count; i++)
                {
                    //totalIncome += Convert.ToDouble(lstQry_PersonalEntryIncomeList[i].Amount);
                }
            }
            */

            //Calculation for Total Expenses Calculation....
            List<Qry_PersonalIncomeExpensesEntry> lstQry_PersonalExpensesList = new List<Qry_PersonalIncomeExpensesEntry>();

             //for Bringing All Item....
            if (checkBoxAllItem.Checked == true)
            {
                lstQry_PersonalExpensesList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
              && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date
              && x.IsExpenses == true
              && x.PersonID == Convert.ToInt32(comboBoxPerson.SelectedValue)).ToList();
            }
            else
            {
                lstQry_PersonalExpensesList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
              && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date
              && x.IsExpenses == true
              && x.PersonID == Convert.ToInt32(comboBoxPerson.SelectedValue)
              && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();

            }
           
            if (lstQry_PersonalExpensesList.Count > 0)
            {

                for (int i = 0; i < lstQry_PersonalExpensesList.Count; i++)
                {
                    PersonalFinalCalculation objPersonalFinalCalculation = new PersonalFinalCalculation();
                    objPersonalFinalCalculation.PersonName = comboBoxPerson.Text;
                    objPersonalFinalCalculation.ItemName = lstQry_PersonalExpensesList[i].ItemName;
                    objPersonalFinalCalculation.TotalExpenses = Convert.ToDouble(lstQry_PersonalExpensesList[i].Amount);
                    objPersonalFinalCalculation.EntryDate = Convert.ToDateTime(lstQry_PersonalExpensesList[i].EntryDate);
                    lstPersonalFinalCalculationList.Add(objPersonalFinalCalculation);
                }
                lstPersonalFinalCalculationList = lstPersonalFinalCalculationList.OrderByDescending(x => x.EntryDate).ToList();
            }
                  

  }



       
        //User Define Class....
        public class PersonalFinalCalculation
        {
            public string PersonName { get; set; }
            public string ItemName { get; set; }
            public double TotalExpenses { get; set; }
            public DateTime EntryDate { get; set; }
            

        }

        private void backgroundWorkerReport_DoWork(object sender, DoWorkEventArgs e)
        {
            fromDate = dateTimePickerFromDate.Value.Date;
            toDate = dateTimePickerToDate.Value.Date;
        }

        private void backgroundWorkerReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (lstPersonalFinalCalculationList.Count > 0)
                {
                    ParameterFields paramFields = new ParameterFields();
                    ParameterDiscreteValue objDiscreteValue = new ParameterDiscreteValue();
                    ParameterField objparameterField = new ParameterField();


                    //objDiscreteValue = new ParameterDiscreteValue();
                    //objparameterField = new ParameterField();
                    //objparameterField.Name = "paramMealRate";
                    //objDiscreteValue.Value = mealRate;
                    //objparameterField.CurrentValues.Add(objDiscreteValue);
                    //paramFields.Add(objparameterField);

                    objDiscreteValue = new ParameterDiscreteValue();
                    objparameterField = new ParameterField();
                    objparameterField.Name = "paramFromDate";
                    objDiscreteValue.Value = fromDate;
                    objparameterField.CurrentValues.Add(objDiscreteValue);
                    paramFields.Add(objparameterField);


                    objDiscreteValue = new ParameterDiscreteValue();
                    objparameterField = new ParameterField();
                    objparameterField.Name = "paramToDate";
                    objDiscreteValue.Value = toDate;
                    objparameterField.CurrentValues.Add(objDiscreteValue);
                    paramFields.Add(objparameterField);


                    CRPersonalReport rpt = new CRPersonalReport();

                    //Coding for Sub Report....
                    List<Qry_PersonalIncomeExpensesEntry> lstQry_PersonalIncomeEntryList = new List<Qry_PersonalIncomeExpensesEntry>();
                    Qry_PersonalIncomeExpensesEntryService objQry_PersonalIncomeExpensesEntryService = new Qry_PersonalIncomeExpensesEntryService();
                    lstQry_PersonalIncomeEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
                    && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date 
                    && x.IsExpenses == false  
                    && x.IsUtilities==false 
                    && x.PersonID == Convert.ToInt32(comboBoxPerson.SelectedValue)).ToList();
                    DataTable dtSub = ConvertToDataTable(lstQry_PersonalIncomeEntryList);
                    rpt.Subreports[0].SetDataSource(dtSub);

                    //Coding for Main Report....
                    DataTable dt = ConvertToDataTable(lstPersonalFinalCalculationList);
                    rpt.SetDataSource(dt);

                    ReportViewerForm objReportViewer = new ReportViewerForm();
                    objReportViewer.crystalReportViewer1.Refresh();
                    objReportViewer.crystalReportViewer1.ParameterFieldInfo = paramFields;
                    objReportViewer.crystalReportViewer1.ReportSource = rpt;
                    objReportViewer.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

                this.buttonShow.Enabled = true;
                this.progressBar1.Visible = false;


            }
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
