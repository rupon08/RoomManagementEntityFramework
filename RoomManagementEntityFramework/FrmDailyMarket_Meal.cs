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
using RoomManagementEntityFramework.Report;
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace RoomManagementEntityFramework
{
    public partial class FrmDailyMarket_Meal : Form
    {
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        Tbl_DailyMarketService objTbl_DailyMarketService = new Tbl_DailyMarketService();
        Tbl_DailyMealService objTbl_DailyMealService = new Tbl_DailyMealService();
        Tbl_ExtraExpensesDtlsEntryService objTbl_ExtraExpensesDtlsEntryService = new Tbl_ExtraExpensesDtlsEntryService();
        private int selectedIndex = 0;
        private int selectedIndex1 = 0;
        List<Qry_DailyMarketEntry> lstQry_DailyMarketEntryList = new List<Qry_DailyMarketEntry>();
        List<Qry_DailyMealEntry> lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
        List<FinalCalculation> lstFinalCalculationList = new List<FinalCalculation>();
        Qry_ExtraExpensesDtlsEntryService objQry_ExtraExpensesDtlsEntryService = new Qry_ExtraExpensesDtlsEntryService();
        double mealRate = 0;
        bool saveFlag = false;
        int personID=0;
        double mealNo=0;
        DateTime entryDate;
        string mealDesc = "";
        DateTime fromDate;
        DateTime toDate;
       
        public FrmDailyMarket_Meal()
        {
            InitializeComponent();
        }

        private void FrmDailyMarket_Meal_Load(object sender, EventArgs e)
        {
            try
            {
               
               // LoadProgressBar();
                timer1.Start();
                LoadAllPerson();
                LoadAllMarketForCurrentAndPreviousMonth();
                LoadAllMealForCurrentAndPreviousMonth();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadProgressBar()
        {
           // //Creating Progress Bar Automatically....
            //ProgressBar pBar = new ProgressBar();
            //pBar.Location = new System.Drawing.Point(20, 20);
            //pBar.Name = "ProgressBar1";
            //pBar.Width = 200;
            //pBar.Height = 30;
            //Controls.Add(pBar);
            ////Showing Output....
            //progressBar1.Dock = DockStyle.Bottom;
            //progressBar1.Width = 2;
            //progressBar1.Height = 10;
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
            //progressBar1.Value = 99;

          
        
        }

        private void LoadAllMarketForCurrentAndPreviousMonth()
        {
            try
            {
                objTbl_DailyMarketService = new Tbl_DailyMarketService();
                if (radioButtonCurrentMonth.Checked == true)
                {
                    lstQry_DailyMarketEntryList = objTbl_DailyMarketService.GetAllMarket().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMarket.Value.Year
                      && x.EntryDate.Value.Month == dateTimePickerEntryDateMarket.Value.Month).ToList();
                    lstQry_DailyMarketEntryList = lstQry_DailyMarketEntryList.OrderByDescending(x => x.EntryDate).ToList();
                }
                else
                {
                    lstQry_DailyMarketEntryList = objTbl_DailyMarketService.GetAllMarket().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMarket.Value.Year
                     && x.EntryDate.Value.Month == dateTimePickerEntryDateMarket.Value.Month-1).ToList();
                    lstQry_DailyMarketEntryList = lstQry_DailyMarketEntryList.OrderByDescending(x => x.EntryDate).ToList();
                }

                if (lstQry_DailyMarketEntryList.Count > 0)
                {
                    dataGridViewMarket.AutoGenerateColumns = false;
                    dataGridViewMarket.DataSource = null;
                    dataGridViewMarket.DataSource = lstQry_DailyMarketEntryList;
                    dataGridViewMarket.Refresh();
                   
                }
                else
                {
                    dataGridViewMarket.DataSource = null;
                    dataGridViewMarket.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadAllMealForCurrentAndPreviousMonth()
        {
            try
            {
                objTbl_DailyMealService = new Tbl_DailyMealService();
                if (radioButtonCurrentMonth1.Checked == true)
                {
                    lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
                    lstQry_DailyMealEntryList = objTbl_DailyMealService.GetAllMeal().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMeal.Value.Year
               && x.EntryDate.Value.Month == dateTimePickerEntryDateMeal.Value.Month).ToList();
                    lstQry_DailyMealEntryList = lstQry_DailyMealEntryList.OrderByDescending(x => x.EntryDate).ToList();
                }
                else
                {
                    lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
                    lstQry_DailyMealEntryList = objTbl_DailyMealService.GetAllMeal().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMeal.Value.Year
                                   && x.EntryDate.Value.Month == dateTimePickerEntryDateMeal.Value.Month-1).ToList();
                    lstQry_DailyMealEntryList = lstQry_DailyMealEntryList.OrderByDescending(x => x.EntryDate).ToList();
                }

                if (lstQry_DailyMealEntryList.Count > 0)
                {
                    dataGridViewMeal.AutoGenerateColumns = false;
                    dataGridViewMeal.DataSource = null;
                   dataGridViewMeal.DataSource = lstQry_DailyMealEntryList;
                   dataGridViewMeal.Refresh();
                    
                }
                else
                {
                    dataGridViewMeal.DataSource = null;
                    dataGridViewMeal.Refresh();
                }
           }
           catch (Exception ex)
           {
                 MessageBox.Show(ex.Message);
           }
        }
     
        private void LoadAllPerson()
        {
            try
            {
                List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList = new List<Tbl_PersonDetailsEntry>();
                lstPersonDetailEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true).ToList();
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
                    comboBoxPersonMarket.ValueMember = dt.Columns[0].ColumnName;
                    comboBoxPersonMarket.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxPersonMarket.DataSource = dt;         
                   
                }
                List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList1 = new List<Tbl_PersonDetailsEntry>();
                lstPersonDetailEntryList1 = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true).ToList();
                if (lstPersonDetailEntryList1.Count > 0)
                {
                    Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry = new Tbl_PersonDetailsEntry();
                    objTbl_PersonDetailsEntry.rowID = 0;
                    objTbl_PersonDetailsEntry.Name = "Select Person";
                    lstPersonDetailEntryList1.Add(objTbl_PersonDetailsEntry);
                    lstPersonDetailEntryList1 = lstPersonDetailEntryList1.OrderBy(x => x.rowID).ToList();
                    //This Code is not working for selected value in ComboBox.....
                    //comboBoxPersonMeal.DataSource = null;
                    //comboBoxPersonMeal.DisplayMember = "Name";
                    //comboBoxPersonMeal.ValueMember = "rowID";
                    //comboBoxPersonMeal.DataSource = lstPersonDetailEntryList1;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("rowID");
                    dt.Columns.Add("Name");
                    foreach (Tbl_PersonDetailsEntry objPerson in lstPersonDetailEntryList)
                    {
                        dt.Rows.Add(objPerson.rowID, objPerson.Name);
                    }
                    comboBoxPersonMeal.ValueMember = dt.Columns[0].ColumnName;
                    comboBoxPersonMeal.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxPersonMeal.DataSource = dt;         
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool MarketFieldCheck()
        {
            if (comboBoxPersonMarket.SelectedIndex == 0 || comboBoxPersonMarket.SelectedIndex ==-1)
            {
                MessageBox.Show("Please Select Person");
                comboBoxPersonMarket.Focus();
                return false;
            }
            else if (textBoxTotalMarket.Text == "")
            {
                MessageBox.Show("Enter Total Market");
                textBoxTotalMarket.Focus();
                return false;
            }
            else if (dateTimePickerEntryDateMarket.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Select Only Current Year");
                dateTimePickerEntryDateMarket.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool MealFieldCheck()
        {
            if (comboBoxPersonMeal.SelectedIndex == 0 || comboBoxPersonMeal.SelectedIndex ==-1)
            {
                MessageBox.Show("Please Select Person");
                comboBoxPersonMeal.Focus();
                return false;
            }
            else if (textBoxTotalMeal.Text == "")
            {
                MessageBox.Show("Enter Total Meal");
                textBoxTotalMeal.Focus();
                return false;
            }
            else if (dateTimePickerEntryDateMeal.Value.Year>DateTime.Now.Year)
            {
                MessageBox.Show("Select Only Current Year");
                dateTimePickerEntryDateMeal.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonMarketSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MarketFieldCheck() == true)
                {
                    //Validation for Duplicate Entry for Market....
                    List<Tbl_DailyMarketEntry> lstDailyMarketList = new List<Tbl_DailyMarketEntry>();
                    lstDailyMarketList = objTbl_DailyMarketService.GetAllData().Where(x => x.EntryDate==dateTimePickerEntryDateMarket.Value.Date 
                        && x.PersonName==Convert.ToInt32(comboBoxPersonMarket.SelectedValue)).ToList();
                    if (lstDailyMarketList.Count > 0)
                    {
                        MessageBox.Show("Data already Exist for this Person");
                        return;
                    }
                    if (MessageBox.Show("Are You Sure?", "Market Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_DailyMarketEntry objTbl_DailyMarketEntry = new Tbl_DailyMarketEntry();
                        objTbl_DailyMarketEntry.PersonName = Convert.ToInt32(comboBoxPersonMarket.SelectedValue);
                        objTbl_DailyMarketEntry.TotalMarket = Convert.ToInt32(textBoxTotalMarket.Text);
                        objTbl_DailyMarketEntry.EntryDate = dateTimePickerEntryDateMarket.Value.Date;
                        objTbl_DailyMarketEntry.Description = textBoxMarketDesc.Text;
                        objTbl_DailyMarketEntry.LastUpdate = DateTime.Now;

                        objTbl_DailyMarketService.InsertMarket(objTbl_DailyMarketEntry);
                        if (objTbl_DailyMarketEntry.rowID != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllMarketForCurrentAndPreviousMonth();
                            ClearAllMarket();
                        }
                        else
                        {
                            MessageBox.Show("Data Not Inserted");
                        }
                    }
                }
               
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMealSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (MealFieldCheck() == true)
                {
                    //Validation for Duplicate Entry for Meal....
                    List<Tbl_DailyMealEntry> lstDailyMealList = new List<Tbl_DailyMealEntry>();
                    lstDailyMealList = objTbl_DailyMealService.GetAllData().Where(x => x.EntryDate == dateTimePickerEntryDateMeal.Value.Date
                        && x.PersonID == Convert.ToInt32(comboBoxPersonMeal.SelectedValue)).ToList();
                    if (lstDailyMealList.Count > 0)
                    {
                        MessageBox.Show("Data already Exist for this Person");
                        return;
                    }

                    if (MessageBox.Show("Are You Sure?", "Meal Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.buttonMealSave.Enabled = false;
                        this.progressBar1.Visible = true;
                        personID = Convert.ToInt32(comboBoxPersonMeal.SelectedValue);
                        mealNo = Convert.ToDouble(textBoxTotalMeal.Text);
                        entryDate = dateTimePickerEntryDateMeal.Value.Date;
                        mealDesc = textBoxMealDesc.Text;
                        backgroundWorkerMealSave.RunWorkerAsync();
                      
                      
                        //if (objTbl_DailyMealEntry.rowID != 0)
                        //{
                            //MessageBox.Show("Data Successfully Inserted");
                            //LoadAllMealForCurrentAndPreviousMonth();
                            //ClearAllMeal();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Data Not Inserted");
                        //}
                    }
                }
               
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void contextMenuStripMarket_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                comboBoxPersonMarket.SelectedValue = lstQry_DailyMarketEntryList[selectedIndex].PersonName;
                textBoxTotalMarket.Text = lstQry_DailyMarketEntryList[selectedIndex].TotalMarket.ToString();
                dateTimePickerEntryDateMarket.Value = Convert.ToDateTime(lstQry_DailyMarketEntryList[selectedIndex].EntryDate);
                textBoxMarketDesc.Text = lstQry_DailyMarketEntryList[selectedIndex].Description.ToString();

                buttonMarketUpdate.Visible = true;
                buttonMarketCancel.Visible = true;
                buttonMarketNew.Visible = false;
                buttonMarketSave.Visible = false;
                groupBoxDailyMarket.Text = "Edit Daily Market";
           
            }
            if (e.ClickedItem.ToString() == "Delete")
            {
                contextMenuStripMarket.Visible = false;
                if (MessageBox.Show("Do you want to Delete Daily Market Entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objTbl_DailyMarketService = new Tbl_DailyMarketService();

                    List<Tbl_DailyMarketEntry> lstExistDailyMarketList = new List<Tbl_DailyMarketEntry>();
                    int rowID =(int) lstQry_DailyMarketEntryList[selectedIndex].rowID;
                    lstExistDailyMarketList = objTbl_DailyMarketService.MarketSelectByID(rowID);
                    if (lstExistDailyMarketList.Count > 0)
                    {
                        objTbl_DailyMarketService = new Tbl_DailyMarketService();
                        //dataGridViewMarket.DataSource = null;
                        objTbl_DailyMarketService.DeleteMarket(lstExistDailyMarketList[0]);
                        //lstProbWiseGradSystem.RemoveAt(selectedIndex);
                        MessageBox.Show("Data Successfully Deleted");
                        LoadAllMarketForCurrentAndPreviousMonth();
                    }
                    //else
                    //{
                    //    //dgvProWiseGradSys.DataSource = null;
                    //    lstProbWiseGradSystem.RemoveAt(selectedIndex);
                    //}

                }
            }
        }

        private void dataGridViewMarket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void dataGridViewMarket_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Right) 
            {
            contextMenuStripMarket.Items.Clear();
            contextMenuStripMarket.Items.Add("Edit");
            contextMenuStripMarket.Items.Add("Delete");
            contextMenuStripMarket.Show(dataGridViewMarket,new Point(e.X, e.Y));
            }
        }

        private void dataGridViewMeal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripMeal.Items.Clear();
                contextMenuStripMeal.Items.Add("Edit");
                contextMenuStripMeal.Items.Add("Delete");
                contextMenuStripMeal.Show(dataGridViewMeal, new Point(e.X, e.Y));
            }
        }

        private void dataGridViewMeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex1 = e.RowIndex;
        }

        private void contextMenuStripMeal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                comboBoxPersonMeal.SelectedValue = Convert.ToInt32(lstQry_DailyMealEntryList[selectedIndex1].PersonID);
                textBoxTotalMeal.Text = lstQry_DailyMealEntryList[selectedIndex1].MealNo.ToString();
                dateTimePickerEntryDateMeal.Value = Convert.ToDateTime(lstQry_DailyMealEntryList[selectedIndex1].EntryDate);
                //textBoxMealDesc.Text = lstQry_DailyMealEntryList[selectedIndex1].Description.ToString();

                /*
                if (lstQry_DailyMealEntryList[selectedIndex1].Description.ToString() == null)
                    textBoxMealDesc.Text = null;
                else 
                    textBoxMealDesc.Text = lstQry_DailyMealEntryList[selectedIndex1].Description.ToString();
                 */
      
                buttonMealUpdate.Visible = true;
                buttonMealCancel.Visible = true;
                buttonMealNew.Visible = false;
                buttonMealSave.Visible = false;
                groupBoxDailyMeal.Text = "Edit Daily Meal";
            }
            if (e.ClickedItem.ToString() == "Delete")
            {

            }
        }

        private void buttonMarketCancel_Click(object sender, EventArgs e)
        {
            buttonMarketUpdate.Visible = false ;
            buttonMarketCancel.Visible = false ;
            buttonMarketNew.Visible = true;
            buttonMarketSave.Visible = true;
            ClearAllMarket();
            groupBoxDailyMarket.Text = "Daily Market Entry";
        }

        private void buttonMealCancel_Click(object sender, EventArgs e)
        {
            buttonMealUpdate.Visible = false;
            buttonMealCancel.Visible = false;
            buttonMealNew.Visible = true ;
            buttonMealSave.Visible = true ;
            ClearAllMeal();
            groupBoxDailyMeal.Text = "Daily Meal Entry";
        }
        private void ClearAllMeal()
        {
            textBoxTotalMeal.Text = "";
            textBoxMealDesc.Text = "";
            if (checkBoxDueDate.Checked)
            {

            }
            else
            {
                dateTimePickerEntryDateMeal.Value = DateTime.Today;
            }
            
            comboBoxPersonMeal.SelectedIndex = 0;
        }
        private void ClearAllMarket()
        {
            textBoxTotalMarket.Text = "";
            textBoxMarketDesc.Text = "";
            dateTimePickerEntryDateMarket.Value = DateTime.Today;
            comboBoxPersonMarket.SelectedIndex = 0;
        }
        private void FinalCalcualtionMarketMeal()
        {
            double totalMarket = 0;
            double totalMeal = 0;
          
            //double mealRate = 0;
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
            textBoxTotMarket.Text = totalMarket.ToString();
            textBoxTotMeal.Text = totalMeal.ToString();
            textBoxMealRate.Text = mealRate.ToString();
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
                    //DateTime myDateTime = DateTime.Now.AddMonths(1);
                    List<Tbl_ExtraExpensesDtlsEntry> lstExtraExpensesDetailEntryList = new List<Tbl_ExtraExpensesDtlsEntry>();
                    objTbl_ExtraExpensesDtlsEntryService = new Tbl_ExtraExpensesDtlsEntryService();
                    lstExtraExpensesDetailEntryList = objTbl_ExtraExpensesDtlsEntryService.GetAllData().Where(x => x.entryDate.Value.Month == dateTimePickerFromDate.Value.Month
                        && x.entryDate.Value.Year==dateTimePickerToDate.Value.Year).ToList();
                    double finalCalculation = 0;
                    if (lstExtraExpensesDetailEntryList.Count > 0)
                    {
                        for (int l = 0; l < lstExtraExpensesDetailEntryList.Count; l++)
                        {
                            //if (lstPersonDetailEntryList[i].rowID == lstQry_DailyMarketEntryList[l].PersonName)
                            //{
                                finalCalculation = finalCalculation + Convert.ToDouble((lstExtraExpensesDetailEntryList[l].expAmt));
                            //}
                        }
                        finalCalculation = (finalCalculation / lstPersonDetailEntryList.Count) ;
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
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            FinalCalcualtionMarketMeal();
            dataGridViewFinalCalculation.DataSource = null;
            dataGridViewFinalCalculation.DataSource = lstFinalCalculationList;
        }

        private void buttonMarketUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MarketFieldCheck() == true)
                {

                
                if (MessageBox.Show("Are You Sure?", "Market Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_DailyMarketEntry objTbl_DailyMarketEntry = new Tbl_DailyMarketEntry();
                    List<Tbl_DailyMarketEntry> lstDailyMarketList = new List<Tbl_DailyMarketEntry>();
                    lstDailyMarketList=objTbl_DailyMarketService.GetAllData().Where(x => x.rowID == lstQry_DailyMarketEntryList[selectedIndex].rowID).ToList();
                    if (lstDailyMarketList.Count > 0)
                    {
                        
                        lstDailyMarketList[0].TotalMarket = Convert.ToDouble(textBoxTotalMarket.Text);
                        lstDailyMarketList[0].PersonName = Convert.ToInt32(comboBoxPersonMarket.SelectedValue);
                        lstDailyMarketList[0].EntryDate = dateTimePickerEntryDateMarket.Value.Date;
                        lstDailyMarketList[0].Description = textBoxMarketDesc.Text;
                        lstDailyMarketList[0].LastUpdate = DateTime.Now;
                        objTbl_DailyMarketService.UpdateMarket(lstDailyMarketList[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllMarketForCurrentAndPreviousMonth();
                    }

                    buttonMarketUpdate.Visible = false;
                    buttonMarketCancel.Visible = false;
                    buttonMarketSave.Visible = true;
                    buttonMarketNew.Visible = true;
                    groupBoxDailyMarket.Text = "Daily Market Entry";
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMarketNew_Click(object sender, EventArgs e)
        {
            ClearAllMarket();
        }

        private void buttonMealNew_Click(object sender, EventArgs e)
        {
            ClearAllMeal();
        }

        private void buttonMealUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MealFieldCheck() == true)
                {

                 if (MessageBox.Show("Are You Sure?", "Meal Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<Tbl_DailyMealEntry> lstDailyMealList = new List<Tbl_DailyMealEntry>();
                    lstDailyMealList = objTbl_DailyMealService.GetAllData().Where(x => x.rowID == lstQry_DailyMealEntryList[selectedIndex1].rowID).ToList();
                    if (lstDailyMealList.Count > 0)
                    {
                      
                        lstDailyMealList[0].PersonID = Convert.ToInt32(comboBoxPersonMeal.SelectedValue);
                        lstDailyMealList[0].MealNo = Convert.ToDouble(textBoxTotalMeal.Text);
                        lstDailyMealList[0].EntryDate = dateTimePickerEntryDateMeal.Value.Date;
                        lstDailyMealList[0].Description = textBoxMealDesc.Text;
                        lstDailyMealList[0].LastUpdate = DateTime.Now;
                        
                        objTbl_DailyMealService.UpdateMeal(lstDailyMealList[0]);
                        MessageBox.Show("Successfully Updated");
                        LoadAllMealForCurrentAndPreviousMonth();
                       
                    }


                    buttonMealUpdate.Visible = false;
                    buttonMealCancel.Visible = false;
                    buttonMealSave.Visible = true;
                    buttonMealNew.Visible = true;
                    groupBoxDailyMeal.Text = "Daily Meal Entry";
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewMarket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            FinalCalcualtionMarketMeal();
            this.buttonReport.Enabled = false;
            this.progressBar1.Visible = true;
            backgroundWorkerReport.RunWorkerAsync();
                     
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
        private void radioButtonCurrentMonth_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllMarketForCurrentAndPreviousMonth();
        }

        private void radioButtonPreviousMonth_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllMarketForCurrentAndPreviousMonth();
        }

        private void radioButtonCurrentMonth1_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllMealForCurrentAndPreviousMonth();
        }

        private void radioButtonPreviousMonth1_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllMealForCurrentAndPreviousMonth();
        }

        private void buttonNewPerson_Click(object sender, EventArgs e)
        {
            FrmPersonEntry objFrmPersonEntry = new FrmPersonEntry();
            objFrmPersonEntry.ShowDialog();
           
        }

        private void textBoxTotalMarket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only");
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only");
            }
        }

        private void textBoxTotalMeal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only");
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Enter Number Only");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label33.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Label34.Text = DateTime.Today.DayOfWeek.ToString("") + "," + DateTime.Today.ToString("dd-MMM-yyyy");
         
        }

        private void buttonExtraExpenses_Click(object sender, EventArgs e)
        {
            FrmExtraExpensesDetailsEntry objFrmExtraExpensesDetailsEntry = new FrmExtraExpensesDetailsEntry();
            objFrmExtraExpensesDetailsEntry.ShowDialog();
        }

        private void comboBoxPersonMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");

            }
        }

        private void textBoxTotalMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dateTimePickerEntryDateMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBoxPersonMeal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxTotalMeal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dateTimePickerEntryDateMeal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dateTimePickerFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dateTimePickerToDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void backgroundWorkerMealSave_DoWork(object sender, DoWorkEventArgs e)
        {
            Tbl_DailyMealEntry objTbl_DailyMealEntry = new Tbl_DailyMealEntry();
            objTbl_DailyMealEntry.PersonID = personID;
            objTbl_DailyMealEntry.MealNo = mealNo;
            objTbl_DailyMealEntry.EntryDate = entryDate;
            objTbl_DailyMealEntry.Description = mealDesc;
            objTbl_DailyMealEntry.LastUpdate = DateTime.Now;
            objTbl_DailyMealService.InsertMeal(objTbl_DailyMealEntry);
            if (objTbl_DailyMealEntry.rowID != 0)
            {
                saveFlag = true;
            }
           
        }

        private void backgroundWorkerMealSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (saveFlag == true)
                {

                   
                    LoadAllMealForCurrentAndPreviousMonth();
                    ClearAllMeal();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                    saveFlag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.buttonMealSave.Enabled = true;
                this.progressBar1.Visible = false;
                MessageBox.Show("Data Successfully Inserted");

            }
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
                    lstQryExtraExpensesDtlsEntryList = objQry_ExtraExpensesDtlsEntryService.GetQryAllData().Where(x => x.entryDate.Value.Month == dateTimePickerFromDate.Value.Month
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

                this.buttonReport.Enabled = true;
                this.progressBar1.Visible = false;
               

            }
        }

        private void FrmDailyMarket_Meal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LogIn objLogIn = new LogIn();
            //objLogIn.Show();
           
        }

        private void checkBoxDueDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDueDate.Checked)
            {
                FrmMultipleDateEntry objFrmMultipleDateEntry = new FrmMultipleDateEntry();
                objFrmMultipleDateEntry.ShowDialog();
            }
        }

        private void buttonMarketSearch_Click(object sender, EventArgs e)
        {
            LoadMarketForAnyDate();
        }

        private void buttonMealSearch_Click(object sender, EventArgs e)
        {
            LoadMealForAnyDate();
        }

        private void LoadMealForAnyDate()
        {
            try
            {
                objTbl_DailyMealService = new Tbl_DailyMealService();
                    lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
                    lstQry_DailyMealEntryList = objTbl_DailyMealService.GetAllMeal().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMeal.Value.Year
                      && x.EntryDate.Value.Month == dateTimePickerEntryDateMeal.Value.Month).ToList();
                    lstQry_DailyMealEntryList = lstQry_DailyMealEntryList.OrderByDescending(x => x.EntryDate).ToList();
                if (lstQry_DailyMealEntryList.Count > 0)
                {
                    dataGridViewMeal.AutoGenerateColumns = false;
                    dataGridViewMeal.DataSource = null;
                    dataGridViewMeal.DataSource = lstQry_DailyMealEntryList;
                    dataGridViewMeal.Refresh();

                }
                else
                {
                    dataGridViewMeal.DataSource = null;
                    dataGridViewMeal.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadMarketForAnyDate()
        {
            try
            {
                objTbl_DailyMarketService = new Tbl_DailyMarketService();
             
               lstQry_DailyMarketEntryList = objTbl_DailyMarketService.GetAllMarket().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMarket.Value.Year
                      && x.EntryDate.Value.Month == dateTimePickerEntryDateMarket.Value.Month).ToList();
               lstQry_DailyMarketEntryList = lstQry_DailyMarketEntryList.OrderByDescending(x => x.EntryDate).ToList();
              
                if (lstQry_DailyMarketEntryList.Count > 0)
                {
                    dataGridViewMarket.AutoGenerateColumns = false;
                    dataGridViewMarket.DataSource = null;
                    dataGridViewMarket.DataSource = lstQry_DailyMarketEntryList;
                    dataGridViewMarket.Refresh();

                }
                else
                {
                    dataGridViewMarket.DataSource = null;
                    dataGridViewMarket.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
         
    }

    //User Define Class....
   public class FinalCalculation
    {
        public string PersonName { get; set; }
        public double TotalMarket{get;set;}
        public double TotalMeal { get; set; }
        public double FinalTaka { get; set; }
        public double FinalCalculationf { get; set; }
   
     }
   //User Define Class....
   public class PersonalFinalCalculation
   {
       public string PersonName { get; set; }
       public string ItemName { get; set; }
     //  public double TotalIncome { get; set; }
       public double TotalExpenses { get; set; }
       public DateTime EntryDate { get; set; }
      // public double FinalTaka { get; set; }


   }
}
