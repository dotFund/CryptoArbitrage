using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ca_core.Yobit;

namespace ca_gui.Model
{
    public partial class YobitModel : UserControl
    {
        public YobitModel()
        {
            InitializeComponent();
        }

        public void SetYobitStatus(YobitResponse coinInfo)
        {
            this.txb_buy.Text = coinInfo.buy;
            this.txb_coin_vol.Text = coinInfo.vol;
            this.txb_sell.Text = coinInfo.sell;
        }
    }
}
