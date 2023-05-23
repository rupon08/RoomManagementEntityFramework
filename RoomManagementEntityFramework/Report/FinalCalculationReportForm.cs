using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using RoomData;
using RoomService;
using System.Collections;

namespace RoomManagementEntityFramework.Report
{
    public partial class FinalCalculationReportForm : Form
    {
        List<FinalCalculation> lstFinalCalculationList = new List<FinalCalculation>();
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        Tbl_DailyMarketService objTbl_DailyMarketService = new Tbl_DailyMarketService();
        Tbl_DailyMealService objTbl_DailyMealService = new Tbl_DailyMealService();
        Tbl_ExtraExpensesDtlsEntryService objTbl_ExtraExpensesDtlsEntryService = new Tbl_ExtraExpensesDtlsEntryService();
        Qry_ExtraExpensesDtlsEntryService objQry_ExtraExpensesDtlsEntryService = new Qry_ExtraExpensesDtlsEntryService();
        double mealRate = 0;
        DateTime fromDate;
        DateTime toDate;
        public FinalCalculationReportForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FinalCalcualtionMarketMeal();
            this.buttonShow.Enabled = false;
            this.progressBar1.Visible = true;
            backgroundWorkerReport.RunWorkerAsync();
         
        }
        private void FinalCalcualtionMarketMeal()
        {
            double totalMarket = 0;
            double totalMeal = 0;
            lstFinalCalculationList.Clear();
            //Calculation for Total Market....
            List<Qry_DailyMarketEntry> lstQry_DailyMarketEntryList = new List<Qry_DailyMarketEntry>();
            lstQry_DailyMarketEntryList = objTbl_DailyMarketService.GetAllMarket().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
               && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date).ToList();
            if (lstQry_DailyMarketEntryList.Count > 0)
            {

                for (int i = 0; i < lstQry_DailyMarketEntryList.Count; i++)
                {
                    totalMarket += Convert.ToDouble(lstQry_DailyMarketEntryList[i].TotalMarket);
                }
            }
            //Calculation for Total Meal....
            List<Qry_DailyMealEntry> lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
            lstQry_DailyMealEntryList = objTbl_DailyMealService.GetAllMeal().Where(x => x.EntryDate.Value.Date >= dateTimePickerFromDate.Value.Date
               && x.EntryDate.Value.Date <= dateTimePickerToDate.Value.Date).ToList();
            if (lstQry_DailyMealEntryList.Count > 0)
            {

                for (int i = 0; i < lstQry_DailyMealEntryList.Count; i++)
                {
                    totalMeal += Convert.ToDouble(lstQry_DailyMealEntryList[i].MealNo);
                }
                mealRate = totalMarket / totalMeal;
            }
            //Calculation Total have to pay for each Person....
            List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList = new List<Tbl_PersonDetailsEntry>();
            lstPersonDetailEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true).ToList();
            if (lstPersonDetailEntryList.Count > 0)
            {

                for (int i = 0; i < lstPersonDetailEntryList.Count; i++)
                {
                    double eachPersonTotalMarket = 0;
                    double eachPersonTotalMeal = 0;

                    for (int j = 0; j < lstQry_DailyMealEntryList.Count; j++)
                    {
                        if (lstPersonDetailEntryList[i].rowID == lstQry_DailyMealEntryList[j].PersonID)
                        {

                            eachPersonTotalMeal += Convert.ToDouble(lstQry_DailyMealEntryList[j].MealNo);


                        }

                    }

                    for (int k = 0; k < lstQry_DailyMarketEntryList.Count; k++)
                    {
                        if (lstPersonDetailEntryList[i].rowID == lstQry_DailyMarketEntryList[k].PersonName)
                        {
                            eachPersonTotalMarket += Convert.ToDouble(lstQry_DailyMarketEntryList[k].TotalMarket);


                        }

                    }
                    //for getting final calculation with cook,paper bill etc....
                    List<Tbl_ExtraExpensesDtlsEntry> lstExtraExpensesDetailEntryList = new List<Tbl_ExtraExpensesDtlsEntry>();
                    objTbl_ExtraExpensesDtlsEntryService = new Tbl_ExtraExpensesDtlsEntryService();
                    lstExtraExpensesDetailEntryList = objTbl_ExtraExpensesDtlsEntryService.GetAllData().Where(x => x.entryDate.Value.Month == dateTimePickerFromDate.Value.Month + 1
                        && x.entryDate.Value.Year == dateTimePickerFromDate.Value.Year).ToList();
                    double finalCalculation = 0;
                    if (lstExtraExpensesDetailEntryList.Count > 0)
                    {
                        for (int l = 0; l < lstExtraExpensesDetailEntryList.Count; l++)
                        {
                            finalCalculation = finalCalculation + Convert.ToDouble((lstExtraExpensesDetailEntryList[l].expAmt));
                        }
                        finalCalculation = finalCalculation / lstPersonDetailEntryList.Count;
                    }
                    double finalTaka = Convert.ToDouble(((eachPersonTotalMeal * mealRate) - eachPersonTotalMarket).ToString("0.00"));
                    FinalCalculation objFinalCalculation = new FinalCalculation();
                    objFinalCalculation.PersonName = lstPersonDetailEntryList[i].Name;
                    objFinalCalculation.TotalMarket = eachPersonTotalMarket;
                    objFinalCalculation.TotalMeal = eachPersonTotalMeal;
                    objFinalCalculation.FinalTaka = finalTaka;
                    objFinalCalculation.FinalCalculationf = finalTaka + finalCalculation;
                    lstFinalCalculationList.Add(objFinalCalculation);

                }



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
        //User Define Class....
        public class FinalCalculation
        {
            public string PersonName { get; set; }
            public double TotalMarket { get; set; }
            public double TotalMeal { get; set; }
            public double FinalTaka { get; set; }
            public double FinalCalculationf { get; set; }

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
                if (lstFinalCalculationList.Count > 0)
                {
                    ParameterFields paramFields = new ParameterFields();
                    ParameterDiscreteValue objDiscreteValue = new ParameterDiscreteValue();
                    ParameterField objparameterField = new ParameterField();


                    objDiscreteValue = new ParameterDiscreteValue();
                    objparameterField = new ParameterField();
                    objparameterField.Name = "paramMealRate";
                    objDiscreteValue.Value = mealRate;
                    objparameterField.CurrentValues.Add(objDiscreteValue);
                    paramFields.Add(objparameterField);

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

                    //Coding for Sub Report....
                    CRFinalCalculationReport rpt = new CRFinalCalculationReport();
                    List<Qry_ExtraExpensesDtlsEntry> lstQryExtraExpensesDtlsEntryList = new List<Qry_ExtraExpensesDtlsEntry>();
                    objQry_ExtraExpensesDtlsEntryService = new Qry_ExtraExpensesDtlsEntryService();
                    lstQryExtraExpensesDtlsEntryList = objQry_ExtraExpensesDtlsEntryService.GetQryAllData().Where(x => x.entryDate.Value.Month == dateTimePickerFromDate.Value.Month+1
                        && x.entryDate.Value.Year == dateTimePickerFromDate.Value.Year).ToList();
                    DataTable dtSub = ConvertToDataTable(lstQryExtraExpensesDtlsEntryList);
                    rpt.Subreports[0].SetDataSource(dtSub);

                    //Coding for Main Report....
                    DataTable dt = ConvertToDataTable(lstFinalCalculationList);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
