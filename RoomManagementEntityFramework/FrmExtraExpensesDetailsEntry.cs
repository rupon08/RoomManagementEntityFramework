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
    public partial class FrmExtraExpensesDetailsEntry : Form
    {
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        Tbl_extraExpensesMstService objTbl_extraExpensesMstService = new Tbl_extraExpensesMstService();
        Tbl_ExtraExpensesDtlsEntryService objTbl_ExtraExpensesDtlsEntryService = new Tbl_ExtraExpensesDtlsEntryService();
        Qry_ExtraExpensesDtlsEntryService objQry_ExtraExpensesDtlsEntryService = new Qry_ExtraExpensesDtlsEntryService();
        List<Qry_ExtraExpensesDtlsEntry> lstQry_ExtraExpensesDtlsEntryList = new List<Qry_ExtraExpensesDtlsEntry>();
        private int selectedIndex=0;
        public FrmExtraExpensesDetailsEntry()
        {
            InitializeComponent();
        }

        private void FrmExtraExpensesDetailsEntry_Load(object sender, EventArgs e)
        {
            LoadAllPerson();
            LoadExtraExpensesMaster();
            LoadAllExtraExpesDetails();
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
                    comboBoxPersonMarket.ValueMember = dt.Columns[0].ColumnName;
                    comboBoxPersonMarket.DisplayMember = dt.Columns[1].ColumnName;
                    comboBoxPersonMarket.DataSource = dt;

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
                lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().ToList();
                if (lstExtraExpensesMasterList.Count > 0)
                {
                    Tbl_ExpensesMst objTbl_extraExpensesMst = new Tbl_ExpensesMst();
                    objTbl_extraExpensesMst.rowID = 0;
                    objTbl_extraExpensesMst.ItemName = "Select Extra Item";
                    lstExtraExpensesMasterList.Add(objTbl_extraExpensesMst);
                    lstExtraExpensesMasterList = lstExtraExpensesMasterList.Where(x => x.IsExtratExpenses==true && x.IsActive==true).OrderBy(x => x.rowID).ToList();
                    //cmbExtExpItem.DataSource = null;
                    //cmbExtExpItem.DisplayMember = "extraItemName";
                    //cmbExtExpItem.ValueMember = "rowID";
                    //cmbExtExpItem.DataSource = lstExtraExpensesMasterList;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("rowID");
                    dt.Columns.Add("extraItemName");
                    foreach (Tbl_ExpensesMst objExtraExpenses in lstExtraExpensesMasterList)
                    {
                        dt.Rows.Add(objExtraExpenses.rowID, objExtraExpenses.ItemName);
                    }
                    cmbExtExpItem.ValueMember = dt.Columns[0].ColumnName;
                    cmbExtExpItem.DisplayMember = dt.Columns[1].ColumnName;
                    cmbExtExpItem.DataSource = dt;         

                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExtraExpensesFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "Extra Expenses Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        Tbl_ExtraExpensesDtlsEntry objTbl_ExtraExpensesDtlsEntry = new Tbl_ExtraExpensesDtlsEntry();
                        objTbl_ExtraExpensesDtlsEntry.PersonName = Convert.ToInt32(comboBoxPersonMarket.SelectedValue);
                        objTbl_ExtraExpensesDtlsEntry.expID = Convert.ToInt32(cmbExtExpItem.SelectedValue);
                        objTbl_ExtraExpensesDtlsEntry.expAmt = Convert.ToInt32(txtAmt.Text);
                        objTbl_ExtraExpensesDtlsEntry.entryDate = dtpDate.Value.Date;
                        objTbl_ExtraExpensesDtlsEntry.Description = textBoxExtExpDesc.Text;
                        objTbl_ExtraExpensesDtlsEntry.LastUpdate = DateTime.Now;
            
 
                        objTbl_ExtraExpensesDtlsEntryService.InsertExtraExpensesDetail(objTbl_ExtraExpensesDtlsEntry);
                        if (objTbl_ExtraExpensesDtlsEntry.rowID != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllExtraExpesDetails();
                            ClearAllExtraExpenses();
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
        private bool ExtraExpensesFieldCheck()
        {
            if (cmbExtExpItem.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select an Item");
                cmbExtExpItem.Focus();
                return false;
            }
            else if (txtAmt.Text == "")
            {
                MessageBox.Show("Enter an Amount");
                txtAmt.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearAllExtraExpenses()
        {
            txtAmt.Text = "";
            dtpDate.Value = DateTime.Today;
            cmbExtExpItem.SelectedIndex = 0;
            textBoxExtExpDesc.Text = "";
        }
        private void LoadAllExtraExpesDetails()
        {
            
            //List<Qry_ExtraExpensesDtlsEntry> lstQry_ExtraExpensesDtlsEntryList = new List<Qry_ExtraExpensesDtlsEntry>();
            objQry_ExtraExpensesDtlsEntryService = new Qry_ExtraExpensesDtlsEntryService();
            lstQry_ExtraExpensesDtlsEntryList = objQry_ExtraExpensesDtlsEntryService.GetQryAllData().Where(x => x.entryDate.Value.Year == dtpDate.Value.Year 
                && x.entryDate.Value.Month==dtpDate.Value.Month).ToList();
            if (lstQry_ExtraExpensesDtlsEntryList.Count > 0)
            {
                dgvExtExpDtl.AutoGenerateColumns = false;
                dgvExtExpDtl.DataSource = null;
                dgvExtExpDtl.DataSource = lstQry_ExtraExpensesDtlsEntryList;
                dgvExtExpDtl.Refresh();
            }
            else
            {
                dgvExtExpDtl.DataSource = null;
                dgvExtExpDtl.Refresh();
            }
        }

        private void dgvExtExpDtl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripExtraExpenses.Items.Clear();
                contextMenuStripExtraExpenses.Items.Add("Edit");
                contextMenuStripExtraExpenses.Items.Add("Delete");
                contextMenuStripExtraExpenses.Show(dgvExtExpDtl, new Point(e.X, e.Y));
            }
        }

        private void contextMenuStripExtraExpenses_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                comboBoxPersonMarket.SelectedValue = Convert.ToInt32(lstQry_ExtraExpensesDtlsEntryList[selectedIndex].PersonName);
                cmbExtExpItem.SelectedValue = Convert.ToString(lstQry_ExtraExpensesDtlsEntryList[selectedIndex].rowID);
                txtAmt.Text = lstQry_ExtraExpensesDtlsEntryList[selectedIndex].expAmt.ToString();
                dtpDate.Value = Convert.ToDateTime(lstQry_ExtraExpensesDtlsEntryList[selectedIndex].entryDate);
                textBoxExtExpDesc.Text = lstQry_ExtraExpensesDtlsEntryList[selectedIndex].Description;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnNew.Visible = false;
                btnSave.Visible = false;
             

            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Extra Expenses Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Tbl_ExtraExpensesDtlsEntry objTbl_ExtraExpensesDtlsEntry = new Tbl_ExtraExpensesDtlsEntry();
                    List<Tbl_ExtraExpensesDtlsEntry> lstExtraExpensesDtlsEntryList = new List<Tbl_ExtraExpensesDtlsEntry>();
                    lstExtraExpensesDtlsEntryList = objTbl_ExtraExpensesDtlsEntryService.GetAllData().Where(x => x.rowID == lstQry_ExtraExpensesDtlsEntryList[selectedIndex].ExtraDetailRowID).ToList();
                    if (lstExtraExpensesDtlsEntryList.Count > 0)
                    {
                        lstExtraExpensesDtlsEntryList[0].PersonName = Convert.ToInt32(comboBoxPersonMarket.SelectedValue);
                        lstExtraExpensesDtlsEntryList[0].expAmt =Convert.ToInt32(txtAmt.Text);
                        lstExtraExpensesDtlsEntryList[0].entryDate = dtpDate.Value;
                        lstExtraExpensesDtlsEntryList[0].LastUpdate = DateTime.Now;
                        lstExtraExpensesDtlsEntryList[0].expID = Convert.ToInt32(cmbExtExpItem.SelectedValue);
                        lstExtraExpensesDtlsEntryList[0].Description = textBoxExtExpDesc.Text;
                        objTbl_ExtraExpensesDtlsEntryService.UpdateExtraExpensesDetail(lstExtraExpensesDtlsEntryList[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllExtraExpesDetails();
                    }

                    btnUpdate.Visible = false;
                    btnCancel.Visible = false;
                    btnSave.Visible = true;
                    btnNew.Visible = true;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvExtExpDtl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            btnNew.Visible = true;
            btnSave.Visible = true;
            ClearAllExtraExpenses();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAllExtraExpesDetails();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllExtraExpenses();
        }

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
