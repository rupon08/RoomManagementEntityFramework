using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using RoomData;
using RoomService;


namespace RoomManagementEntityFramework
{
    public partial class LogIn : Form
    {
        public static string globalVariable;
        public LogIn()
        {
            InitializeComponent();
        }
        private void backgroundWorkerRoom_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerRoom.ReportProgress(5);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(10);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(15);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(20);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(25);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(30);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(35);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(40);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(45);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(50);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(55);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(60);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(65);
            Thread.Sleep(200);
            backgroundWorkerRoom.ReportProgress(70);
            Thread.Sleep(300);
            backgroundWorkerRoom.ReportProgress(80);
            Thread.Sleep(300);
            backgroundWorkerRoom.ReportProgress(90);
            Thread.Sleep(600);
            backgroundWorkerRoom.ReportProgress(100);
            Thread.Sleep(200);
        }

        private void backgroundWorkerRoom_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarRoom.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerRoom_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //labelUserName.Visible = true;
            //labelPassWord.Visible = true;
            //textBoxUserId.Visible = true;
            //textBoxPassWord.Visible = true;
            //buttonCancel.Visible = true;
            //buttonLogIn.Visible = true;
            //progressBarRoom.Visible = false;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            progressBarRoom.Minimum = 0;
            progressBarRoom.Maximum = 100;
            progressBarRoom.Value = 100;
            labelUserName.Visible = true;
            labelPassWord.Visible = true;
            textBoxUserId.Visible = true;
            textBoxPassWord.Visible = true;
            buttonCancel.Visible = true;
            buttonLogIn.Visible = true;
       }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Tbl_LoginService objTbl_LoginService = new Tbl_LoginService();
            List<Tbl_Login> lstLoginList = new List<Tbl_Login>();
            lstLoginList = objTbl_LoginService.GetAllData().Where(x=> x.uid==textBoxUserId.Text.Trim()
                && x.upwd == textBoxPassWord.Text.Trim()).ToList();

            if (lstLoginList.Count > 0)
            {

                    this.Hide();
                    MainForm objMainForm = new MainForm();
                    objMainForm.Show();
                   //Code to Show Login User Name....
                    objMainForm.labelUser.Text = "Welcome " + lstLoginList[0].uname;
                    //Code to Give Permission for New User....
                    if (lstLoginList[0].userType == "Admin")
                    {
                       // objFrmDailyMarket_Meal.buttonNewPerson.Visible = true;
                       
                    }
                    else
                    {
                       // objFrmDailyMarket_Meal.buttonNewPerson.Visible = false;
                        objMainForm.setupToolStripMenuItem.Enabled = false;
                        objMainForm.entryToolStripMenuItem.Enabled = false;

                    }
            }
            else
            {
                MessageBox.Show("Invalid User name or Password");
                textBoxUserId.Focus();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmNewUserCreate objFrmNewUserCreate = new FrmNewUserCreate();
            objFrmNewUserCreate.Show();
        }

        private void textBoxUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassWord.Focus();
            }
        }

        private void textBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              buttonLogIn.Focus();
            }
        }
      
        private void linkLabelEditUser_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmChangePassWord objFrmChangePassWord = new FrmChangePassWord();
            objFrmChangePassWord.ShowDialog();

        }
       
    }
}
