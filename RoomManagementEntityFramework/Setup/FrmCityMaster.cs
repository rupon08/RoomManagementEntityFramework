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
    public partial class FrmCityMaster : Form
    {
        Tbl_cityMasterService objTbl_cityMasterService = new Tbl_cityMasterService();
        Tbl_CountryMasterService objTbl_CountryMasterService = new Tbl_CountryMasterService();
        Qry_CityMasterService objQry_CityMasterService = new Qry_CityMasterService();
        List<Tbl_cityMaster> lstCityMasterList = new List<Tbl_cityMaster>();
        List<Tbl_CountryMaster> lstCountryMasterList = new List<Tbl_CountryMaster>();
        List<Qry_CityMaster> lstQry_CityMasterList = new List<Qry_CityMaster>();
        private int selectedIndex = 0;
        public FrmCityMaster()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CityFieldCheck() == true)
                {
                    if (MessageBox.Show("Are You Sure?", "City Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tbl_cityMaster objTbl_cityMaster = new Tbl_cityMaster();

                        objTbl_cityMaster.cityName = textBoxCityName.Text;
                        objTbl_cityMaster.zipCode =Convert.ToInt32(textBoxZipCode.Text);
                        objTbl_cityMaster.countryCode = Convert.ToInt32(comboBoxCountryName.SelectedValue);

                        objTbl_cityMasterService.InsertCity(objTbl_cityMaster);
                        if (objTbl_cityMaster.cityCode != 0)
                        {
                            MessageBox.Show("Data Successfully Inserted");
                           LoadAllCity();
                            ClearAllCity();
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
        private void LoadAllCity()
        {
            try
            {
                objQry_CityMasterService = new Qry_CityMasterService();
                lstQry_CityMasterList = objQry_CityMasterService.GetQryAllData().ToList();

                if (lstQry_CityMasterList.Count > 0)
                {
                    dataGridViewCityMaster.AutoGenerateColumns = false;
                    dataGridViewCityMaster.DataSource = null;
                    dataGridViewCityMaster.DataSource = lstQry_CityMasterList;
                    dataGridViewCityMaster.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAllCity()
        {
            textBoxCityName.Text = "";
            comboBoxCountryName.SelectedIndex = 0;
            textBoxZipCode.Text = "";


        }
        private bool CityFieldCheck()
        {
            if (textBoxCityName.Text=="")
            {
                MessageBox.Show("Please Enter City Name");
                textBoxCityName.Focus();
                return false;
            }
            else if (textBoxZipCode.Text == "")
            {
                MessageBox.Show("Please Enter Zip Code");
                textBoxZipCode.Focus();
                return false;
            }
            else if (comboBoxCountryName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Country");
                comboBoxCountryName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
         private void LoadAllCountry()
        {
            try
            {
              
                Tbl_CountryMaster objTbl_CountryMaster = new Tbl_CountryMaster();
                objTbl_CountryMaster.countryCode = 0;
                objTbl_CountryMaster.countryName = "Select Country";
                List<Tbl_CountryMaster> lstCountryMasterList = new List<Tbl_CountryMaster>();
                lstCountryMasterList = objTbl_CountryMasterService.GetAllData().ToList();
                lstCountryMasterList.Add(objTbl_CountryMaster);
                lstCountryMasterList = lstCountryMasterList.OrderBy(x => x.countryCode).ToList();
                //comboBoxCountryName.DataSource = lstCountryMasterList;
                //comboBoxCountryName.DisplayMember = "countryName";
                //comboBoxCountryName.ValueMember = "countryCode";
                DataTable dt = new DataTable();
                dt.Columns.Add("countryCode");
                dt.Columns.Add("countryName");
                foreach (Tbl_CountryMaster objCountry in lstCountryMasterList)
                {
                    dt.Rows.Add(objCountry.countryCode, objCountry.countryName);
                }
                comboBoxCountryName.ValueMember = dt.Columns[0].ColumnName;
                comboBoxCountryName.DisplayMember = dt.Columns[1].ColumnName;
                comboBoxCountryName.DataSource = dt;         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void FrmCityMaster_Load(object sender, EventArgs e)
        {
            LoadAllCity();
            LoadAllCountry();
        }

        private void buttonNewCountry_Click(object sender, EventArgs e)
        {
            FrmCountryMaster objFrmCountryMaster = new FrmCountryMaster();
            objFrmCountryMaster.ShowDialog();
        }

        private void contextMenuStripCity_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Edit")
            {

                textBoxCityName.Text = lstQry_CityMasterList[selectedIndex].cityName;
                textBoxZipCode.Text = lstQry_CityMasterList[selectedIndex].zipCode.ToString();
                comboBoxCountryName.SelectedValue = Convert.ToString(lstQry_CityMasterList[selectedIndex].countryCode);
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
                buttonNew.Visible = false;
                buttonSave.Visible = false;
           
            }
        }

        private void dataGridViewCityMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void dataGridViewCityMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripCity.Items.Clear();
                contextMenuStripCity.Items.Add("Edit");
                contextMenuStripCity.Items.Add("Delete");
                contextMenuStripCity.Show(dataGridViewCityMaster, new Point(e.X, e.Y));
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (MessageBox.Show("Are You Sure?", "City Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_cityMaster objTbl_cityMaster = new Tbl_cityMaster();
                    List<Tbl_cityMaster> lstCityMasterList = new List<Tbl_cityMaster>();
                    lstCityMasterList = objTbl_cityMasterService.GetAllData().Where(x => x.cityCode == lstQry_CityMasterList[selectedIndex].cityCode).ToList();
                    if (lstCityMasterList.Count > 0)
                    {
                        lstCityMasterList[0].cityName = textBoxCityName.Text;
                        lstCityMasterList[0].zipCode = Convert.ToInt32(textBoxZipCode.Text);
                        lstCityMasterList[0].countryCode = Convert.ToInt32(comboBoxCountryName.SelectedValue);
                        objTbl_cityMasterService.UpdateCity(lstCityMasterList[0]);

                        MessageBox.Show("Successfully Updated");
                        LoadAllCity();
                    }

                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = true;
                    buttonNew.Visible = true;
                    ClearAllCity();
                  
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
            ClearAllCity();
           
        }

        private void dataGridViewCityMaster_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripCity.Items.Clear();
                contextMenuStripCity.Items.Add("Edit");
                contextMenuStripCity.Items.Add("Delete");
                contextMenuStripCity.Show(dataGridViewCityMaster, new Point(e.X, e.Y));
            }
        }

        private void dataGridViewCityMaster_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearAllCity();
        }
    }
}
