namespace foxsportsstats
{
    partial class FoxSports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoxSports));
            this.lb_series = new System.Windows.Forms.Label();
            this.lb_season = new System.Windows.Forms.Label();
            this.lb_round = new System.Windows.Forms.Label();
            this.li_series = new System.Windows.Forms.ComboBox();
            this.li_season = new System.Windows.Forms.ComboBox();
            this.li_round = new System.Windows.Forms.ComboBox();
            this.btnFetchResult = new System.Windows.Forms.Button();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.lb_logoTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_series
            // 
            this.lb_series.AutoSize = true;
            this.lb_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_series.Location = new System.Drawing.Point(62, 161);
            this.lb_series.Name = "lb_series";
            this.lb_series.Size = new System.Drawing.Size(66, 20);
            this.lb_series.TabIndex = 0;
            this.lb_series.Text = "Series : ";
            // 
            // lb_season
            // 
            this.lb_season.AutoSize = true;
            this.lb_season.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_season.Location = new System.Drawing.Point(369, 161);
            this.lb_season.Name = "lb_season";
            this.lb_season.Size = new System.Drawing.Size(76, 20);
            this.lb_season.TabIndex = 1;
            this.lb_season.Text = "Season : ";
            // 
            // lb_round
            // 
            this.lb_round.AutoSize = true;
            this.lb_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_round.Location = new System.Drawing.Point(547, 161);
            this.lb_round.Name = "lb_round";
            this.lb_round.Size = new System.Drawing.Size(69, 20);
            this.lb_round.TabIndex = 2;
            this.lb_round.Text = "Round : ";
            // 
            // li_series
            // 
            this.li_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.li_series.FormattingEnabled = true;
            this.li_series.Location = new System.Drawing.Point(56, 184);
            this.li_series.Name = "li_series";
            this.li_series.Size = new System.Drawing.Size(245, 28);
            this.li_series.TabIndex = 3;
            this.li_series.SelectedIndexChanged += new System.EventHandler(this.Li_series_SelectedIndexChanged);
            // 
            // li_season
            // 
            this.li_season.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.li_season.FormattingEnabled = true;
            this.li_season.Location = new System.Drawing.Point(359, 184);
            this.li_season.Name = "li_season";
            this.li_season.Size = new System.Drawing.Size(131, 28);
            this.li_season.TabIndex = 4;
            this.li_season.SelectedIndexChanged += new System.EventHandler(this.Li_season_SelectedIndexChanged);
            // 
            // li_round
            // 
            this.li_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.li_round.FormattingEnabled = true;
            this.li_round.Location = new System.Drawing.Point(541, 184);
            this.li_round.Name = "li_round";
            this.li_round.Size = new System.Drawing.Size(152, 28);
            this.li_round.TabIndex = 5;
            this.li_round.SelectedIndexChanged += new System.EventHandler(this.Li_round_SelectedIndexChanged);
            // 
            // btnFetchResult
            // 
            this.btnFetchResult.BackColor = System.Drawing.Color.Transparent;
            this.btnFetchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchResult.ForeColor = System.Drawing.Color.Black;
            this.btnFetchResult.Location = new System.Drawing.Point(531, 301);
            this.btnFetchResult.Name = "btnFetchResult";
            this.btnFetchResult.Size = new System.Drawing.Size(162, 40);
            this.btnFetchResult.TabIndex = 6;
            this.btnFetchResult.Text = "Fetch Results";
            this.btnFetchResult.UseVisualStyleBackColor = false;
            this.btnFetchResult.Click += new System.EventHandler(this.BtnFetchResult_Click);
            // 
            // img_logo
            // 
            this.img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_logo.Image = ((System.Drawing.Image)(resources.GetObject("img_logo.Image")));
            this.img_logo.Location = new System.Drawing.Point(56, 43);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(50, 52);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 7;
            this.img_logo.TabStop = false;
            // 
            // lb_logoTxt
            // 
            this.lb_logoTxt.AutoSize = true;
            this.lb_logoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logoTxt.Location = new System.Drawing.Point(112, 57);
            this.lb_logoTxt.Name = "lb_logoTxt";
            this.lb_logoTxt.Size = new System.Drawing.Size(189, 24);
            this.lb_logoTxt.TabIndex = 8;
            this.lb_logoTxt.Text = "MATCH SELECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(57, 242);
            this.lb_error.MaximumSize = new System.Drawing.Size(700, 0);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 16);
            this.lb_error.TabIndex = 10;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(658, 54);
            this.btn_refresh.MaximumSize = new System.Drawing.Size(35, 35);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_refresh.Size = new System.Drawing.Size(35, 35);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // FoxSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_logoTxt);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.btnFetchResult);
            this.Controls.Add(this.li_round);
            this.Controls.Add(this.li_season);
            this.Controls.Add(this.li_series);
            this.Controls.Add(this.lb_round);
            this.Controls.Add(this.lb_season);
            this.Controls.Add(this.lb_series);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FoxSports";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoxSports";
            this.Load += new System.EventHandler(this.FoxSportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_series;
        private System.Windows.Forms.Label lb_season;
        private System.Windows.Forms.Label lb_round;
        private System.Windows.Forms.ComboBox li_series;
        private System.Windows.Forms.ComboBox li_season;
        private System.Windows.Forms.ComboBox li_round;
        private System.Windows.Forms.Button btnFetchResult;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label lb_logoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Button btn_refresh;
    }
}

