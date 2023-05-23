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

namespace RoomManagementEntityFramework.Setup
{
    public partial class FrmExtraExpensesMaster : Form
    {
        Tbl_extraExpensesMstService objTbl_extraExpensesMstService = new Tbl_extraExpensesMstService();
        List<Tbl_ExpensesMst> lstExtraExpensesList = new List<Tbl_ExpensesMst>();
        int selectedIndex = 0;
        public FrmExtraExpensesMaster()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExtraExpensesFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "Expenses Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_ExpensesMst objTbl_extraExpensesMst = new Tbl_ExpensesMst();
                        objTbl_extraExpensesMst.ItemName = textBoxExpensesName.Text;
                        objTbl_extraExpensesMst.IsActive = checkBoxIsActive.Checked;
                        if (checkBoxIsExpense.Checked)
                        {
                            objTbl_extraExpensesMst.IsExpenses = true;
                        }
                        else
                        {
                            objTbl_extraExpensesMst.IsExpenses = false;
                        }

                        if (checkBoxIsUtility.Checked == true)
                        {
                            objTbl_extraExpensesMst.IsUtilities = true;

                        }
                        else
                        {
                            objTbl_extraExpensesMst.IsUtilities = false;
                        }

                        objTbl_extraExpensesMstService.InsertExtraExpenses(objTbl_extraExpensesMst);
                        if (objTbl_extraExpensesMst.rowID != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllExtraExpenses();
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
            if (textBoxExpensesName.Text == "")
            {
                MessageBox.Show("Please Enter Expenses Name");
                textBoxExpensesName.Focus();
                return false;
            }
           
            else
            {
                return true;
            }
        }
        private void LoadAllExtraExpenses()
        {
            try
            {
                objTbl_extraExpensesMstService = new Tbl_extraExpensesMstService();

                //if (checkBoxIsUtility.Checked)
                //{
                    lstExtraExpensesList = objTbl_extraExpensesMstService.GetAllData().ToList();
                //}
                //else
                //{
                //    lstExtraExpensesList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.IsUtilities == false).ToList();
                //}
                if (lstExtraExpensesList.Count > 0)
                {

                    dataGridViewExtraExpenses.AutoGenerateColumns = false;
                    dataGridViewExtraExpenses.DataSource = null;
                    dataGridViewExtraExpenses.DataSource = lstExtraExpensesList;
                    dataGridViewExtraExpenses.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAllExtraExpenses()
        {

            textBoxExpensesName.Text = "";

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Expenses Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    List<Tbl_ExpensesMst> lstExtraExpensesMasterList = new List<Tbl_ExpensesMst>();
                    lstExtraExpensesMasterList = objTbl_extraExpensesMstService.GetAllData().Where(x => x.rowID == lstExtraExpensesList[selectedIndex].rowID).ToList();
                    if (lstExtraExpensesMasterList.Count > 0)
                    {
                        lstExtraExpensesMasterList[0].ItemName = textBoxExpensesName.Text;
                        lstExtraExpensesMasterList[0].IsExpenses = checkBoxIsExpense.Checked? true:false;
                        lstExtraExpensesMasterList[0].IsUtilities = checkBoxIsUtility.Checked ? true : false;

                        objTbl_extraExpensesMstService.UpdateExtraExpenses(lstExtraExpensesMasterList[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllExtraExpenses();
                    }

                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = true;
                    buttonNew.Visible = true;
                    ClearAllExtraExpenses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = false;
            buttonCancel.Visible = false;
            buttonNew.Visible = true;
            buttonSave.Visible = true;
            ClearAllExtraExpenses();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearAllExtraExpenses();
        }

        private void dataGridViewExtraExpenses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                contextMenuStripExtraExpenses.Items.Clear();
                contextMenuStripExtraExpenses.Items.Add("Edit");
                contextMenuStripExtraExpenses.Items.Add("Delete");
                contextMenuStripExtraExpenses.Show(dataGridViewExtraExpenses, new Point(e.X, e.Y));
            }
        }

        private void dataGridViewExtraExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void contextMenuStripExtraExpenses_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                textBoxExpensesName.Text = lstExtraExpensesList[selectedIndex].ItemName;
                checkBoxIsUtility.Checked = lstExtraExpensesList[selectedIndex].IsUtilities == true ? true : false;
                if (lstExtraExpensesList[selectedIndex].IsExpenses == true)
                {
                    checkBoxIsExpense.Checked = true;
                }
                else
                {
                    checkBoxIsExpense.Checked = false;
                }
                
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
                buttonNew.Visible = false;
                buttonSave.Visible = false;

            }
        }

        private void FrmExtraExpensesMaster_Load(object sender, EventArgs e)
        {
            LoadAllExtraExpenses();
        }

        private void checkBoxIsExpense_CheckedChanged(object sender, EventArgs e)
        {
            //LoadAllExtraExpenses();
        }

        private void checkBoxIsUtility_CheckedChanged(object sender, EventArgs e)
        {
            //LoadAllExtraExpenses();
        }
    }
}
