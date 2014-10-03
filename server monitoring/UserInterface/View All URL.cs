using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace UserInterface
{
    public partial class View_All_URL : Form
    {
         public View_All_URL()
        {
            InitializeComponent();
        }

        private void View_All_URL_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
           
            //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            ActiveUrlGrid.Rows.Clear();
            try
            {
                connection.Open();
                SqlCommand mysql = new SqlCommand("SELECT MonitorName,URL,PollTime,Isactive FROM [URLDetails]", connection);
                SqlDataReader data = mysql.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (Convert.ToBoolean(data["Isactive"]))
                        {
                            ActiveUrlGrid.Rows.Add(data["MonitorName"].ToString().Trim(), data["URL"].ToString().Trim(), data["PollTime"].ToString().Trim(), "Active", Image.FromFile("C:/Users/sony vaio/Desktop/server monitoring/UserInterface/redbutton.JPG"));
                        }
                        else
                        {
                            ActiveUrlGrid.Rows.Add(data["MonitorName"].ToString().Trim(), data["URL"].ToString().Trim(), data["PollTime"].ToString().Trim(), "Inactive", Image.FromFile("C:/Users/sony vaio/Desktop/server monitoring/UserInterface/greenbutton.JPG"));
                        }
                    }
                }
            }
            catch
            {
                //
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActiveUrlGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {


                //string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\ankur\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
                SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
                try
                {
                    connection.Open();
                    SqlCommand mysql = new SqlCommand("UPDATE URLDetails SET Isactive=@isactive Where URL=@url", connection);
                    if (ActiveUrlGrid.Rows[e.RowIndex].Cells[3].Value.ToString() == "Active")
                    {
                        mysql.Parameters.AddWithValue("@isactive", 0);
                    }
                    else
                    {
                        mysql.Parameters.AddWithValue("@isactive", 1);
                    }
                    mysql.Parameters.AddWithValue("@url", ActiveUrlGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    SqlDataReader data = mysql.ExecuteReader();
                    LoadData();
                    urlmonitoringform.Ischanged = "true";
                }
                catch
                {
                    //
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }

            }
        }
    }
}
