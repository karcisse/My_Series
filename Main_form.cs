using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using mySeries_app.model;

namespace mySeries_app
{
    public partial class Main_form : Form
    {

        public Main_form()
        {
            InitializeComponent();
            // used to add series from web
            //string[] series = { "Arrow", "1", "2" };
            //series_data.Rows.Add(series);

            //WebClient client = new WebClient();
            //string downloadString = client.DownloadString("http://www.gooogle.com");

            ////StreamWriter sw = File.CreateText(@"C:\test\text.html");
            ////sw.WriteLine(downloadString);
            ////sw.Close();

            //HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
            //html.LoadHtml(downloadString);
        }
        public Main_form(bool load_file)
        {
            InitializeComponent();
            series_data.AutoGenerateColumns = true;
            if (load_file)
            {
                load_data();                
            }
            series_data.Refresh();
        }
        private void add_series(object sender, EventArgs e)
        {
            add_series_form add_form = new add_series_form(this);
            var dialogResult = add_form.ShowDialog();
            if (to_add != null)
            {
                series_source.Add(to_add);
            }
            series_data.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_data();
            this.Close();
        }
        private void save_data()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/series_data_base.ses"))
            {
                foreach (DataGridViewRow series in series_data.Rows)
                {
                    string data = series.Cells[0].Value.ToString() + "," + series.Cells[1].Value.ToString() + "," + series.Cells[2].Value.ToString();
                    file.WriteLine(data);
                }
            }
        }
        private void load_data()
        {
            try
            {
                using (StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/series_data_base.ses"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] series = line.Split(',');
                        Series tmp = new Series(series);
                        series_source.Add(tmp);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("File not found");
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save_data();
        }

        private void nxt_ses_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Series tmp = (Series)series_data.CurrentRow.DataBoundItem;
                tmp.Season++;
                tmp.Episode = 1;
                series_data.Refresh();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Row not selected", "ERROR",MessageBoxButtons.OK);
            }
            
        }

        private void nxt_ep_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Series tmp = (Series)series_data.CurrentRow.DataBoundItem;
                tmp.Episode++;
                series_data.Refresh();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Row not selected", "ERROR",MessageBoxButtons.OK);
            }
            
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_form edit_form = new edit_form(this,series_data);
            var dialogResult = edit_form.ShowDialog();
            series_data.Refresh();
        }

        //set look of table after generate columns
        private void series_data_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            series_data.Columns[0].Width = 300;
            series_data.Columns[1].Width = series_data.Columns[2].Width = 50;
            series_data.Columns[1].DefaultCellStyle.Alignment = series_data.Columns[2].DefaultCellStyle.Alignment 
                = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
