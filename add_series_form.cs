using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySeries_app
{
    public partial class add_series_form : Form
    {
        Main_form parent;
        public add_series_form()
        {
            InitializeComponent();
        }
        public add_series_form(Main_form parent_form)
        {
            InitializeComponent();
            parent = parent_form;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title_textbox.Text))
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            parent.to_add = new mySeries_app.model.Series(title_textbox.Text, (uint)season_number.Value, (uint)episode_number.Value);
            this.Close();
        }
    }
}
