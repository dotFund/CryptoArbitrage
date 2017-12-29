using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ca_core.Bittrex;
using ca_gui;
using System.Globalization;

namespace ca_gui.Model
{
    public partial class BittrexModel : UserControl
    {
        public BittrexModel()
        {
            InitializeComponent();
        }

        public void SetStatus(MarketSummaryResponse coinInfo)
        {
            this.txb_buy.Text = coinInfo.Ask;
            this.txb_coin_vol.Text = coinInfo.Volumn;
            this.txb_sell.Text = coinInfo.Bid;

            DateTime localDate = DateTime.Now;

            try
            {
                if (coinInfo.TimeStamp != null)
                {
                    DateTime server_update_dt = DateTime.ParseExact(coinInfo.TimeStamp, "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

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
                Console.WriteLine("Bittrex : (SetStatus), " + e.Message);
            }
        }
    }
}
