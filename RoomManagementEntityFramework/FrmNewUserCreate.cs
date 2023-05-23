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
    public partial class FrmNewUserCreate : Form
    {
        Tbl_LoginService objTbl_LoginService = new Tbl_LoginService();
        public FrmNewUserCreate()
        {
            InitializeComponent();
        }
        private bool UserFieldCheck()
        {
           
            if ( textBoxUserId.Text =="")
            {
                MessageBox.Show("Please Enter User ID");
                textBoxUserId.Focus();
                return false;
            }
            
            else if (textBoxUserName.Text == "")
            {
                MessageBox.Show("Enter User Name");
                textBoxUserName.Focus();
                return false;
            }
            else if (textBoxPassWord.Text == "")
            {
                MessageBox.Show("Enter PassWord");
                textBoxPassWord.Focus();
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

                if (UserFieldCheck() == true)
                {
                    objTbl_LoginService = new Tbl_LoginService();
                    List<Tbl_Login> lstLoginList = new List<Tbl_Login>();
                    lstLoginList = objTbl_LoginService.GetAllData().ToList();
                    for (int i = 0; i < lstLoginList.Count; i++)
                    {
                        if (lstLoginList[i].userType == "A")
                        {
                            MessageBox.Show("Admin Already Exist");
                            return;
                        }
                    }
                    if (MessageBox.Show("Are you Sure", "Create New User", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        

                        Tbl_Login objTbl_Login = new Tbl_Login();
                        objTbl_Login.uid = textBoxUserId.Text.Trim();
                        objTbl_Login.upwd = textBoxPassWord.Text.Trim();
                        objTbl_Login.uname = textBoxUserName.Text.Trim();
                        if (radioButtonAdmin.Checked == true)
                        {
                            objTbl_Login.userType = "A";
                        }
                        else
                        {
                            objTbl_Login.userType = "U";
                        }
                        objTbl_LoginService.InsertLogIn(objTbl_Login);

                        if (objTbl_Login.rowID != 0)
                        {

                            MessageBox.Show("Data Successfully Inserted");
                            LoadUserList();
                            ClearUserData();
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
        private void LoadUserList()
        {
            objTbl_LoginService = new Tbl_LoginService();
            List<Tbl_Login> lstLogInList = new List<Tbl_Login>();
            lstLogInList = objTbl_LoginService.GetAllData().ToList();
        }
        private void ClearUserData()
        {
            textBoxAutoID.Text = "";
            textBoxUserId.Text="";
            textBoxPassWord.Text = "";
            textBoxPassWord.ReadOnly = false;
            textBoxUserName.Text = "";
            buttonSave.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void FrmNewUserCreate_Load(object sender, EventArgs e)
        {
            LoadUserList();
           
        }
       
        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearUserData();
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
                textBoxPassWord.Text = selectedRow.Cells["ClmUserPassWord"].Value.ToString();
                textBoxPassWord.ReadOnly = true;
                if (selectedRow.Cells["ClmUserType"].Value.ToString() == "A")
                {
                    radioButtonAdmin.Checked = true;
                   
                }
                else
                {
                    radioButtonUser.Checked = true;
                    
                }
                buttonSave.Enabled = false;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }

        }
       
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "New User Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_Login objTbl_Login = new Tbl_Login();

                    List<Tbl_Login> lstLoginList = new List<Tbl_Login>();
                    lstLoginList = objTbl_LoginService.GetAllData().Where(x => x.rowID==Convert.ToInt32(textBoxAutoID.Text.Trim())).ToList();

                    if (lstLoginList.Count > 0)
                    {
                        lstLoginList[0].uid = textBoxUserId.Text;
                        lstLoginList[0].uname = textBoxUserName.Text;
                        lstLoginList[0].upwd = textBoxPassWord.Text;
                        if (radioButtonAdmin.Checked == true)
                        {
                            lstLoginList[0].userType = "A";
                        }
                        else
                        {
                            lstLoginList[0].userType = "U";
                        }
                        objTbl_LoginService.UpdateLogIn(lstLoginList[0]);
                        MessageBox.Show("Successfully Updated");
                      
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete User?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                List<Tbl_Login> lstLoginList = new List<Tbl_Login>();
                lstLoginList = objTbl_LoginService.GetAllData().Where(x => x.rowID == Convert.ToInt32(textBoxAutoID.Text.Trim())).ToList();

                if (lstLoginList.Count > 0)
                {
                    objTbl_LoginService.DeleteLogInSelectByID(Convert.ToInt32(lstLoginList[0].rowID));
                   
                    MessageBox.Show("Data Successfully Deleted");
                }
            }
        }

        private void FrmNewUserCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogIn objLogIn = new LogIn();
            objLogIn.Show();
        }
    }
}
