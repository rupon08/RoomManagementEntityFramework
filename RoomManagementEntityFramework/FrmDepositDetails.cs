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
    public partial class FrmDepositDetails : Form
    {
        int selectedIndex = 0;
        Tbl_DepositMasterService objTbl_DepositMasterService = new Tbl_DepositMasterService();
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        Tbl_DepositDetailsEntryService objTbl_DepositDetailsEntryService = new Tbl_DepositDetailsEntryService();
        List<Qry_DepositEntry> lstQry_DepositEntryList = new List<Qry_DepositEntry>();
        Qry_DepositEntryService objQry_DepositEntryService = new Qry_DepositEntryService();
        public FrmDepositDetails()
        {
            InitializeComponent();
        }

        private void FrmDepositDetails_Load(object sender, EventArgs e)
        {
            LoadDepositMaster();
            LoadAllPerson();
            LoadDeposit();
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

        private void LoadDepositMaster()
        {
            try
            {
                List<Tbl_DepositMaster> lstDepositMasterList = new List<Tbl_DepositMaster>();


                lstDepositMasterList = objTbl_DepositMasterService.GetAllData().Where(x => x.IsActive == true).ToList();

                if (lstDepositMasterList.Count > 0)
                {
                    Tbl_DepositMaster objTbl_DepositMaster = new Tbl_DepositMaster();
                    objTbl_DepositMaster.rowID = 0;
                    objTbl_DepositMaster.ItemName = "Select an Item";
                    lstDepositMasterList.Add(objTbl_DepositMaster);
                    lstDepositMasterList = lstDepositMasterList.OrderBy(x => x.rowID).ToList();
                    //cmbExtExpItem.DataSource = null;
                    //cmbExtExpItem.DisplayMember = "extraItemName";
                    //cmbExtExpItem.ValueMember = "rowID";
                    //cmbExtExpItem.DataSource = lstExtraExpensesMasterList;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("rowID");
                    dt.Columns.Add("extraItemName");
                   
                    foreach (Tbl_DepositMaster objExtraExpenses in lstDepositMasterList)
                    {
                        dt.Rows.Add(objExtraExpenses.rowID, objExtraExpenses.ItemName);
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
        private bool DepositFieldCheck()
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
            //else if (dateTimePickerEntryDatePersonal.Value.Year > DateTime.Now.Year)
            //{
            //    MessageBox.Show("Select Only Current Year");
            //    dateTimePickerEntryDatePersonal.Focus();
            //    return false;
            //}
            else
            {
                return true;
            }
        }

        private void buttonDepositSave_Click(object sender, EventArgs e)
        {
            if (DepositFieldCheck() == true)
            {

                //Validation for Duplicate Entry for Deposit....
                List<Tbl_DepositDetailsEntry> lstDepositList = new List<Tbl_DepositDetailsEntry>();
                objTbl_DepositDetailsEntryService = new Tbl_DepositDetailsEntryService();
                lstDepositList = objTbl_DepositDetailsEntryService.GetAllData().Where(x => x.EntryDate.Value.Date == dateTimePickerEntryDateDeposit.Value.Date
                    && x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)
                    && x.PersonID == Convert.ToInt32(comboBoxPerson.SelectedValue)
                    ).ToList();
                if (lstDepositList.Count > 0)
                {
                    MessageBox.Show("Data already Exist for this Item");
                    return;
                }

                if (MessageBox.Show("Are You Sure?", "Deposit Details Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_DepositDetailsEntry objTbl_DepositDetailsEntry = new Tbl_DepositDetailsEntry();
                    objTbl_DepositDetailsEntry.PersonID = Convert.ToInt32(comboBoxPerson.SelectedValue);
                    objTbl_DepositDetailsEntry.ItemID = Convert.ToInt32(comboBoxItem.SelectedValue);
                    objTbl_DepositDetailsEntry.Amount = Convert.ToDouble(textBoxAmount.Text);
                    objTbl_DepositDetailsEntry.EntryDate = dateTimePickerEntryDateDeposit.Value;
                    objTbl_DepositDetailsEntryService.InsertDeposit(objTbl_DepositDetailsEntry);
                    if (objTbl_DepositDetailsEntry.rowID != 0)
                    {
                        MessageBox.Show("Data Successfully Inserted");
                        LoadDeposit();
                        Load_TotalYear_Remaining();
                        //ClearAllDeposit();
                        //dateTimePickerEntryDateDeposit.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }

            }

        }
        private void LoadDeposit()
        {
            try
            {
                objQry_DepositEntryService = new Qry_DepositEntryService();
                //Checking for Current Month....
               

                    
                        //if not selected any particular Item then loading all Item....
                        if (comboBoxItem.SelectedIndex == 0)
                        {
                            lstQry_DepositEntryList = objQry_DepositEntryService.GetQryAllData().ToList();
                            //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();

                        }
                        else
                        {
                            lstQry_DepositEntryList = objQry_DepositEntryService.GetQryAllData().Where(x => x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
                        }
                        //Loading Item in List by Descending Order....
                        //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.OrderByDescending(x => x.EntryDate).ToList();
                   

                
                    if (lstQry_DepositEntryList.Count > 0)
                    {
                       lstQry_DepositEntryList = lstQry_DepositEntryList.OrderByDescending(x => x.EntryDate).ToList();
                       //lstQryPersonalIncomeExpensesEntryList = lstQryPersonalIncomeExpensesEntryList.Where(x => x.ExtraItemID == Convert.ToInt32(comboBoxExpenses.SelectedValue)).ToList();
                       dataGridViewDeposit.AutoGenerateColumns = false;
                       dataGridViewDeposit.DataSource = null;
                       dataGridViewDeposit.DataSource = lstQry_DepositEntryList;
                       dataGridViewDeposit.Refresh();

                      
                   }
                   else
                   {
                    dataGridViewDeposit.DataSource = null;
                    dataGridViewDeposit.Refresh();
                   
                   }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        private void dataGridViewDeposit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void dataGridViewDeposit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripDeposit.Items.Clear();
                contextMenuStripDeposit.Items.Add("Edit");
                contextMenuStripDeposit.Items.Add("Delete");
                contextMenuStripDeposit.Show(dataGridViewDeposit, new Point(e.X, e.Y));
            }
        }

        private void contextMenuStripDeposit_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {

                textBoxAmount.Text = lstQry_DepositEntryList[selectedIndex].Amount.ToString();
                dateTimePickerEntryDateDeposit.Value = Convert.ToDateTime(lstQry_DepositEntryList[selectedIndex].EntryDate);
                comboBoxPerson.SelectedValue = lstQry_DepositEntryList[selectedIndex].PersonID;
                comboBoxItem.SelectedValue = lstQry_DepositEntryList[selectedIndex].ItemID;
                buttonDepositUpdate.Visible = true;
                buttonDepositCancel.Visible = true;
                buttonDepositNew.Visible = false;
                buttonDepositSave.Visible = false;
                groupBoxDailyMarket.Text = "Edit Deposit";

            }
        }

        private void buttonDepositUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepositFieldCheck() == true)
                {


                    if (MessageBox.Show("Are You Sure?", "Deposit Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_DepositDetailsEntry objTbl_DepositDetailsEntry = new Tbl_DepositDetailsEntry();

                        List<Tbl_DepositDetailsEntry> lstDepositDetailsEntryList = new List<Tbl_DepositDetailsEntry>();
                        lstDepositDetailsEntryList = objTbl_DepositDetailsEntryService.GetAllData().Where(x => x.rowID == lstQry_DepositEntryList[selectedIndex].rowID
                            ).ToList();
                        if (lstDepositDetailsEntryList.Count > 0)
                        {
                            lstDepositDetailsEntryList[0].PersonID = Convert.ToInt32(comboBoxPerson.SelectedValue);
                            lstDepositDetailsEntryList[0].ItemID = Convert.ToInt32(comboBoxItem.SelectedValue);
                            lstDepositDetailsEntryList[0].Amount = Convert.ToDouble(textBoxAmount.Text);
                            lstDepositDetailsEntryList[0].EntryDate = dateTimePickerEntryDateDeposit.Value;
                            objTbl_DepositDetailsEntryService.UpdateDeposit(lstDepositDetailsEntryList[0]);

                            MessageBox.Show("Successfully Updated");
                            LoadDeposit();
                        }

                        buttonDepositUpdate.Visible = false;
                        buttonDepositCancel.Visible = false;
                        buttonDepositSave.Visible = true;
                        buttonDepositNew.Visible = true;
                        groupBoxDailyMarket.Text = "Personal Income & Expenses Entry";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDepositCancel_Click(object sender, EventArgs e)
        {
            buttonDepositUpdate.Visible = false;
            buttonDepositCancel.Visible = false;
            buttonDepositNew.Visible = true;
            buttonDepositSave.Visible = true;
            ClearAllDeposit();
            groupBoxDailyMarket.Text = "Deposit Entry";
        }
        private void ClearAllDeposit()
        {
            textBoxAmount.Text = "";
            dateTimePickerEntryDateDeposit.Value = DateTime.Today;
            comboBoxPerson.SelectedIndex = 0;
            comboBoxItem.SelectedIndex = 0;
            textBoxTotYear.Text = "";
            textBoxRemaining.Text = "";
            textBoxTotalAmount.Text = "";
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRemaining.Text = "";
            textBoxTotalAmount.Text = "";
            textBoxTotYear.Text = "";
            //Function for Loading Deposit Amount
            LoadDeposit(); 
            if (comboBoxItem.SelectedIndex != 0)
            {

                Load_TotalYear_Remaining();
            }

        }
        private void Load_TotalYear_Remaining()
        {
            List<Tbl_DepositMaster> lstDepositMasterList = new List<Tbl_DepositMaster>();
            objTbl_DepositMasterService = new Tbl_DepositMasterService();
            lstDepositMasterList = objTbl_DepositMasterService.GetAllData().Where(x => x.rowID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
            textBoxTotYear.Text = lstDepositMasterList[0].TotalYear.ToString();

            //calculation fo Remaining Year
            float totalMonth;
            float remainingMonth;
            totalMonth = Convert.ToInt32(lstDepositMasterList[0].TotalYear) * 12;
            //MessageBox.Show(totalMonth.ToString());
            objTbl_DepositDetailsEntryService = new Tbl_DepositDetailsEntryService();
            List<Tbl_DepositDetailsEntry> lstDepositDetailsEntryList = new List<Tbl_DepositDetailsEntry>();
            lstDepositDetailsEntryList = objTbl_DepositDetailsEntryService.GetAllData().Where(x => x.ItemID == Convert.ToInt32(comboBoxItem.SelectedValue)).ToList();
            if (lstDepositDetailsEntryList.Count > 0)
            {
                //for DPS Part....
                if(lstDepositMasterList[0].Identification=="D")
                {
                  remainingMonth = totalMonth - lstDepositDetailsEntryList.Count;
                  textBoxRemaining.Text = (remainingMonth/12).ToString();
                }
                //for SonchoyPotro Part....
                if (lstDepositMasterList[0].Identification == "S")
                {
                    DateTime sonchoyPotroEntryDate;
                    DateTime currentDate;
                    float monthDiff;

                    sonchoyPotroEntryDate = (DateTime)lstDepositDetailsEntryList[0].EntryDate;
                    currentDate = DateTime.Now;
                    monthDiff = (currentDate.Month - sonchoyPotroEntryDate.Month) + 12 * (currentDate.Year - sonchoyPotroEntryDate.Year);
                    remainingMonth = totalMonth - monthDiff;
                    textBoxRemaining.Text = (remainingMonth / 12).ToString();
                }
               
            }
            
        }

        private void buttonDepositNew_Click(object sender, EventArgs e)
        {
            ClearAllDeposit();
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {

                double toBeDiscarded = 0;
                
                List<Tbl_DepositMaster> lstDepositMasterList = new List<Tbl_DepositMaster>();
                lstDepositMasterList = objTbl_DepositMasterService.GetAllData().Where(x => x.IsActive == false).ToList();


                objTbl_DepositDetailsEntryService = new Tbl_DepositDetailsEntryService();
                List<Tbl_DepositDetailsEntry> lstDepositDetailsEntryList = new List<Tbl_DepositDetailsEntry>();
                lstDepositDetailsEntryList = objTbl_DepositDetailsEntryService.GetAllData().ToList();

                //for getting not Active Data to be avoided
                List<Tbl_DepositDetailsEntry> lstDepositInActive = new List<Tbl_DepositDetailsEntry>();
                for (int i = 0; i < lstDepositMasterList.Count; i++)
                {

                    objTbl_DepositDetailsEntryService = new Tbl_DepositDetailsEntryService();
                    lstDepositInActive = objTbl_DepositDetailsEntryService.GetAllData().Where(x => x.ItemID == lstDepositMasterList[i].rowID
                        ).ToList();

                    toBeDiscarded = toBeDiscarded + (int)lstDepositInActive.Sum(x => x.Amount);

                }
                 
                if (lstDepositDetailsEntryList.Count > 0)
                {
                    //for showing total Expenses Amount....
                    //textBoxTotalAmount.Text = Convert.ToString(lstDepositDetailsEntryList.Sum(x => x.Amount) - (361361+100000+386467) ); //Remove(since not active) ItemID-1,2,7 from Tbl_DepositDetailsEntry
                    textBoxTotalAmount.Text = Convert.ToString(lstDepositDetailsEntryList.Sum(x => x.Amount) - toBeDiscarded);

                }
                else
                {
                    textBoxTotalAmount.Text = "";
                }
            }
            else
            {
                textBoxTotalAmount.Text = "";
            }
        }
    }
}
