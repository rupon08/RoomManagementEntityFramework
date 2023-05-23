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

namespace RoomManagementEntityFramework
{
    public partial class FrmPersonalIncome_Expenses : Form
    {
        int selectedIndex = 0;
        Tbl_extraExpensesMstService objTbl_extraExpensesMstService = new Tbl_extraExpensesMstService();
                Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
                Tbl_PersonalIncomeExpensesEntryService objTbl_PersonalIncomeExpensesEntryService = new Tbl_PersonalIncomeExpensesEntryService();
                List<Qry_PersonalIncomeExpensesEntry> lstQryPersonalIncomeExpensesEntryList = new List<Qry_PersonalIncomeExpensesEntry>();
                Qry_PersonalIncomeExpensesEntryService objQry_PersonalIncomeExpensesEntryService = new Qry_PersonalIncomeExpensesEntryService();
        public FrmPersonalIncome_Expenses()
        {
            InitializeComponent();
        }

        private void FrmPersonalIncome_Expenses_Load(object sender, EventArgs e)
        {
            LoadExtraExpensesMaster();
            LoadAllPerson();
            LoadPersonalForCurrentAndPreviousMonth();
        }
        private void LoadAllPerson()
        {
            try
            {
                List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList = new List<Tbl_PersonDetailsEntry>();
                lstPersonDetailEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true && x.IsPersonalIncomeExpenses==true).ToList();
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
        private void LoadExtraExpensesMaster()
        {
            try
            {
                List<Tbl_ExpensesMst> lstExtraExpensesMasterList = new List<Tbl_ExpensesMst>();
                //Coding for Utility Checked....
                if (checkBoxIsUtility.Checked)
                {

                    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsUtilities == true && x.IsExpenses==true &&x.IsActive==true  ).ToList();
                }
                else
                {
                    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsUtilities==false && x.IsActive == true).ToList();
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
                    Tbl_ExpensesMst objTbl_extraExpensesMst = new Tbl_ExpensesMst();
                    objTbl_extraExpensesMst.rowID = 0;
                    objTbl_extraExpensesMst.ItemName = "Select an Item";
                    lstExtraExpensesMasterList.Add(objTbl_extraExpensesMst);
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
                        dt.Rows.Add(objExtraExpenses.rowID, objExtraExpenses.ItemName,objExtraExpenses.IsExpenses,objExtraExpenses.IsUtilities);
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

        private void buttonPersonalSave_Click(object sender, EventArgs e)
        {
            if (PersonalFieldCheck() == true)
            {
                //Validation for Duplicate Entry for Personal Income & Expenses....
                List<Tbl_PersonalIncomeExpensesEntry> lstPersonalList = new List<Tbl_PersonalIncomeExpensesEntry>();
                objTbl_PersonalIncomeExpensesEntryService = new Tbl_PersonalIncomeExpensesEntryService();
                lstPersonalList = objTbl_PersonalIncomeExpensesEntryService.GetAllData().Where(x => x.EntryDate.Value.Date == dateTimePickerEntryDatePersonal.Value.Date
                    && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)
                    && x.PersonID==Convert.ToInt32(comboBoxPerson.SelectedValue)
                    ).ToList();
                if (lstPersonalList.Count > 0)
                {
                    MessageBox.Show("Data already Exist for this Item");
                    return;
                }
                if (MessageBox.Show("Are You Sure?", "Personal Income & Expenses Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_PersonalIncomeExpensesEntry objTbl_PersonalIncomeExpensesEntry = new Tbl_PersonalIncomeExpensesEntry();
                    objTbl_PersonalIncomeExpensesEntry.PersonID = Convert.ToInt32(comboBoxPerson.SelectedValue);
                    objTbl_PersonalIncomeExpensesEntry.ItemID = Convert.ToInt32(comboBoxItem.SelectedValue);
                    objTbl_PersonalIncomeExpensesEntry.Amount = Convert.ToDouble(textBoxAmount.Text);
                    objTbl_PersonalIncomeExpensesEntry.EntryDate = dateTimePickerEntryDatePersonal.Value;
                    objTbl_PersonalIncomeExpensesEntry.LastUpdate = DateTime.Now;
                    objTbl_PersonalIncomeExpensesEntry.Description = textBoxDescription.Text;
                    objTbl_PersonalIncomeExpensesEntryService.InsertIncomeExpenses(objTbl_PersonalIncomeExpensesEntry);
                    if (objTbl_PersonalIncomeExpensesEntry.rowID != 0)
                    {
                        MessageBox.Show("Data Successfully Inserted");
                        LoadPersonalForCurrentAndPreviousMonth();
                        //ClearAllPersonal();
                        textBoxAmount.Text = "";
                        dateTimePickerEntryDatePersonal.Value = DateTime.Today;
                        textBoxDescription.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
            }

           
        }
        private bool PersonalFieldCheck()
        {

            if (comboBoxPerson.SelectedIndex == 0 || comboBoxPerson.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Person");
                comboBoxPerson.Focus();
                return false;
            }

            else if (comboBoxItem.SelectedIndex == 0 || comboBoxItem.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item");
                comboBoxItem.Focus();
                return false;
            }
            else if (textBoxAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount");
                textBoxAmount.Focus();
                return false;
            }
            else if (dateTimePickerEntryDatePersonal.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Select Only Current Year");
                dateTimePickerEntryDatePersonal.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearAllPersonal()
        {
            textBoxAmount.Text = "";
            dateTimePickerEntryDatePersonal.Value = DateTime.Today;
            //comboBoxPerson.SelectedIndex = 0;
            comboBoxItem.SelectedIndex = 0;
            textBoxDescription.Text = "";
        }
        private void LoadPersonalForCurrentAndPreviousMonth()
        {
            try
            {
                objQry_PersonalIncomeExpensesEntryService = new Qry_PersonalIncomeExpensesEntryService();
                //Checking for Current Month....
                if (radioButtonCurrentMonth.Checked == true)
                {
                    
                    //checking for Utilities Item....
                    if (checkBoxIsUtility.Checked == true)
                    {

                        //if not selected any particular Item then loading all Item....
                        if (comboBoxItem.SelectedIndex == 0)
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                             && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month
                             && x.IsUtilities == true).ToList();

                        }
                        else
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                            && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month
                            && x.IsUtilities == true
                            && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
                        }
                        //Loading Item in List by Descending Order....
                        //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                    }
                    else
                    {
                        //if not selected any particular Item then loading all Item....
                        if (comboBoxItem.SelectedIndex == 0)
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                             && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month
                             && x.IsUtilities == false).ToList();
                            //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();

                        }
                        else
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                            && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month
                            && x.IsUtilities == false
                            && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
                        }
                        //Loading Item in List by Descending Order....
                        //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                    }
                   
                    
                }
                //Checking for Previous Month....
                else
                {
                    //checking for Utilities Item....
                    if (checkBoxIsUtility.Checked == true)
                    {
                          //if not selected any particular Item then loading all Item....
                        if (comboBoxItem.SelectedIndex == 0)
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                             && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month - 1
                             && x.IsUtilities == true).ToList();
                        }
                        else
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                             && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month - 1
                             && x.IsUtilities == true
                             && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
                        }
                        //Loading Item in List by Descending Order....
                        //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                    }
                    else
                    {
                         //if not selected any particular Item then loading all Item....
                        if (comboBoxItem.SelectedIndex == 0)
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year 
                            && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month - 1
                            && x.IsUtilities == false).ToList();
                        }
                        else
                        {
                            lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                            && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month - 1
                            && x.IsUtilities == false
                            && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
                        }
                        //Loading Item in List by Descending Order....
                       // lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                    }

                }

                if (lstQryPersonalIncomeExpensesEntryList.Count > 0)
                {
                    lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                    //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.Where(x => x.ExtraItemID == Convert.ToInt32(comboBoxExpenses.SelectedValue)).ToList();
                    dataGridViewPersonal.AutoGenerateColumns = false;
                    dataGridViewPersonal.DataSource = null;
                    dataGridViewPersonal.DataSource = lstQryPersonalIncomeExpensesEntryList;
                    dataGridViewPersonal.Refresh();

                    //for showing total Expenses Amount....
                    textBoxTotalAmount.Text =Convert.ToString(lstQryPersonalIncomeExpensesEntryList.Where(x=>x.IsExpenses==true).Sum(x => x.Amount));


                }
                else
                {
                    dataGridViewPersonal.DataSource = null;
                    dataGridViewPersonal.Refresh();
                    textBoxTotalAmount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonPersonalNew_Click(object sender, EventArgs e)
        {
            ClearAllPersonal();
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radioButtonCurrentMonth_CheckedChanged(object sender, EventArgs e)
        {
            LoadPersonalForCurrentAndPreviousMonth();
        }

        private void radioButtonPreviousMonth_CheckedChanged(object sender, EventArgs e)
        {
            LoadPersonalForCurrentAndPreviousMonth();
        }

        private void dataGridViewPersonal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripPersonal.Items.Clear();
                contextMenuStripPersonal.Items.Add("Edit");
                contextMenuStripPersonal.Items.Add("Delete");
                contextMenuStripPersonal.Show(dataGridViewPersonal, new Point(e.X, e.Y));
            }
        }

        private void dataGridViewPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void contextMenuStripPersonal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {

            if (e.ClickedItem.ToString() == "Edit")
            {

                textBoxAmount.Text = lstQryPersonalIncomeExpensesEntryList[selectedIndex].Amount.ToString();
                dateTimePickerEntryDatePersonal.Value = Convert.ToDateTime(lstQryPersonalIncomeExpensesEntryList[selectedIndex].EntryDate);
                comboBoxPerson.SelectedValue = lstQryPersonalIncomeExpensesEntryList[selectedIndex].PersonID;
                comboBoxItem.SelectedValue = lstQryPersonalIncomeExpensesEntryList[selectedIndex].ItemID;
                textBoxDescription.Text = lstQryPersonalIncomeExpensesEntryList[selectedIndex].Description;
                buttonPersonalUpdate.Visible = true;
                buttonPersonalCancel.Visible = true;
                buttonPersonalNew.Visible = false;
                buttonPersonalSave.Visible = false;
                groupBoxDailyMarket.Text = "Edit Personal Income && Expenses";

            }
            if (e.ClickedItem.ToString() == "Delete")
            {
                //MessageBox.Show("Delete Clicked");
                if (MessageBox.Show("Are You Sure?", "Personal Income & Expenses Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    List<Tbl_PersonalIncomeExpensesEntry> lstPersonalIncomeExpensesList = new List<Tbl_PersonalIncomeExpensesEntry>();
                    lstPersonalIncomeExpensesList = objTbl_PersonalIncomeExpensesEntryService.GetAllData().Where(x => x.rowID == lstQryPersonalIncomeExpensesEntryList[selectedIndex].rowID
                        ).ToList();
                    if (lstPersonalIncomeExpensesList.Count > 0)
                    {
                        //lstPersonalIncomeExpensesList[0].PersonID = Convert.ToInt32(comboBoxPerson.SelectedValue);
                        //lstPersonalIncomeExpensesList[0].ExtraItemID = Convert.ToInt32(comboBoxItem.SelectedValue);
                        //lstPersonalIncomeExpensesList[0].Amount = Convert.ToDouble(textBoxAmount.Text);
                        //lstPersonalIncomeExpensesList[0].EntryDate = dateTimePickerEntryDatePersonal.Value;
                        objTbl_PersonalIncomeExpensesEntryService.DeleteIncomeExpensesSelectByID(lstPersonalIncomeExpensesList[0].rowID);

                        MessageBox.Show("Successfully Deleted");
                        LoadPersonalForCurrentAndPreviousMonth();
                    }

                }
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void buttonPersonalUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (PersonalFieldCheck() == true)
                {


                    if (MessageBox.Show("Are You Sure?", "Personal Income & Expenses Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_PersonalIncomeExpensesEntry objTbl_PersonalIncomeExpensesEntry = new Tbl_PersonalIncomeExpensesEntry();

                        List<Tbl_PersonalIncomeExpensesEntry> lstPersonalIncomeExpensesList = new List<Tbl_PersonalIncomeExpensesEntry>();
                        lstPersonalIncomeExpensesList = objTbl_PersonalIncomeExpensesEntryService.GetAllData().Where(x => x.rowID == lstQryPersonalIncomeExpensesEntryList[selectedIndex].rowID 
                            ).ToList();
                        if (lstPersonalIncomeExpensesList.Count > 0)
                        {
                            lstPersonalIncomeExpensesList[0].PersonID = Convert.ToInt32(comboBoxPerson.SelectedValue);
                            lstPersonalIncomeExpensesList[0].ItemID = Convert.ToInt32(comboBoxItem.SelectedValue);
                            lstPersonalIncomeExpensesList[0].Amount = Convert.ToDouble(textBoxAmount.Text);
                            lstPersonalIncomeExpensesList[0].EntryDate = dateTimePickerEntryDatePersonal.Value;
                            lstPersonalIncomeExpensesList[0].LastUpdate = DateTime.Now;
                            lstPersonalIncomeExpensesList[0].Description = textBoxDescription.Text;
                            objTbl_PersonalIncomeExpensesEntryService.UpdateIncomeExpenses(lstPersonalIncomeExpensesList[0]);

                            MessageBox.Show("Successfully Updated");
                            LoadPersonalForCurrentAndPreviousMonth();
                        }

                        buttonPersonalUpdate.Visible = false;
                        buttonPersonalCancel.Visible = false;
                        buttonPersonalSave.Visible = true;
                        buttonPersonalNew.Visible = true;
                        groupBoxDailyMarket.Text = "Personal Income & Expenses Entry";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPersonalCancel_Click(object sender, EventArgs e)
        {
            buttonPersonalUpdate.Visible = false;
            buttonPersonalCancel.Visible = false;
            buttonPersonalNew.Visible = true;
            buttonPersonalSave.Visible = true;
            ClearAllPersonal();
            groupBoxDailyMarket.Text = "Personal Income & Expenses Entry";
        }
        //User Define Class....
        public class PersonalFinalCalculation
        {
            public string PersonName { get; set; }
            public double TotalIncome { get; set; }
            public double TotalExpenses { get; set; }
            public double FinalTaka { get; set; }


        }

        private void rbtnIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIsUtility_CheckedChanged(object sender, EventArgs e)
        {
            LoadExtraExpensesMaster();
            LoadPersonalForCurrentAndPreviousMonth();
        }

        private void checkBoxIsExpense_CheckedChanged(object sender, EventArgs e)
        {
            //LoadExtraExpensesMaster();
            //LoadPersonalForCurrentAndPreviousMonth();
        }

        private void comboBoxExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPersonalForCurrentAndPreviousMonth();
            //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.Where(x => x.ExtraItemID ==Convert.ToInt32( comboBoxExpenses.SelectedValue)).ToList();
        }

        private void dateTimePickerEntryDatePersonal_ValueChanged(object sender, EventArgs e)
        {
            //LoadPersonalForAnyDate();
        }
        private void LoadPersonalForAnyDate()
        {
            try
            {

                objQry_PersonalIncomeExpensesEntryService = new Qry_PersonalIncomeExpensesEntryService();
                lstQryPersonalIncomeExpensesEntryList = objQry_PersonalIncomeExpensesEntryService.GetQryAllData().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDatePersonal.Value.Year
                    && x.EntryDate.Value.Month == dateTimePickerEntryDatePersonal.Value.Month).ToList();
                if (lstQryPersonalIncomeExpensesEntryList.Count > 0)
                {
                    lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                    dataGridViewPersonal.AutoGenerateColumns = false;
                    dataGridViewPersonal.DataSource = null;
                    dataGridViewPersonal.DataSource = lstQryPersonalIncomeExpensesEntryList;
                    dataGridViewPersonal.Refresh();


                    //for showing total Expenses Amount....
                    textBoxTotalAmount.Text = Convert.ToString(lstQryPersonalIncomeExpensesEntryList.Where(x => x.IsExpenses == true).Sum(x => x.Amount));
                }
                else
                {
                    dataGridViewPersonal.DataSource = null;
                    dataGridViewPersonal.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadPersonalForAnyDate();
        }
    }
}
