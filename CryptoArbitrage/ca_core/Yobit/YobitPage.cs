using System;
using System.Collections.Generic;
using System.Text;
using ca_core.Interface;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ca_core.Yobit
{
    public class YobitPage : HomePage, IDisposable
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public YobitResponse YobitCoinInfo { get; }

        public override string URL {
            get
            {
                return "https://yobit.net";
            }
        }

        public YobitPage() : base()
        {
            base.connectThread.Name = "yobit.do.thread";
            YobitCoinInfo = new YobitResponse();
        }

        public string getPrice_x_x(string param1, string param2)
        {
            string param;
            param = "/api/3/ticker/" + param1 + "_" + param2;
            return DoGet(param);
        }

        public override void DoThread()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                string json_response = getPrice_x_x(FirstCoin, SecondCoin);
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
                }
                else
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
                }
            }
        }

        public void Dispose()
        {
            cancellationTokenSource.Cancel();
        }
    }

    public class YobitResponse
    {
        public string high { get; set; }
        public string low { get; set; }
        public string avg { get; set; }
        public string vol { get; set; }
        public string vol_cur { get; set; }
        public string last { get; set; }
        public string buy { get; set; }
        public string sell { get; set; }
        public string updated { get; set; }

        public YobitResponse()
        {
        }
    }
}
