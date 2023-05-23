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
    public partial class FrmNewUserCreateSearch : Form
    {
        DataGridViewRow selectedRow = new DataGridViewRow();
        Tbl_LoginService objTbl_LoginService = new Tbl_LoginService();
        public FrmNewUserCreateSearch()
        {
            InitializeComponent();
        }
        public static DataGridViewRow Selectone()
        {
            DataGridViewRow selectedRowTemp = null;
            FrmNewUserCreateSearch objFrmNewUserCreateSearch = new FrmNewUserCreateSearch();
            objFrmNewUserCreateSearch.ShowDialog();
            selectedRowTemp = objFrmNewUserCreateSearch.selectedRow;
            return selectedRowTemp;

        }
        private void FrmNewUserCreateSearch_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }
        private void LoadUserList()
        {
            objTbl_LoginService = new Tbl_LoginService();
            List<Tbl_Login> lstLogInList = new List<Tbl_Login>();
            lstLogInList = objTbl_LoginService.GetAllData().ToList();
            dataGridViewUserList.DataSource = null;
            dataGridViewUserList.DataSource = lstLogInList;
            dataGridViewUserList.Refresh();

        }
        private void dataGridViewUserList_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewUserList.SelectedRows;
            if (selectedRows != null && selectedRows.Count > 0)
            {
                selectedRow = selectedRows[0];
            }
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string utype = "";
            if (radioButtonAdmin.Checked)
            {
                utype = "A";
            }
            else
            {
                utype = "U";
            }
            List<Tbl_Login> lstLogInList = new List<Tbl_Login>();
            lstLogInList = objTbl_LoginService.GetAllData().Where(x=>x.uid==textBoxUserId.Text.Trim()
                || x.uname == textBoxUserName.Text.Trim() || x.userType == utype).ToList();
            dataGridViewUserList.DataSource = null;
            dataGridViewUserList.DataSource = lstLogInList;
            dataGridViewUserList.Refresh();
        }
    }
}
