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
    public partial class FrmMultipleDateEntry : Form
    {
        Tbl_PersonDetailEntryService objTbl_PersonDetailEntryService = new Tbl_PersonDetailEntryService();
        List<MultipleDateMealEntry> lstMultipleDateMealEntry = new List<MultipleDateMealEntry>();
        Tbl_DailyMealService objTbl_DailyMealService = new Tbl_DailyMealService();
        List<Qry_DailyMealEntry> lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
        public FrmMultipleDateEntry()
        {
            InitializeComponent();
        }

        private void FrmMultipleDateEntry_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            List<Tbl_PersonDetailsEntry> lstPersonDetailEntryList = new List<Tbl_PersonDetailsEntry>();
            lstPersonDetailEntryList = objTbl_PersonDetailEntryService.GetAllData().Where(x => x.IsActive == true).ToList();
            if (lstPersonDetailEntryList.Count > 0)
            {
                lstMultipleDateMealEntry.Clear();
                for (int i = 0; i < lstPersonDetailEntryList.Count; i++)
                {
                    //lstMultipleDateMealEntry.Clear();
                    MultipleDateMealEntry objMultipleDateMealEntry = new MultipleDateMealEntry();
                    objMultipleDateMealEntry.PersonID = lstPersonDetailEntryList[i].rowID;
                    objMultipleDateMealEntry.PersonName = lstPersonDetailEntryList[i].Name;
                    objMultipleDateMealEntry.EntryDate = dateTimePickerEntryDateMeal.Value.Date;
                    lstMultipleDateMealEntry.Add(objMultipleDateMealEntry);

                }
            }
            dataGridViewMeal.DataSource = null;
            dataGridViewMeal.DataSource = lstMultipleDateMealEntry;
            //for loading inserted Data already
            LoadAllMealForSelectedMonth();
        }
        private void LoadAllMealForSelectedMonth()
        {
            try
            {
                objTbl_DailyMealService = new Tbl_DailyMealService();
               
                    lstQry_DailyMealEntryList = new List<Qry_DailyMealEntry>();
                    lstQry_DailyMealEntryList = objTbl_DailyMealService.GetAllMeal().Where(x => x.EntryDate.Value.Year == dateTimePickerEntryDateMeal.Value.Year
               && x.EntryDate.Value.Month == dateTimePickerEntryDateMeal.Value.Month).ToList();
                    lstQry_DailyMealEntryList = lstQry_DailyMealEntryList.OrderByDescending(x => x.EntryDate).ToList();
               

                if (lstQry_DailyMealEntryList.Count > 0)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lstQry_DailyMealEntryList;
                    dataGridView1.Refresh();

                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Validation for Duplicate Entry for Meal....
            List<Tbl_DailyMealEntry> lstDailyMealList = new List<Tbl_DailyMealEntry>();
            lstDailyMealList = objTbl_DailyMealService.GetAllData().Where(x => x.EntryDate == dateTimePickerEntryDateMeal.Value.Date
                ).ToList();
            if (lstDailyMealList.Count > 0)
            {
                MessageBox.Show("Data already Exist for this Date");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Meal Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridViewMeal.Rows.Count; i++)
                {
                    Tbl_DailyMealEntry objTbl_DailyMealEntry = new Tbl_DailyMealEntry();
                    lstMultipleDateMealEntry[i].EntryDate = Convert.ToDateTime(dataGridViewMeal.Rows[i].Cells["ClmEntryDate"].Value.ToString());
                    lstMultipleDateMealEntry[i].PersonID = Convert.ToDouble(dataGridViewMeal.Rows[i].Cells["ClmPersonID"].Value.ToString());
                    lstMultipleDateMealEntry[i].MealNo = Convert.ToDouble(dataGridViewMeal.Rows[i].Cells["ClmMealNo"].Value.ToString());
                    objTbl_DailyMealEntry.PersonID = (Int32)lstMultipleDateMealEntry[i].PersonID;
                    objTbl_DailyMealEntry.MealNo = lstMultipleDateMealEntry[i].MealNo;
                    objTbl_DailyMealEntry.EntryDate = lstMultipleDateMealEntry[i].EntryDate;
                    objTbl_DailyMealService = new Tbl_DailyMealService();
                    objTbl_DailyMealService.InsertMeal(objTbl_DailyMealEntry);
                }
                MessageBox.Show("Data Inserted Successfully");
                LoadAllMealForSelectedMonth();
            }
        }

        private void dataGridViewMeal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridViewMeal.Rows.Count; i++)
            {
                //if (Convert.ToInt32(dataGridViewMeal.Rows[i].Cells["ClmMealNo"].Value.ToString()) < 0 || dataGridViewMeal.Rows[i].Cells["ClmMealNo"].Value.ToString()!=".")
                //{
                //    MessageBox.Show("Meal will be Numeric Only");
                //    dataGridViewMeal.Rows[i].Cells["ClmMealNo"].Value = 0;
                //}
               
            }
        }
    }

    //User Define Class....
    public class MultipleDateMealEntry
    {
        public double  PersonID { get; set; }
        public string PersonName { get; set; }
        public DateTime EntryDate { get; set; }
        public double MealNo { get; set; }


    }
}
