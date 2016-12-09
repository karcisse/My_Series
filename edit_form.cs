using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySeries_app.model;

namespace mySeries_app
{
    public partial class edit_form : Form
    {
        private Series backup_series;
        private DataGridViewRow series_row;
        public edit_form(Main_form parent_form, DataGridView series_data)
        {
            InitializeComponent();
            series_row = series_data.CurrentRow;
            backup_series = (Series)series_row.DataBoundItem;
            title_txtbox.Text = backup_series.Title;
            ses_num.Value = backup_series.Season;
            ep_num.Value = backup_series.Episode;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            Series tmp = (Series)series_row.DataBoundItem;
            tmp.Title = title_txtbox.Text;
            tmp.Season = (uint)ses_num.Value;
            tmp.Episode = (uint)ep_num.Value;
            this.Close();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("You are going to delete "+backup_series.Title+". Procced ?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
            {
                series_row.DataGridView.Rows.RemoveAt(series_row.Index);
                this.Close();
            }
        }
    }
}
