using System;
using System.Windows.Forms;
using ca_gui.Properties;
using ca_gui.Item;
using ca_core.Yobit;
using ca_core.Bittrex;

namespace ca_gui
{
    public partial class Dashboard : Form
    {
        public YobitPage yobitPageInstance;
        public BittrexPage bittrexPageInstance;

        public Dashboard()
        {
            InitializeComponent();
            InitInterface();
        }

        private void InitInterface()
        {
            //Refresh Combobox
            RefreshComboBox();
        }

        public void RefreshComboBox()
        {
            for (int i = 0; i < Settings.Default.CoinNames.CoinNameArray.Length; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = Settings.Default.CoinNames.CoinNameArray[i];
                item.Value = i;
                cmb_coin_name.Items.Add(item);
            }

            cmb_coin_name.SelectedIndex = 0;

            //MessageBox.Show((cmb_coin_name.SelectedItem as ComboboxItem).Value.ToString());
        }

        private void cmb_coin_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)this.cmb_coin_name.SelectedItem;

            //Yobit thread start...
            yobitPageInstance = new YobitPage();
            
            yobitPageInstance.setParam(item.Text, "usd");
            yobitPageInstance.start();

            //Bittrex thread start...
            bittrexPageInstance = new BittrexPage();
            bittrexPageInstance.setParam("usdt", item.Text);
            bittrexPageInstance.start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.yobitModel2.SetStatus(yobitPageInstance.YobitCoinInfo);
            this.bittrexModel1.SetStatus(bittrexPageInstance.marketSummaryResponse);
        }
    }
}
