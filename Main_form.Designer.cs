using System.Collections.Generic;
using mySeries_app.model;
namespace mySeries_app
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.series_data = new System.Windows.Forms.DataGridView();
            this.series_source = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nxt_ses_btn = new System.Windows.Forms.Button();
            this.nxt_ep_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.series_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.series_source)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // series_data
            // 
            this.series_data.AllowUserToAddRows = false;
            this.series_data.AllowUserToDeleteRows = false;
            this.series_data.AllowUserToResizeColumns = false;
            this.series_data.AllowUserToResizeRows = false;
            this.series_data.AutoGenerateColumns = false;
            this.series_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.series_data.DataSource = this.series_source;
            resources.ApplyResources(this.series_data, "series_data");
            this.series_data.MultiSelect = false;
            this.series_data.Name = "series_data";
            this.series_data.ReadOnly = true;
            this.series_data.RowHeadersVisible = false;
            this.series_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.series_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.series_data.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.series_data_DataBindingComplete);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriesToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // seriesToolStripMenuItem
            // 
            this.seriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            resources.ApplyResources(this.seriesToolStripMenuItem, "seriesToolStripMenuItem");
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Click += new System.EventHandler(this.add_series);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nxt_ses_btn
            // 
            resources.ApplyResources(this.nxt_ses_btn, "nxt_ses_btn");
            this.nxt_ses_btn.Name = "nxt_ses_btn";
            this.nxt_ses_btn.UseVisualStyleBackColor = true;
            this.nxt_ses_btn.Click += new System.EventHandler(this.nxt_ses_btn_Click);
            // 
            // nxt_ep_btn
            // 
            resources.ApplyResources(this.nxt_ep_btn, "nxt_ep_btn");
            this.nxt_ep_btn.Name = "nxt_ep_btn";
            this.nxt_ep_btn.UseVisualStyleBackColor = true;
            this.nxt_ep_btn.Click += new System.EventHandler(this.nxt_ep_btn_Click);
            // 
            // Main_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nxt_ep_btn);
            this.Controls.Add(this.nxt_ses_btn);
            this.Controls.Add(this.series_data);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.series_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.series_source)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView series_data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        public Series to_add = null;
        private System.Windows.Forms.Button nxt_ses_btn;
        private System.Windows.Forms.Button nxt_ep_btn;
        private System.Windows.Forms.BindingSource series_source;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

    }
}

