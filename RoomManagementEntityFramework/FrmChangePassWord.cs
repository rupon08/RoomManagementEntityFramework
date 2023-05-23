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
    public partial class FrmChangePassWord : Form
    {
        string oldPassWord = "";
        Tbl_LoginService objTbl_LoginService = new Tbl_LoginService();
        public FrmChangePassWord()
        {
            InitializeComponent();
        }

        private void FrmChangePassWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogIn objLogIn = new LogIn();
            objLogIn.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            selectedRow = FrmNewUserCreateSearch.Selectone();
            if (selectedRow != null && selectedRow.Selected == true)
            {
                textBoxAutoID.Text = selectedRow.Cells["ClmRowID"].Value.ToString();
                textBoxUserId.Text = selectedRow.Cells["ClmUserId"].Value.ToString();
                textBoxUserName.Text = selectedRow.Cells["ClmUserName"].Value.ToString();
                oldPassWord = selectedRow.Cells["ClmUserPassWord"].Value.ToString();
                //textBoxPassWord.ReadOnly = true;
                if (selectedRow.Cells["ClmUserType"].Value.ToString() == "Admin")
                {
                    radioButtonAdmin.Checked = true;
                }
                else
                {
                    radioButtonUser.Checked = true;
                }
               
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text.Trim() != oldPassWord)
            {
                MessageBox.Show("Old PassWord is not Correct");
                textBoxPassWord.Focus();
                return;
            }
            if (MessageBox.Show("Are You Sure?", "New User Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Tbl_Login objTbl_Login = new Tbl_Login();

                List<Tbl_Login> lstLoginList = new List<Tbl_Login>();
                lstLoginList = objTbl_LoginService.GetAllData().Where(x => x.rowID == Convert.ToInt32(textBoxAutoID.Text.Trim())).ToList();

                if (lstLoginList.Count > 0)
                {
                    lstLoginList[0].uid = textBoxUserId.Text;
                    lstLoginList[0].uname = textBoxUserName.Text;
                    lstLoginList[0].upwd = textBoxNewPassWord.Text;
                    if (radioButtonAdmin.Checked == true)
                    {
                        lstLoginList[0].userType = "Admin";
                    }
                    else
                    {
                        lstLoginList[0].userType = "User";
                    }
                    objTbl_LoginService.UpdateLogIn(lstLoginList[0]);
                    MessageBox.Show("PassWord Successfully Updated");

                }

            }
        }
    }
}
