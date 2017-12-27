namespace ca_gui
{
    partial class Dashboard
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
            this.pan_header = new System.Windows.Forms.Panel();
            this.lbl_header_price_info = new System.Windows.Forms.Label();
            this.cmb_coin_name = new System.Windows.Forms.ComboBox();
            this.lbl_header_coin_name = new System.Windows.Forms.Label();
            this.lbl_header_site_name = new System.Windows.Forms.Label();
            this.pan_main = new System.Windows.Forms.Panel();
            this.pan_margin_bottom = new System.Windows.Forms.Panel();
            this.pan_margin_right = new System.Windows.Forms.Panel();
            this.pan_margin_top = new System.Windows.Forms.Panel();
            this.pan_margin_left = new System.Windows.Forms.Panel();
            this.pan_site_main = new System.Windows.Forms.Panel();
            this.main_scb_veritical = new System.Windows.Forms.VScrollBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yobitModel2 = new ca_gui.Model.YobitModel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pan_header.SuspendLayout();
            this.pan_main.SuspendLayout();
            this.pan_site_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_header
            // 
            this.pan_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_header.Controls.Add(this.lbl_header_price_info);
            this.pan_header.Controls.Add(this.cmb_coin_name);
            this.pan_header.Controls.Add(this.lbl_header_coin_name);
            this.pan_header.Controls.Add(this.lbl_header_site_name);
            this.pan_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_header.Location = new System.Drawing.Point(0, 0);
            this.pan_header.Name = "pan_header";
            this.pan_header.Size = new System.Drawing.Size(1279, 57);
            this.pan_header.TabIndex = 0;
            // 
            // lbl_header_price_info
            // 
            this.lbl_header_price_info.AutoSize = true;
            this.lbl_header_price_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_price_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_header_price_info.Location = new System.Drawing.Point(802, 16);
            this.lbl_header_price_info.Name = "lbl_header_price_info";
            this.lbl_header_price_info.Size = new System.Drawing.Size(108, 25);
            this.lbl_header_price_info.TabIndex = 2;
            this.lbl_header_price_info.Text = "Information";
            // 
            // cmb_coin_name
            // 
            this.cmb_coin_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_coin_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_coin_name.ForeColor = System.Drawing.Color.White;
            this.cmb_coin_name.FormattingEnabled = true;
            this.cmb_coin_name.Location = new System.Drawing.Point(390, 17);
            this.cmb_coin_name.Name = "cmb_coin_name";
            this.cmb_coin_name.Size = new System.Drawing.Size(145, 24);
            this.cmb_coin_name.TabIndex = 1;
            this.cmb_coin_name.SelectedIndexChanged += new System.EventHandler(this.cmb_coin_name_SelectedIndexChanged);
            // 
            // lbl_header_coin_name
            // 
            this.lbl_header_coin_name.AutoSize = true;
            this.lbl_header_coin_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_coin_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_header_coin_name.Location = new System.Drawing.Point(274, 16);
            this.lbl_header_coin_name.Name = "lbl_header_coin_name";
            this.lbl_header_coin_name.Size = new System.Drawing.Size(111, 25);
            this.lbl_header_coin_name.TabIndex = 1;
            this.lbl_header_coin_name.Text = "CoinName:";
            // 
            // lbl_header_site_name
            // 
            this.lbl_header_site_name.AutoSize = true;
            this.lbl_header_site_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_site_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_header_site_name.Location = new System.Drawing.Point(70, 17);
            this.lbl_header_site_name.Name = "lbl_header_site_name";
            this.lbl_header_site_name.Size = new System.Drawing.Size(46, 25);
            this.lbl_header_site_name.TabIndex = 0;
            this.lbl_header_site_name.Text = "Site";
            // 
            // pan_main
            // 
            this.pan_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pan_main.Controls.Add(this.pan_margin_bottom);
            this.pan_main.Controls.Add(this.pan_margin_right);
            this.pan_main.Controls.Add(this.pan_margin_top);
            this.pan_main.Controls.Add(this.pan_margin_left);
            this.pan_main.Controls.Add(this.pan_site_main);
            this.pan_main.Controls.Add(this.main_scb_veritical);
            this.pan_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_main.Location = new System.Drawing.Point(0, 57);
            this.pan_main.Name = "pan_main";
            this.pan_main.Size = new System.Drawing.Size(1279, 637);
            this.pan_main.TabIndex = 1;
            // 
            // pan_margin_bottom
            // 
            this.pan_margin_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_margin_bottom.Location = new System.Drawing.Point(5, 632);
            this.pan_margin_bottom.Name = "pan_margin_bottom";
            this.pan_margin_bottom.Size = new System.Drawing.Size(1248, 5);
            this.pan_margin_bottom.TabIndex = 5;
            // 
            // pan_margin_right
            // 
            this.pan_margin_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_margin_right.Location = new System.Drawing.Point(1253, 5);
            this.pan_margin_right.Name = "pan_margin_right";
            this.pan_margin_right.Size = new System.Drawing.Size(5, 632);
            this.pan_margin_right.TabIndex = 4;
            // 
            // pan_margin_top
            // 
            this.pan_margin_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_margin_top.Location = new System.Drawing.Point(5, 0);
            this.pan_margin_top.Name = "pan_margin_top";
            this.pan_margin_top.Size = new System.Drawing.Size(1253, 5);
            this.pan_margin_top.TabIndex = 3;
            // 
            // pan_margin_left
            // 
            this.pan_margin_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_margin_left.Location = new System.Drawing.Point(0, 0);
            this.pan_margin_left.Name = "pan_margin_left";
            this.pan_margin_left.Size = new System.Drawing.Size(5, 637);
            this.pan_margin_left.TabIndex = 2;
            // 
            // pan_site_main
            // 
            this.pan_site_main.BackColor = System.Drawing.Color.Gray;
            this.pan_site_main.Controls.Add(this.yobitModel2);
            this.pan_site_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_site_main.Location = new System.Drawing.Point(0, 0);
            this.pan_site_main.Name = "pan_site_main";
            this.pan_site_main.Size = new System.Drawing.Size(1258, 637);
            this.pan_site_main.TabIndex = 1;
            // 
            // main_scb_veritical
            // 
            this.main_scb_veritical.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_scb_veritical.Location = new System.Drawing.Point(1258, 0);
            this.main_scb_veritical.Name = "main_scb_veritical";
            this.main_scb_veritical.Size = new System.Drawing.Size(21, 637);
            this.main_scb_veritical.TabIndex = 0;
            // 
            // yobitModel2
            // 
            this.yobitModel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yobitModel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yobitModel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.yobitModel2.Location = new System.Drawing.Point(10, 11);
            this.yobitModel2.Name = "yobitModel2";
            this.yobitModel2.Size = new System.Drawing.Size(1238, 167);
            this.yobitModel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1279, 694);
            this.Controls.Add(this.pan_main);
            this.Controls.Add(this.pan_header);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pan_header.ResumeLayout(false);
            this.pan_header.PerformLayout();
            this.pan_main.ResumeLayout(false);
            this.pan_site_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_header;
        private System.Windows.Forms.Label lbl_header_price_info;
        private System.Windows.Forms.ComboBox cmb_coin_name;
        private System.Windows.Forms.Label lbl_header_coin_name;
        private System.Windows.Forms.Label lbl_header_site_name;
        private System.Windows.Forms.Panel pan_main;
        private System.Windows.Forms.Panel pan_site_main;
        private System.Windows.Forms.VScrollBar main_scb_veritical;
        private System.Windows.Forms.Panel pan_margin_bottom;
        private System.Windows.Forms.Panel pan_margin_right;
        private System.Windows.Forms.Panel pan_margin_top;
        private System.Windows.Forms.Panel pan_margin_left;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Model.YobitModel yobitModel2;
        private System.Windows.Forms.Timer timer1;
    }
}

