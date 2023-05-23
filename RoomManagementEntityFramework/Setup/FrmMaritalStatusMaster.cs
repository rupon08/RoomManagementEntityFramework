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

namespace RoomManagementEntityFramework.Setup
{
    public partial class FrmMaritalStatusMaster : Form
    {
        Tbl_maritalStatusMasterService objTbl_maritalStatusMasterService = new Tbl_maritalStatusMasterService();
        List<Tbl_maritalStatusMaster> lstMaritalStatusMasterList = new List<Tbl_maritalStatusMaster>();
        private int selectedIndex = 0;
        public FrmMaritalStatusMaster()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaritalFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "Marital Status Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_maritalStatusMaster objTbl_maritalStatusMaster = new Tbl_maritalStatusMaster();
                        objTbl_maritalStatusMaster.maritalName = textMaritalStatusName.Text;
                       objTbl_maritalStatusMasterService.InsertMaritalStatus(objTbl_maritalStatusMaster);
                       if (objTbl_maritalStatusMaster.marialCode != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllMaritalStatus();
                            ClearAllMaritalStatus();
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
        private void LoadAllMaritalStatus()
        {
            try
            {
                lstMaritalStatusMasterList = objTbl_maritalStatusMasterService.GetAllData().ToList();

                if (lstMaritalStatusMasterList.Count > 0)
                {
                    dataGridViewMaritalStatusMaster.AutoGenerateColumns = false;
                    dataGridViewMaritalStatusMaster.DataSource = null;
                    dataGridViewMaritalStatusMaster.DataSource = lstMaritalStatusMasterList;
                    dataGridViewMaritalStatusMaster.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool MaritalFieldCheck()
        {

            if (textMaritalStatusName.Text == "")
            {
                MessageBox.Show("Please Enter Marital Status Name");
                textMaritalStatusName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearAllMaritalStatus()
        {
            textMaritalStatusName.Text = "";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearAllMaritalStatus();
        }

        private void FrmMaritalStatusMaster_Load(object sender, EventArgs e)
        {
            LoadAllMaritalStatus();
        }

        private void contextMenuStripMaritalStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                textMaritalStatusName.Text = lstMaritalStatusMasterList[selectedIndex].maritalName;
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
                buttonNew.Visible = false;
                buttonSave.Visible = false;
            }
        }

        private void dataGridViewMaritalStatusMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripMaritalStatus.Items.Clear();
                contextMenuStripMaritalStatus.Items.Add("Edit");
                contextMenuStripMaritalStatus.Items.Add("Delete");
                contextMenuStripMaritalStatus.Show(dataGridViewMaritalStatusMaster, new Point(e.X, e.Y));
            }
        }

        private void dataGridViewMaritalStatusMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are You Sure?", "Marital Status Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_maritalStatusMaster objTbl_maritalStatusMaster = new Tbl_maritalStatusMaster();
                    List<Tbl_maritalStatusMaster> lstMaritalStatusMasterList1 = new List<Tbl_maritalStatusMaster>();
                    lstMaritalStatusMasterList1 = objTbl_maritalStatusMasterService.GetAllData().Where(x => x.marialCode == lstMaritalStatusMasterList[selectedIndex].marialCode).ToList();
                    if (lstMaritalStatusMasterList1.Count > 0)
                    {
                        lstMaritalStatusMasterList1[0].maritalName = textMaritalStatusName.Text;

                        objTbl_maritalStatusMasterService.UpdateMaritalStatus(lstMaritalStatusMasterList1[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllMaritalStatus();
                    }

                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = true;
                    buttonNew.Visible = true;
                    ClearAllMaritalStatus();

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
            ClearAllMaritalStatus();
        }

    }
}
