﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ca_core.Yobit;
using ca_gui;

namespace ca_gui.Model
{
    public partial class YobitModel : UserControl
    {
        public YobitModel()
        {
            InitializeComponent();
        }

        public void SetStatus(YobitResponse coinInfo)
        {
            this.txb_buy.Text = coinInfo.buy;
            this.txb_coin_vol.Text = coinInfo.vol;
            this.txb_sell.Text = coinInfo.sell;

            DateTime localDate = DateTime.Now;

            try
            {
                if (coinInfo.updated != null)
                {
                    double server_update_time = double.Parse(coinInfo.updated);
                    DateTime server_update_dt = Helper.ConvertFromUnixTimestamp(server_update_time);

                    TimeSpan diff = localDate.ToUniversalTime() - server_update_dt;

                    this.txb_update_time.Text = diff.TotalSeconds.ToString() + " secs ago";
                }
                else
                {
                    this.txb_update_time.Text = "";
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("YobitModel : (SetYobitStatus), " + e.Message);
            }
        }
    }
}
