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
using System.IO;
using RoomManagementEntityFramework.Setup;


namespace RoomManagementEntityFramework
{
    public partial class FrmPersonEntry : Form
    {
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        Tbl_qualificationMasterService objTbl_qualificationMasterService = new Tbl_qualificationMasterService();
        Tbl_professionMasterService objTbl_professionMasterService = new Tbl_professionMasterService();
        Tbl_cityMasterService objTbl_cityMasterService = new Tbl_cityMasterService();
        Tbl_CountryMasterService objTbl_CountryMasterService = new Tbl_CountryMasterService();
        Tbl_maritalStatusMasterService objTbl_maritalStatusMasterService = new Tbl_maritalStatusMasterService();
        Tbl_PersonPhotoService objTbl_PersonPhotoService = new Tbl_PersonPhotoService();
         
        string NE = "";
        public static string DefaultNoImagePath = AppDomain.CurrentDomain.BaseDirectory + "noimageavailable.jpg"; 
        byte[] picbyte1 = new byte[] { };
        Image imgApplicant;
        string imgApplicantFile = "";
        //String imagePath = "";
        
        public FrmPersonEntry()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PersonFieldCheck() == true)
                {
                   //string file_path = "./RoomManagementEntityFramework/Photos" + "/";
                   string file_path ="E:/Sws&Proj/My Proj/RoomManagementEntityFramework/RoomManagementEntityFramework/Photos" + "/";
                    
                    string full_path="";
                    string file_name="";
                    file_name = Path.GetFileName(imgApplicantFile);

                    if (NE == "N")
                    {
                        if (MessageBox.Show("Are You Sure?", "Person Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry = new Tbl_PersonDetailsEntry();
                            objTbl_PersonDetailsEntry.Name = textBoxName.Text;
                            objTbl_PersonDetailsEntry.FatherName = textBoxFatherName.Text;
                            objTbl_PersonDetailsEntry.MotherName = textBoxMotherName.Text;
                            objTbl_PersonDetailsEntry.Qualification = Convert.ToInt32(comboBoxQualification.SelectedValue);
                            objTbl_PersonDetailsEntry.Profession = Convert.ToInt32(comboBoxProfession.SelectedValue);
                            objTbl_PersonDetailsEntry.MaritalStatus = Convert.ToInt32(comboBoxMaritalStatus.SelectedValue);
                            objTbl_PersonDetailsEntry.DOB = dateTimePickerDOB.Value;
                            objTbl_PersonDetailsEntry.Address = textBoxAddress.Text;
                            objTbl_PersonDetailsEntry.City = Convert.ToInt32(comboBoxCity.SelectedValue);
                            objTbl_PersonDetailsEntry.ZipCode = Convert.ToInt32(textBoxZipCode.Text);
                            objTbl_PersonDetailsEntry.Country = Convert.ToInt32(comboBoxCountry.SelectedValue);
                            objTbl_PersonDetailsEntry.CreateDate = DateTime.Now;
                            objTbl_PersonDetailsEntry.LastUpdate = DateTime.Now;
                            objTbl_PersonDetailsEntry.IsActive = checkBoxIsActive.Checked;
                            objTbl_PersonDetailsEntry.IsPersonalIncomeExpenses = checkBoxPersonal.Checked;
                            objTbl_PersonDetailEntryService.InsertPerson(objTbl_PersonDetailsEntry);

                            if (objTbl_PersonDetailsEntry.rowID != 0)
                            {
                                full_path = file_path + file_name;
                                pictureBoxPersonPhoto.Image.Save(full_path);

                                Tbl_PersonPhoto objTbl_PersonPhoto = new Tbl_PersonPhoto();
                                objTbl_PersonPhoto.PersonPhoto = full_path;
                                objTbl_PersonPhoto.PersonID = objTbl_PersonDetailsEntry.rowID;
                                objTbl_PersonPhotoService.InsertPhoto(objTbl_PersonPhoto);
                                MessageBox.Show("Data Successfully Inserted");
                                LoadPersonList();
                                ClearPersonData();
                            }
                            else
                            {
                                MessageBox.Show("Data Not Inserted");
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are You Sure?", "Person Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<Tbl_PersonDetailsEntry> lstPersonDetailsEntryList = new List<Tbl_PersonDetailsEntry>();
                            lstPersonDetailsEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true
                                && x.rowID == Convert.ToInt32(lbPersonList.SelectedValue)).ToList();
                            if (lstPersonDetailsEntryList.Count > 0)
                            {
                                lstPersonDetailsEntryList[0].Name = textBoxName.Text;
                                lstPersonDetailsEntryList[0].FatherName = textBoxFatherName.Text;
                                lstPersonDetailsEntryList[0].MotherName = textBoxMotherName.Text;
                                lstPersonDetailsEntryList[0].Qualification = Convert.ToInt32(comboBoxQualification.SelectedValue);
                                lstPersonDetailsEntryList[0].Profession = Convert.ToInt32(comboBoxProfession.SelectedValue);
                                lstPersonDetailsEntryList[0].MaritalStatus = Convert.ToInt32(comboBoxMaritalStatus.SelectedValue);
                                lstPersonDetailsEntryList[0].DOB = dateTimePickerDOB.Value;
                                lstPersonDetailsEntryList[0].Address = textBoxAddress.Text;
                                lstPersonDetailsEntryList[0].City = Convert.ToInt32(comboBoxCity.SelectedValue);
                                lstPersonDetailsEntryList[0].ZipCode = Convert.ToInt32(textBoxZipCode.Text);
                                lstPersonDetailsEntryList[0].Country = Convert.ToInt32(comboBoxCountry.SelectedValue);
                                lstPersonDetailsEntryList[0].LastUpdate = DateTime.Now;
                                lstPersonDetailsEntryList[0].IsActive = checkBoxIsActive.Checked;
                                lstPersonDetailsEntryList[0].IsPersonalIncomeExpenses = checkBoxPersonal.Checked;

                                List<Tbl_PersonPhoto> lstPersonPic = new List<Tbl_PersonPhoto>();
                                lstPersonPic = objTbl_PersonPhotoService.GetAllData().Where(x => x.PersonID == Convert.ToInt32(lbPersonList.SelectedValue)).ToList();
                                if ( (lstPersonPic.Count > 0) && (imgApplicantFile != "")  )
                                {
                                    full_path = file_path + file_name;
                                    lstPersonPic[0].PersonPhoto = full_path;
                                    lstPersonPic[0].PersonID = lstPersonDetailsEntryList[0].rowID;
                                    objTbl_PersonPhotoService.UpdatePhoto(lstPersonPic[0]);
                                }
                                else if (imgApplicantFile != "")
                                {
                                    full_path = file_path + file_name;
                                    pictureBoxPersonPhoto.Image.Save(full_path);
                                    
                                    Tbl_PersonPhoto objTbl_PersonPhoto = new Tbl_PersonPhoto();
                                    objTbl_PersonPhoto.PersonPhoto = full_path;
                                    objTbl_PersonPhoto.PersonID = Convert.ToInt32(lbPersonList.SelectedValue);
                                    objTbl_PersonPhotoService.InsertPhoto(objTbl_PersonPhoto);

                                }
                                objTbl_PersonDetailEntryService.UpdatePerson(lstPersonDetailsEntryList[0]);
                                if(imgApplicantFile != "")
                                       pictureBoxPersonPhoto.Image.Save(full_path);
                                MessageBox.Show("Data Successfully Updated");
                                LoadPersonList();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private bool PersonFieldCheck()
        {
          
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please Enter Person Name");
                textBoxName.Focus();
                return false;
            }
            else if (textBoxFatherName.Text == "")
            {
                MessageBox.Show("Please Enter Father Name");
                textBoxFatherName.Focus();
                return false;
            }
            else if (textBoxMotherName.Text == "")
            {
                MessageBox.Show("Please Enter Mother Name");
                textBoxMotherName.Focus();
                return false;
            }
            else if ( comboBoxQualification.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Qualification");
                comboBoxQualification.Focus();
                return false;
            }
            else if (comboBoxProfession.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Profession");
                comboBoxProfession.Focus();
                return false;
            }
            else if (comboBoxMaritalStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Marital Status");
                comboBoxMaritalStatus.Focus();
                return false;
            }
            else if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address");
                textBoxAddress.Focus();
                return false;
            }
            else if (comboBoxCity.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select City");
                comboBoxCity.Focus();
                return false;
            }
            else if (textBoxZipCode.Text == "")
            {
                MessageBox.Show("Please Enter Zip Code");
                textBoxZipCode.Focus();
                return false;
            }
            else if (comboBoxCountry.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Country");
                comboBoxCountry.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearPersonData()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            //textBoxName.Focus();
            textBoxFatherName.Text = "";
            textBoxMotherName.Text = "";
            comboBoxQualification.SelectedIndex = 0;
            comboBoxProfession.SelectedIndex = 0;
            comboBoxMaritalStatus.SelectedIndex = 0;
            dateTimePickerDOB.Value = DateTime.Now;
            textBoxAddress.Text = "";
            comboBoxCity.SelectedIndex = 0;
            textBoxZipCode.Text = "";
            comboBoxCountry.SelectedIndex = 0;
            pictureBoxPersonPhoto.Image = null;
        }
        private void FrmPersonEntry_Load(object sender, EventArgs e)
        {
            LoadPersonList();
            LoadQualificationMaster();
            LoadProfessionMaster();
            LoadMaritalStatusMaster();
            LoadCityMaster();
            LoadCountryMaster();
        }
        
        private void LoadPersonList()
        {
            groupBoxPersonInfo.Enabled = false;
            groupBoxPersonPhoto.Enabled = false;
            lbPersonList.Enabled = true;
            buttonNew.Enabled = true;
            buttonEdit.Enabled = true;
            buttonUndo.Enabled = false;
            buttonSave.Enabled = false;
            List<Tbl_PersonDetailsEntry> lstPersonDetailsEntryList = new List<Tbl_PersonDetailsEntry>();
            lstPersonDetailsEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x=> x.IsActive==true).ToList();
            lbPersonList.DataSource = lstPersonDetailsEntryList;
           lbPersonList.DisplayMember = "Name";
            lbPersonList.ValueMember = "rowID";
        }
        private void LoadQualificationMaster()
        {
            Tbl_qualificationMaster objTbl_qualificationMaster = new Tbl_qualificationMaster();
            objTbl_qualificationMaster.qualificationCode = 0; 
            objTbl_qualificationMaster.qualificationName = "Select Qualification";


            List<Tbl_qualificationMaster> lstqualificationMasterList=new List<Tbl_qualificationMaster>();
            lstqualificationMasterList = objTbl_qualificationMasterService.GetAllData().ToList();
            lstqualificationMasterList.Add(objTbl_qualificationMaster);
            lstqualificationMasterList = lstqualificationMasterList.OrderBy(x => x.qualificationCode).ToList();
            comboBoxQualification.DataSource = lstqualificationMasterList;
            comboBoxQualification.DisplayMember = "qualificationName";
            comboBoxQualification.ValueMember = "qualificationCode";
        }
        private void LoadProfessionMaster()
        {
            Tbl_professionMaster objTbl_professionMaster = new Tbl_professionMaster();
            objTbl_professionMaster.professionCode = 0;
            objTbl_professionMaster.professionName = "Select Profession";

            List<Tbl_professionMaster> lstprofessionMasterList=new List<Tbl_professionMaster>();
            lstprofessionMasterList = objTbl_professionMasterService.GetAllData().ToList();
            lstprofessionMasterList.Add(objTbl_professionMaster);
            lstprofessionMasterList = lstprofessionMasterList.OrderBy(x => x.professionCode).ToList();
              comboBoxProfession.DataSource = lstprofessionMasterList;
            comboBoxProfession.DisplayMember = "professionName";
            comboBoxProfession.ValueMember = "professionCode";
        }
        private void LoadMaritalStatusMaster()
        {
            Tbl_maritalStatusMaster objTbl_maritalStatusMaster = new Tbl_maritalStatusMaster();
            objTbl_maritalStatusMaster.marialCode = 0;
            objTbl_maritalStatusMaster.maritalName = "Select Marital Status";
            
            List<Tbl_maritalStatusMaster> lstmaritalStatusMasterList=new List<Tbl_maritalStatusMaster>();
            lstmaritalStatusMasterList = objTbl_maritalStatusMasterService.GetAllData().ToList();
            lstmaritalStatusMasterList.Add(objTbl_maritalStatusMaster);
            lstmaritalStatusMasterList = lstmaritalStatusMasterList.OrderBy(x => x.marialCode).ToList();
            comboBoxMaritalStatus.DataSource = lstmaritalStatusMasterList;
            comboBoxMaritalStatus.DisplayMember = "maritalName";
            comboBoxMaritalStatus.ValueMember = "marialCode";
        }
        private void LoadCityMaster()
        {
            Tbl_cityMaster objTbl_cityMaster = new Tbl_cityMaster();
            objTbl_cityMaster.cityCode = 0;
            objTbl_cityMaster.cityName = "Select City";
            
            List<Tbl_cityMaster> lstTbl_cityMasterList = new List<Tbl_cityMaster>();
            lstTbl_cityMasterList = objTbl_cityMasterService.GetAllData().ToList();
            lstTbl_cityMasterList.Add(objTbl_cityMaster);
            lstTbl_cityMasterList = lstTbl_cityMasterList.OrderBy(x => x.countryCode).ToList();
            // comboBoxCity.DataSource =lstTbl_cityMasterList;
            //comboBoxCity.DisplayMember = "cityName";
            //comboBoxCity.ValueMember = "cityCode";
            DataTable dt = new DataTable();
            dt.Columns.Add("cityCode");
            dt.Columns.Add("cityName");
            foreach (Tbl_cityMaster objCity in lstTbl_cityMasterList)
            {
                dt.Rows.Add(objCity.cityCode, objCity.cityName);
            }
            comboBoxCity.ValueMember = dt.Columns[0].ColumnName;
            comboBoxCity.DisplayMember = dt.Columns[1].ColumnName;
            comboBoxCity.DataSource = dt;         
        }
        private void LoadCountryMaster()
        {
            Tbl_CountryMaster objTbl_CountryMaster = new Tbl_CountryMaster();
            objTbl_CountryMaster.countryCode= 0;
            objTbl_CountryMaster.countryName = "Select Country";
            List<Tbl_CountryMaster> lstCountryMasterList=new List<Tbl_CountryMaster>();
            lstCountryMasterList = objTbl_CountryMasterService.GetAllData().ToList();
            lstCountryMasterList.Add(objTbl_CountryMaster);
            lstCountryMasterList = lstCountryMasterList.OrderBy(x => x.countryCode).ToList();
            //Not selecting the combobox....
            // comboBoxCountry.DataSource =lstCountryMasterList;
            //comboBoxCountry.DisplayMember = "countryName";
            //comboBoxCountry.ValueMember = "countryCode";
            DataTable dt = new DataTable();
            dt.Columns.Add("countryCode");
            dt.Columns.Add("countryName");
            foreach (Tbl_CountryMaster objCountry in lstCountryMasterList)
            {
                dt.Rows.Add(objCountry.countryCode, objCountry.countryName);
            }
            comboBoxCountry.ValueMember = dt.Columns[0].ColumnName;
            comboBoxCountry.DisplayMember = dt.Columns[1].ColumnName;
            comboBoxCountry.DataSource = dt;         
        }

       

        private void lbPersonList_Click(object sender, EventArgs e)
        {
            List<Tbl_PersonDetailsEntry> lstPersonDetailsEntryList = new List<Tbl_PersonDetailsEntry>();
            lstPersonDetailsEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true
                && x.rowID == Convert.ToInt32(lbPersonList.SelectedValue)).ToList();
            textBoxID.Text = lstPersonDetailsEntryList[0].rowID.ToString(); 
            textBoxName.Text = lstPersonDetailsEntryList[0].Name;
            textBoxFatherName.Text = lstPersonDetailsEntryList[0].FatherName;
            textBoxMotherName.Text = lstPersonDetailsEntryList[0].MotherName;
            comboBoxQualification.SelectedValue = lstPersonDetailsEntryList[0].Qualification;
            comboBoxProfession.SelectedValue = lstPersonDetailsEntryList[0].Profession;
            comboBoxMaritalStatus.SelectedValue = lstPersonDetailsEntryList[0].MaritalStatus;
            dateTimePickerDOB.Value = Convert.ToDateTime(lstPersonDetailsEntryList[0].DOB);
            textBoxAddress.Text = lstPersonDetailsEntryList[0].Address;
            comboBoxCity.SelectedValue = lstPersonDetailsEntryList[0].City;
            textBoxZipCode.Text = lstPersonDetailsEntryList[0].ZipCode.ToString();
            comboBoxCountry.SelectedValue = lstPersonDetailsEntryList[0].Country;
            checkBoxIsActive.Checked =Convert.ToBoolean(lstPersonDetailsEntryList[0].IsActive);
            checkBoxPersonal.Checked = Convert.ToBoolean(lstPersonDetailsEntryList[0].IsPersonalIncomeExpenses);
            //Function to Retrieve Image....
            RetrievePersonImage();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {

                pictureBoxPersonPhoto.Image = null;
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select Picture...";
                op.Filter = "Bitmap File(.bmp)|*.bmp|JPEG File(.jpg)|*.jpg|PNG File(.png)|*.png";
                op.FilterIndex = 2;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    
                    Image im = new Bitmap(op.FileName);
                    imgApplicant = new Bitmap(im, new Size(126, 122));
                    pictureBoxPersonPhoto.Image = imgApplicant;
                    pictureBoxPersonPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgApplicantFile = op.FileName;

                }

                if (imgApplicantFile != "")
                {
                    
                    FileStream fs1;
                    fs1 = new FileStream(imgApplicantFile, FileMode.Open, FileAccess.Read);
                    picbyte1 = new byte[fs1.Length];
                    fs1.Read(picbyte1, 0, System.Convert.ToInt32(fs1.Length));
                    fs1.Close();
                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RetrievePersonImage()
        {
            try
            {
               
                List<Tbl_PersonPhoto> lstPersonPic = new List<Tbl_PersonPhoto>();
                lstPersonPic = objTbl_PersonPhotoService.GetAllData().Where(x=> x.PersonID==Convert.ToInt32(lbPersonList.SelectedValue)).ToList();
                if (lstPersonPic.Count > 0)
                {
                     pictureBoxPersonPhoto.ImageLocation = lstPersonPic[0].PersonPhoto;
                     pictureBoxPersonPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                else
                {
                    pictureBoxPersonPhoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void buttonNew_Click(object sender, EventArgs e)
        {
           ClearPersonData();
           NE = "N";
           groupBoxPersonInfo.Enabled = true;
           groupBoxPersonPhoto.Enabled = true;
           lbPersonList.Enabled = false;
           buttonNew.Enabled = false;
           buttonEdit.Enabled = false;
           buttonUndo.Enabled = true;
           buttonSave.Enabled = true;
           checkBoxPersonal.Checked = false;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
             lbPersonList.Enabled = true;
           lbPersonList.SelectedIndex = -1;
            groupBoxPersonInfo.Enabled = false;
           groupBoxPersonPhoto.Enabled = false;
            buttonNew.Enabled = true;
            buttonEdit.Enabled = true;
            buttonUndo.Enabled = false;
            buttonSave.Enabled = false;
            ClearPersonData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Please Select Person First");
                return;
            }
            NE = "E";
        groupBoxPersonInfo.Enabled = true;
        groupBoxPersonPhoto.Enabled = true;
        lbPersonList.Enabled = false;
        buttonEdit.Enabled = false;
        buttonNew.Enabled = false;
        buttonUndo.Enabled = true;
        buttonSave.Enabled = true;
    
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxPersonPhoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNewCity_Click(object sender, EventArgs e)
        {
            FrmCityMaster objFrmCityMaster = new FrmCityMaster();
            objFrmCityMaster.ShowDialog();
        }

        private void buttonNewCountry_Click(object sender, EventArgs e)
        {
            FrmCountryMaster objFrmCountryMaster = new FrmCountryMaster();
            objFrmCountryMaster.ShowDialog();
        }

        private void buttonNewMaritalStatus_Click(object sender, EventArgs e)
        {
            FrmMaritalStatusMaster objFrmMaritalStatusMaster = new FrmMaritalStatusMaster();
            objFrmMaritalStatusMaster.ShowDialog();

        }

        private void buttonNewQualification_Click(object sender, EventArgs e)
        {
            FrmQualificationMaster objFrmQualificationMaster = new FrmQualificationMaster();
            objFrmQualificationMaster.ShowDialog();
        }

        private void buttonNewProfession_Click(object sender, EventArgs e)
        {
            FrmProfessionMaster objFrmProfessionMaster = new FrmProfessionMaster();
            objFrmProfessionMaster.ShowDialog();
        }
        private void LoadAllPerson()
        {
            try
            {
                FrmDailyMarket_Meal objFrmDailyMarket_Meal = new FrmDailyMarket_Meal();
                List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList = new List<Tbl_PersonDetailsEntry>();
                lstPersonDetailEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true).ToList();
                if (lstPersonDetailEntryList.Count > 0)
                {
                    Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry = new Tbl_PersonDetailsEntry();
                    objTbl_PersonDetailsEntry.rowID = 0;
                    objTbl_PersonDetailsEntry.Name = "Select Person";
                    lstPersonDetailEntryList.Add(objTbl_PersonDetailsEntry);
                    lstPersonDetailEntryList = lstPersonDetailEntryList.OrderBy(x => x.rowID).ToList();
                    objFrmDailyMarket_Meal.comboBoxPersonMarket.DataSource = null;
                    objFrmDailyMarket_Meal.comboBoxPersonMarket.DisplayMember = "Name";
                    objFrmDailyMarket_Meal.comboBoxPersonMarket.ValueMember = "rowID";
                    objFrmDailyMarket_Meal.comboBoxPersonMarket.DataSource = lstPersonDetailEntryList;
                    objFrmDailyMarket_Meal.comboBoxPersonMarket.Refresh();

                }
                List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList1 = new List<Tbl_PersonDetailsEntry>();
                lstPersonDetailEntryList1 = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true).ToList();
                if (lstPersonDetailEntryList1.Count > 0)
                {
                    Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry = new Tbl_PersonDetailsEntry();
                    objTbl_PersonDetailsEntry.rowID = 0;
                    objTbl_PersonDetailsEntry.Name = "Select Person";
                    lstPersonDetailEntryList1.Add(objTbl_PersonDetailsEntry);
                    lstPersonDetailEntryList1 = lstPersonDetailEntryList1.OrderBy(x => x.rowID).ToList();
                    objFrmDailyMarket_Meal.comboBoxPersonMeal.DataSource = null;
                    objFrmDailyMarket_Meal.comboBoxPersonMeal.DisplayMember = "Name";
                    objFrmDailyMarket_Meal.comboBoxPersonMeal.ValueMember = "rowID";
                    objFrmDailyMarket_Meal.comboBoxPersonMeal.DataSource = lstPersonDetailEntryList1;
                    objFrmDailyMarket_Meal.comboBoxPersonMeal.Refresh();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmPersonEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LoadAllPerson();
        }
    }
}
