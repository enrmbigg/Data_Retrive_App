using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Data_Retrive_App
{
    public partial class Form1 : Form
    {
        string Tour;
        DateTime Tour_Date;
        DateTime FileNameTime;
        string filenameWithoutPath;
        DateTime fileCreatedDate;
        DateTime fileModifiedDate;
        string table;
        string db;
        int i = 0;
        System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
      

        public Form1()
        {
            InitializeComponent();
            builder["Data Source"] = "localhost";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "Data";
            lblDB.Text = builder.ConnectionString;
            
                   
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
                    
        }
        /*
        //Not needed atm but could be reused
        public void DeleteLastRecord()
        {
            using (SqlConnection openCon = new SqlConnection(builder.ConnectionString))
            {
                openCon.Open();
                string query = "DELETE FROM " + table.ToUpper() + " WHERE ID = (SELECT MAX(ID) FROM Data)";
                SqlCommand cmd = new SqlCommand(query, openCon);
                cmd.ExecuteNonQuery();
                openCon.Close();
            }
        }
        */
        public void FileWrite()
        {

            using (SqlConnection openCon = new SqlConnection(builder.ConnectionString))
            {
                i++;
                openCon.Open();
                string query = "INSERT into " + table.ToUpper() + " (FileName,Tour,TourDate,FileNameTime,FileCreatedTime,FileModifiedTime) values('" + filenameWithoutPath + "','" + Tour + "','" + Tour_Date.ToString("MM/dd/yyyy") + "','" + FileNameTime.ToString("hh:mm:ss") + "','" + fileCreatedDate.ToString("MM/dd/yyyy hh:mm:ss") + "','" + fileModifiedDate.ToString("MM/dd/yyyy hh:mm:ss") + "' )";
                SqlCommand cmd = new SqlCommand(query, openCon);
                cmd.ExecuteNonQuery();
                openCon.Close();
            }
        }

        public void TextCheck()
        {
            try
            {
                if (txtTable.Text == "Insert Table Here" )
                {
                    table = "Info";
                }
                else if (txtTable.Text == "")
                {
                    table = "Info";
                }
                else
                {
                    table = txtTable.Text;
                }

                if (txtCon.Text == "Insert DB Con Here")
                {
                    db = "localhost";
                }
                else if (txtTable.Text == "")
                {
                    db = "localhost";
                }
                else
                {
                    db = txtCon.Text;
                }
            }
            catch
            {
                table = "Info";
                db = "localhost";
            }
            lblTable.Text = table;
            builder["Data Source"] = db;
            lblDB.Text = builder.ConnectionString;
        }

        public void FileLoad()
        {
           
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string[] fileEntries = Directory.GetFiles(ofd.SelectedPath);
                int Total = fileEntries.Length;
                
                foreach (string fileName in fileEntries)
                {
                    lblResult.Text = "Total: " + Total.ToString() + " Amount Left: " + (Total - i).ToString();
                    fileCreatedDate = File.GetCreationTime(fileName);
                    filenameWithoutPath = Path.GetFileName(fileName);
                    fileModifiedDate = File.GetLastWriteTime(fileName);

                    string[] split = filenameWithoutPath.Split('_');
                    @Tour = split[0];

                    string s = split[1];
                    string a;
                    string b;
                    string c;
                    string str;

                    if (s.Length ==8)
                    {
                        a = s.Substring(0,4);
                        b = s.Substring(4, 2);
                        c = s.Substring(6);
                        str = a + '/' + b + '/' + c;
                    }
                    else
                    {
                        a = s.Substring(0, 2);
                        b = s.Substring(2, 2);
                        c = s.Substring(4);
                        str = a + '/' + b + '/' + c;
                    }
                    Tour_Date = DateTime.Parse(str);
                    s = split[2];
                    string[] split1 = s.Split('.');
                    s = split1[0];
                    a = s.Substring(0, 2);
                    b = s.Substring(2,2);
                    c = s.Substring(4);
                    str = a + ':' + b + ':' + c;
                    try
                    {
                        FileNameTime = DateTime.Parse(str);
                    }
                    catch
                    {
                        FileNameTime = DateTime.Parse("00:00:00");
                    }
                    FileWrite();
                    if ((i % 50) == 0)
                    {
                        lblResult.Text = "Total: " + Total.ToString() + " Amount Left: " + (Total - i).ToString();
                        this.Refresh();
                    }
                    
                }
                lblResult.Text = "Total: " + Total.ToString() + " Amount Left: " + (Total - i).ToString();
                MessageBox.Show("Saving is done!");
                i = 0;
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextCheck();
            FileLoad();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextCheck();
            using (SqlConnection openCon = new SqlConnection(builder.ConnectionString))
            {
                i++;
                openCon.Open();
                string query = "DELETE " + " FROM " + table;
                SqlCommand cmd = new SqlCommand(query, openCon);
                cmd.ExecuteNonQuery();
                openCon.Close();
            }
          
            lblResult.Text = "Total Records: 0";
            this.Refresh();
            
            MessageBox.Show("All Records Have Been Deleted!");
        }
    }
}
