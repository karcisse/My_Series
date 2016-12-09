namespace mySeries_app
{
    partial class add_series_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_series_form));
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.season_label = new System.Windows.Forms.Label();
            this.episode_label = new System.Windows.Forms.Label();
            this.season_number = new System.Windows.Forms.NumericUpDown();
            this.episode_number = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.season_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode_number)).BeginInit();
            this.SuspendLayout();
            // 
            // title_textbox
            // 
            resources.ApplyResources(this.title_textbox, "title_textbox");
            this.title_textbox.Name = "title_textbox";
            // 
            // title_label
            // 
            resources.ApplyResources(this.title_label, "title_label");
            this.title_label.Name = "title_label";
            // 
            // season_label
            // 
            resources.ApplyResources(this.season_label, "season_label");
            this.season_label.Name = "season_label";
            // 
            // episode_label
            // 
            resources.ApplyResources(this.episode_label, "episode_label");
            this.episode_label.Name = "episode_label";
            // 
            // season_number
            // 
            resources.ApplyResources(this.season_number, "season_number");
            this.season_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.season_number.Name = "season_number";
            this.season_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // episode_number
            // 
            resources.ApplyResources(this.episode_number, "episode_number");
            this.episode_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.episode_number.Name = "episode_number";
            this.episode_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_btn
            // 
            resources.ApplyResources(this.add_btn, "add_btn");
            this.add_btn.Name = "add_btn";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            resources.ApplyResources(this.cancel_btn, "cancel_btn");
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_series_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.episode_number);
            this.Controls.Add(this.season_number);
            this.Controls.Add(this.episode_label);
            this.Controls.Add(this.season_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.title_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_series_form";
            ((System.ComponentModel.ISupportInitialize)(this.season_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label season_label;
        private System.Windows.Forms.Label episode_label;
        private System.Windows.Forms.NumericUpDown season_number;
        private System.Windows.Forms.NumericUpDown episode_number;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}