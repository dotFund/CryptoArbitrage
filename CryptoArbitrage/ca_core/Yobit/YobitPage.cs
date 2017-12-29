using System;
using ca_core.Interface;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace ca_core.Yobit
{
    public class YobitPage : AHomePage, IDisposable
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public YobitResponse YobitCoinInfo { get; }
        public YobitInfoResponse yobitInfo { get; }

        public override string URL {
            get
            {
                return "https://yobit.net";
            }
        }

        public YobitPage() : base()
        {
            base.connectThread.Name = "yobit.do.thread";
            base.infoThread.Name = "yobit.do.info.thread";
            YobitCoinInfo = new YobitResponse();
            yobitInfo = new YobitInfoResponse();
        }

        public string getPrice_x_x(string param1, string param2)
        {
            string param;
            param = "/api/3/ticker/" + param1 + "_" + param2;
            return DoGet(param);
        }

        private bool do_process_gettricker_response(string json_response)
        {
            try
            {
                if (IsValidJson(json_response))
                {
                    var response = JObject.Parse(json_response);

                    string strKey = FirstCoin + "_" + SecondCoin;
                    if (response[strKey].HasValues)
                    {
                        var rsp_content = response[strKey];
                        YobitCoinInfo.high = rsp_content["high"].ToString();
                        YobitCoinInfo.low = rsp_content["low"].ToString();
                        YobitCoinInfo.avg = rsp_content["avg"].ToString();
                        YobitCoinInfo.vol = rsp_content["vol"].ToString();
                        YobitCoinInfo.vol_cur = rsp_content["vol_cur"].ToString();
                        YobitCoinInfo.last = rsp_content["last"].ToString();
                        YobitCoinInfo.buy = rsp_content["buy"].ToString();
                        YobitCoinInfo.sell = rsp_content["sell"].ToString();
                        YobitCoinInfo.updated = rsp_content["updated"].ToString();
                        return true;
                    }
                }
            }
            catch (FormatException e)
            {
                YobitCoinInfo.high = "0";
                YobitCoinInfo.low = "0";
                YobitCoinInfo.avg = "0";
                YobitCoinInfo.vol = "0";
                YobitCoinInfo.vol_cur = "0";
                YobitCoinInfo.last = "0";
                YobitCoinInfo.buy = "0";
                YobitCoinInfo.sell = "0";
                YobitCoinInfo.updated = "0";

                Console.WriteLine("Yobit : (do_process_gettricker_response), " + e.Message);
            }

            YobitCoinInfo.high = "0";
            YobitCoinInfo.low = "0";
            YobitCoinInfo.avg = "0";
            YobitCoinInfo.vol = "0";
            YobitCoinInfo.vol_cur = "0";
            YobitCoinInfo.last = "0";
            YobitCoinInfo.buy = "0";
            YobitCoinInfo.sell = "0";
            YobitCoinInfo.updated = "0";
            return false;
        }

        public string public_info()
        {
            string param;
            param = "/api/3/info";
            return DoGet(param);
        }

        public bool public_info_response(string json_response)
        {
            if (IsValidJson(json_response))
            {
                var response = JObject.Parse(json_response);
                yobitInfo.server_time = response["server_time"].Value<double>();

                var pairs_field = response["pairs"].Value<JObject>();

                var item_field = pairs_field.First;
                for (int i = 1; i < pairs_field.Count; i ++)
                {
                    string strKey = ((JProperty)item_field).Name;

                    Info_Item item = new Info_Item();
                    item.decimal_places = item_field["decimal_places"].Value<int>();
                    item.min_price = item_field["min_price"].Value<double>();
                    
                }
            }
            return false;
        }

        public override void DoThread()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                string json_response = getPrice_x_x(FirstCoin, SecondCoin);
                do_process_gettricker_response(json_response);
            }
        }

        public override void DoInfoThread()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                string json_response = public_info();
                if (public_info_response(json_response))
                {

                }
                else
                {

                }
            }
        }

        public void Dispose()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
