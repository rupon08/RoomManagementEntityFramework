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
    public partial class FrmProfessionMaster : Form
    {
        Tbl_professionMasterService objTbl_professionMasterService = new Tbl_professionMasterService();
        List<Tbl_professionMaster> lstProfessionMasterList = new List<Tbl_professionMaster>();
        private int selectedIndex = 0;
        public FrmProfessionMaster()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProfessionFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "Profession Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Tbl_professionMaster objTbl_professionMaster = new Tbl_professionMaster();
                        objTbl_professionMaster.professionName = textProfessionName.Text;
                        objTbl_professionMasterService.InsertProfession(objTbl_professionMaster);
                        if (objTbl_professionMaster.professionCode != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllProfession();
                            ClearAllProfession();
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
        private bool ProfessionFieldCheck()
        {

            if (textProfessionName.Text == "")
            {
                MessageBox.Show("Please Enter Profession Name");
                textProfessionName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LoadAllProfession()
        {
            try
            {
                lstProfessionMasterList = objTbl_professionMasterService.GetAllData().ToList();

                if (lstProfessionMasterList.Count > 0)
                {
                    dataGridViewProfessionMaster.AutoGenerateColumns = false;
                    dataGridViewProfessionMaster.DataSource = null;
                    dataGridViewProfessionMaster.DataSource = lstProfessionMasterList;
                    dataGridViewProfessionMaster.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAllProfession()
        {
            textProfessionName.Text = "";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearAllProfession();
        }

        private void FrmProfessionMaster_Load(object sender, EventArgs e)
        {
            LoadAllProfession();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are You Sure?", "Profession Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_professionMaster objTbl_professionMaster = new Tbl_professionMaster();
                    List<Tbl_professionMaster> lstProfessionMasterList1 = new List<Tbl_professionMaster>();
                    lstProfessionMasterList1 = objTbl_professionMasterService.GetAllData().Where(x => x.professionCode == lstProfessionMasterList[selectedIndex].professionCode).ToList();
                    if (lstProfessionMasterList1.Count > 0)
                    {
                        lstProfessionMasterList1[0].professionName = textProfessionName.Text;

                        objTbl_professionMasterService.UpdateProfession(lstProfessionMasterList1[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllProfession();
                    }

                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = true;
                    buttonNew.Visible = true;
                    ClearAllProfession();

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
            ClearAllProfession();
        }

        private void dataGridViewProfessionMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripProfession.Items.Clear();
                contextMenuStripProfession.Items.Add("Edit");
                contextMenuStripProfession.Items.Add("Delete");
                contextMenuStripProfession.Show(dataGridViewProfessionMaster, new Point(e.X, e.Y));
            }
        }

        private void contextMenuStripProfession_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                textProfessionName.Text = lstProfessionMasterList[selectedIndex].professionName;
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
                buttonNew.Visible = false;
                buttonSave.Visible = false;

            }
        }
    }
}
