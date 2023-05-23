using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace RoomManagementEntityFramework
{
    public partial class CityImportFromExcelForm : Form
    {
        string ImportFileName = "";
        public CityImportFromExcelForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile();
        }
        private void BrowseFile()
        {
            try
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "RoomManagement Import Open File Diaglog";
                fdlg.InitialDirectory = @"c:\";
                fdlg.Filter = "Excel files (*.xlsx*)|*.xlsx*|Excel(97-2003) files(*.xls*)|*.xls*";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    ImportFileName = fdlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            CityMasterHeader();
            CityMasterImport();
        }
        private void CityMasterHeader()
        {
            dataGridViewCityMaster.Rows.Clear();
            dataGridViewCityMaster.Refresh();
            dataGridViewCityMaster.ColumnCount = 3;
            dataGridViewCityMaster.Columns[0].Name = "cityCode";
            dataGridViewCityMaster.Columns[1].Name = "cityName";
            dataGridViewCityMaster.Columns[2].Name = "zipCode";


        }
        private void CityMasterImport()
        {
            try
            {
                string fileName = ImportFileName;
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;"
                                           + "Data Source=" + fileName + ";"
                                           + "Extended Properties=" + "\""
                                           + "Excel 12.0;HDR=YES;" + "\"";
                OleDbConnection theConnection;
                theConnection = new OleDbConnection(connectionString);
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * from [city$]", theConnection);
                DataTable dt = new DataTable();
                theDataAdapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow NewRow = new DataGridViewRow();
                    dataGridViewCityMaster.Rows.Add(NewRow);
                    dataGridViewCityMaster["cityCode", dataGridViewCityMaster.RowCount - 1].Value = dt.Rows[i]["cityCode"].ToString();
                    dataGridViewCityMaster["cityName", dataGridViewCityMaster.RowCount - 1].Value = dt.Rows[i]["cityName"].ToString();
                    dataGridViewCityMaster["zipCode", dataGridViewCityMaster.RowCount - 1].Value = dt.Rows[i]["zipCode"].ToString();

                }
                theConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
