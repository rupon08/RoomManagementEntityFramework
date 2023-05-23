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
    public partial class FrmCountryMaster : Form
    {
        Tbl_CountryMasterService objTbl_CountryMasterService = new Tbl_CountryMasterService();
        List<Tbl_CountryMaster> lstCountryMasterList = new List<Tbl_CountryMaster>();
        private int selectedIndex=0;
        public FrmCountryMaster()
        {
            InitializeComponent();
        }
        private bool CountryFieldCheck()
        {
            if (textBoxCountryName.Text == "")
            {
                MessageBox.Show("Please Enter Country Name");
                textBoxCountryName.Focus();
                return false;
            }
      
            else
            {
                return true;
            }
        }
       
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CountryFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "Country Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Tbl_CountryMaster objTbl_CountryMaster = new Tbl_CountryMaster();
                        objTbl_CountryMaster.countryName = textBoxCountryName.Text;
                        objTbl_CountryMasterService.InsertCountry(objTbl_CountryMaster);
                        if (objTbl_CountryMaster.countryCode != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                            LoadAllCountry();
                            ClearAllCountry();
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
        private void LoadAllCountry()
        {
            try
            {
                lstCountryMasterList = objTbl_CountryMasterService.GetAllData().ToList();

                if (lstCountryMasterList.Count > 0)
                {
                    dataGridViewCountryMaster.AutoGenerateColumns = false;
                    dataGridViewCountryMaster.DataSource = null;
                    dataGridViewCountryMaster.DataSource = lstCountryMasterList;
                    dataGridViewCountryMaster.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAllCountry()
        {
            textBoxCountryName.Text = "";

        }

        private void FrmCountryMaster_Load(object sender, EventArgs e)
        {
            LoadAllCountry();
        }

        private void contextMenuStripCountry_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {

                textBoxCountryName.Text = lstCountryMasterList[selectedIndex].countryName;
              
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
                buttonNew.Visible = false;
                buttonSave.Visible = false;

            }
        }

        private void dataGridViewCountryMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripCountry.Items.Clear();
                contextMenuStripCountry.Items.Add("Edit");
                contextMenuStripCountry.Items.Add("Delete");
                contextMenuStripCountry.Show(dataGridViewCountryMaster, new Point(e.X, e.Y));
            }
        }

        private void dataGridViewCountryMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Are You Sure?", "Country Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_CountryMaster objTbl_CountryMaster = new Tbl_CountryMaster();
                    List<Tbl_CountryMaster> lstCountryMasterList1 = new List<Tbl_CountryMaster>();
                    lstCountryMasterList1 = objTbl_CountryMasterService.GetAllData().Where(x => x.countryCode == lstCountryMasterList[selectedIndex].countryCode).ToList();
                    if (lstCountryMasterList1.Count > 0)
                    {
                        lstCountryMasterList1[0].countryName = textBoxCountryName.Text;

                        objTbl_CountryMasterService.UpdateCountry(lstCountryMasterList1[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllCountry();
                    }

                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = true;
                    buttonNew.Visible = true;
                    ClearAllCountry();

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
            ClearAllCountry();
        }
    }
}
