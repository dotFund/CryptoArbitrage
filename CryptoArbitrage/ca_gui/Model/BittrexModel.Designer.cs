namespace ca_gui.Model
{
    partial class BittrexModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_site_name = new System.Windows.Forms.Label();
            this.lbl_coin_name = new System.Windows.Forms.Label();
            this.lbl_update_time = new System.Windows.Forms.Label();
            this.lbl_buy_price = new System.Windows.Forms.Label();
            this.lbl_sell_price = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.txb_update_time = new System.Windows.Forms.TextBox();
            this.txb_buy = new System.Windows.Forms.TextBox();
            this.txb_sell = new System.Windows.Forms.TextBox();
            this.txb_coin_vol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_site_name
            // 
            this.lbl_site_name.AutoSize = true;
            this.lbl_site_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_site_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_site_name.Location = new System.Drawing.Point(57, 63);
            this.lbl_site_name.Name = "lbl_site_name";
            this.lbl_site_name.Size = new System.Drawing.Size(66, 25);
            this.lbl_site_name.TabIndex = 1;
            this.lbl_site_name.Text = "Bittrex";
            // 
            // lbl_coin_name
            // 
            this.lbl_coin_name.AutoSize = true;
            this.lbl_coin_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coin_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_coin_name.Location = new System.Drawing.Point(331, 63);
            this.lbl_coin_name.Name = "lbl_coin_name";
            this.lbl_coin_name.Size = new System.Drawing.Size(45, 25);
            this.lbl_coin_name.TabIndex = 2;
            this.lbl_coin_name.Text = "Zec";
            // 
            // lbl_update_time
            // 
            this.lbl_update_time.AutoSize = true;
            this.lbl_update_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_update_time.Location = new System.Drawing.Point(694, 30);
            this.lbl_update_time.Name = "lbl_update_time";
            this.lbl_update_time.Size = new System.Drawing.Size(89, 17);
            this.lbl_update_time.TabIndex = 3;
            this.lbl_update_time.Text = "UpdateTime:";
            // 
            // lbl_buy_price
            // 
            this.lbl_buy_price.AutoSize = true;
            this.lbl_buy_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_buy_price.Location = new System.Drawing.Point(747, 60);
            this.lbl_buy_price.Name = "lbl_buy_price";
            this.lbl_buy_price.Size = new System.Drawing.Size(36, 17);
            this.lbl_buy_price.TabIndex = 4;
            this.lbl_buy_price.Text = "Buy:";
            // 
            // lbl_sell_price
            // 
            this.lbl_sell_price.AutoSize = true;
            this.lbl_sell_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_sell_price.Location = new System.Drawing.Point(748, 88);
            this.lbl_sell_price.Name = "lbl_sell_price";
            this.lbl_sell_price.Size = new System.Drawing.Size(35, 17);
            this.lbl_sell_price.TabIndex = 5;
            this.lbl_sell_price.Text = "Sell:";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_volume.Location = new System.Drawing.Point(719, 116);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(64, 17);
            this.lbl_volume.TabIndex = 6;
            this.lbl_volume.Text = "Coin Vol:";
            // 
            // txb_update_time
            // 
            this.txb_update_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.txb_update_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_update_time.ForeColor = System.Drawing.Color.White;
            this.txb_update_time.Location = new System.Drawing.Point(790, 29);
            this.txb_update_time.Name = "txb_update_time";
            this.txb_update_time.ReadOnly = true;
            this.txb_update_time.Size = new System.Drawing.Size(193, 22);
            this.txb_update_time.TabIndex = 7;
            this.txb_update_time.Text = "38 sec ago";
            // 
            // txb_buy
            // 
            this.txb_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.txb_buy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_buy.ForeColor = System.Drawing.Color.White;
            this.txb_buy.Location = new System.Drawing.Point(790, 58);
            this.txb_buy.Name = "txb_buy";
            this.txb_buy.ReadOnly = true;
            this.txb_buy.Size = new System.Drawing.Size(193, 22);
            this.txb_buy.TabIndex = 8;
            this.txb_buy.Text = "17680.00000000";
            // 
            // txb_sell
            // 
            this.txb_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.txb_sell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_sell.ForeColor = System.Drawing.Color.White;
            this.txb_sell.Location = new System.Drawing.Point(790, 87);
            this.txb_sell.Name = "txb_sell";
            this.txb_sell.ReadOnly = true;
            this.txb_sell.Size = new System.Drawing.Size(193, 22);
            this.txb_sell.TabIndex = 9;
            this.txb_sell.Text = "17688.94021550";
            // 
            // txb_coin_vol
            // 
            this.txb_coin_vol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.txb_coin_vol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_coin_vol.ForeColor = System.Drawing.Color.White;
            this.txb_coin_vol.Location = new System.Drawing.Point(790, 116);
            this.txb_coin_vol.Name = "txb_coin_vol";
            this.txb_coin_vol.ReadOnly = true;
            this.txb_coin_vol.Size = new System.Drawing.Size(193, 22);
            this.txb_coin_vol.TabIndex = 10;
            this.txb_coin_vol.Text = "363.72204983 (btc)";
            // 
            // BittrexModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.txb_coin_vol);
            this.Controls.Add(this.txb_sell);
            this.Controls.Add(this.txb_buy);
            this.Controls.Add(this.txb_update_time);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_sell_price);
            this.Controls.Add(this.lbl_buy_price);
            this.Controls.Add(this.lbl_update_time);
            this.Controls.Add(this.lbl_coin_name);
            this.Controls.Add(this.lbl_site_name);
            this.Name = "BittrexModel";
            this.Size = new System.Drawing.Size(1238, 167);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_site_name;
        private System.Windows.Forms.Label lbl_coin_name;
        private System.Windows.Forms.Label lbl_update_time;
        private System.Windows.Forms.Label lbl_buy_price;
        private System.Windows.Forms.Label lbl_sell_price;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TextBox txb_update_time;
        private System.Windows.Forms.TextBox txb_buy;
        private System.Windows.Forms.TextBox txb_sell;
        private System.Windows.Forms.TextBox txb_coin_vol;
    }
}
