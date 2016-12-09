namespace mySeries_app
{
    partial class edit_form
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
            this.title_label = new System.Windows.Forms.Label();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.season_label = new System.Windows.Forms.Label();
            this.episode_label = new System.Windows.Forms.Label();
            this.ses_num = new System.Windows.Forms.NumericUpDown();
            this.ep_num = new System.Windows.Forms.NumericUpDown();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.apply_btn = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ses_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_num)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(12, 30);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(27, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title";
            // 
            // title_txtbox
            // 
            this.title_txtbox.Location = new System.Drawing.Point(45, 27);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(365, 20);
            this.title_txtbox.TabIndex = 1;
            // 
            // season_label
            // 
            this.season_label.AutoSize = true;
            this.season_label.Location = new System.Drawing.Point(42, 66);
            this.season_label.Name = "season_label";
            this.season_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.season_label.Size = new System.Drawing.Size(43, 13);
            this.season_label.TabIndex = 2;
            this.season_label.Text = "Season";
            // 
            // episode_label
            // 
            this.episode_label.AutoSize = true;
            this.episode_label.Location = new System.Drawing.Point(103, 66);
            this.episode_label.Name = "episode_label";
            this.episode_label.Size = new System.Drawing.Size(45, 13);
            this.episode_label.TabIndex = 3;
            this.episode_label.Text = "Episode";
            // 
            // ses_num
            // 
            this.ses_num.Location = new System.Drawing.Point(45, 82);
            this.ses_num.Name = "ses_num";
            this.ses_num.Size = new System.Drawing.Size(40, 20);
            this.ses_num.TabIndex = 4;
            this.ses_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ep_num
            // 
            this.ep_num.Location = new System.Drawing.Point(106, 82);
            this.ep_num.Name = "ep_num";
            this.ep_num.Size = new System.Drawing.Size(40, 20);
            this.ep_num.TabIndex = 5;
            this.ep_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(335, 82);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(254, 82);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 7;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // dlt_btn
            // 
            this.dlt_btn.Location = new System.Drawing.Point(173, 82);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(75, 23);
            this.dlt_btn.TabIndex = 8;
            this.dlt_btn.Text = "Delete";
            this.dlt_btn.UseVisualStyleBackColor = true;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 129);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ep_num);
            this.Controls.Add(this.ses_num);
            this.Controls.Add(this.episode_label);
            this.Controls.Add(this.season_label);
            this.Controls.Add(this.title_txtbox);
            this.Controls.Add(this.title_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.ses_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.Label season_label;
        private System.Windows.Forms.Label episode_label;
        private System.Windows.Forms.NumericUpDown ses_num;
        private System.Windows.Forms.NumericUpDown ep_num;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button dlt_btn;
    }
}