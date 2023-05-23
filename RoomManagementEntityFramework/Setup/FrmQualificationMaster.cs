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
    public partial class FrmQualificationMaster : Form
    {
        Tbl_qualificationMasterService objTbl_qualificationMasterService = new Tbl_qualificationMasterService();
        List<Tbl_qualificationMaster> lstQualificationMasterList = new List<Tbl_qualificationMaster>();
        private int selectedIndex = 0;
        public FrmQualificationMaster()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearAllQualification();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (QualificationFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "Qualification Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_qualificationMaster objTbl_qualificationMaster = new Tbl_qualificationMaster();
                        objTbl_qualificationMaster.qualificationName = textQualificationName.Text;
                        objTbl_qualificationMasterService.InsertQualification(objTbl_qualificationMaster);
                        if (objTbl_qualificationMaster.qualificationCode != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllQualification();
                            ClearAllQualification();
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
        private bool QualificationFieldCheck()
        {

            if (textQualificationName.Text == "")
            {
                MessageBox.Show("Please Enter Qualification Name");
                textQualificationName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LoadAllQualification()
        {
            try
            {
                lstQualificationMasterList = objTbl_qualificationMasterService.GetAllData().ToList();

                if (lstQualificationMasterList.Count > 0)
                {
                    dataGridViewQualificationMaster.AutoGenerateColumns = false;
                    dataGridViewQualificationMaster.DataSource = null;
                    dataGridViewQualificationMaster.DataSource = lstQualificationMasterList;
                    dataGridViewQualificationMaster.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAllQualification()
        {
            textQualificationName.Text = "";
        }

        private void FrmQualificationMaster_Load(object sender, EventArgs e)
        {
            LoadAllQualification();
        }

        private void dataGridViewQualificationMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are You Sure?", "Qualification Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Tbl_qualificationMaster objTbl_qualificationMaster = new Tbl_qualificationMaster();
                    List<Tbl_qualificationMaster> lstQualificationMasterList1 = new List<Tbl_qualificationMaster>();
                    lstQualificationMasterList1 = objTbl_qualificationMasterService.GetAllData().Where(x => x.qualificationCode == lstQualificationMasterList[selectedIndex].qualificationCode).ToList();
                    if (lstQualificationMasterList1.Count > 0)
                    {
                        lstQualificationMasterList1[0].qualificationName = textQualificationName.Text;

                        objTbl_qualificationMasterService.UpdateQualification(lstQualificationMasterList1[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllQualification();
                    }

                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = true;
                    buttonNew.Visible = true;
                    ClearAllQualification();

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
            ClearAllQualification();
        }

        private void dataGridViewQualificationMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripQualification.Items.Clear();
                contextMenuStripQualification.Items.Add("Edit");
                contextMenuStripQualification.Items.Add("Delete");
                contextMenuStripQualification.Show(dataGridViewQualificationMaster, new Point(e.X, e.Y));
            }
        }

        private void contextMenuStripQualification_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {
                textQualificationName.Text = lstQualificationMasterList[selectedIndex].qualificationName;
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
                buttonNew.Visible = false;
                buttonSave.Visible = false;

            }
        }
    }
}
