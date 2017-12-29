using System;
using ca_core.Interface;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace ca_core.Bittrex
{
    public class BittrexPage : AHomePage, IDisposable
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private string API_VERSION = "v1.1";

        public MarketSummaryResponse marketSummaryResponse { get; }

        public override string URL
        {
            get
            {
                return "https://bittrex.com/api/" + API_VERSION;
            }
        }

        public BittrexPage() : base()
        {
            base.connectThread.Name = "bittrex.do.thread";
            base.infoThread.Name = "bittrex.do.info.thread";
            marketSummaryResponse = new MarketSummaryResponse();
        }

        public string public_getmarketsummary(string param1, string param2)
        {
            string param;
            param = "/public/getmarketsummary?market=" + param1 + "-" + param2;
            return DoGet(param);
        }

        private bool do_process_getmarketsummary_response(string json_response)
        {
            if (IsValidJson(json_response))
            {
                var response = JObject.Parse(json_response);

                try
                {
                    if (response.First.HasValues)
                    {
                        var success_field = response.First;
                        bool val_success = success_field.ToObject<bool>();
                        if (val_success == true)
                        {
                            var msg_field = response.Next;
                            var result_field = response.Last;
                            var result_body = result_field.First.First;

                            marketSummaryResponse.MarketName = result_body["MarketName"].ToString();

                            if (marketSummaryResponse.MarketName == (FirstCoin + "-" + SecondCoin).ToUpper())
                            {
                                marketSummaryResponse.High = result_body["High"].ToString();
                                marketSummaryResponse.Low = result_body["Low"].ToString();
                                marketSummaryResponse.Volumn = result_body["Volume"].ToString();
                                marketSummaryResponse.Last = result_body["Last"].ToString();
                                marketSummaryResponse.BaseVolumn = result_body["BaseVolume"].ToString();
                                marketSummaryResponse.TimeStamp = result_body["TimeStamp"].ToString();
                                marketSummaryResponse.Bid = result_body["Bid"].ToString();
                                marketSummaryResponse.Ask = result_body["Ask"].ToString();
                                marketSummaryResponse.OpenBuyOrders = result_body["OpenBuyOrders"].ToString();
                                marketSummaryResponse.OpenSellOrders = result_body["OpenSellOrders"].ToString();
                                marketSummaryResponse.PrevDay = result_body["PrevDay"].ToString();
                                marketSummaryResponse.Created = result_body["Created"].ToString();

                                return true;
                            }
                        }

                    }
                }
                catch (FormatException e)
                {
                    marketSummaryResponse.MarketName = "";
                    marketSummaryResponse.High = "";
                    marketSummaryResponse.Low = "";
                    marketSummaryResponse.Volumn = "";
                    marketSummaryResponse.Last = "";
                    marketSummaryResponse.BaseVolumn = "";
                    marketSummaryResponse.TimeStamp = "";
                    marketSummaryResponse.Bid = "";
                    marketSummaryResponse.Ask = "";
                    marketSummaryResponse.OpenBuyOrders = "";
                    marketSummaryResponse.OpenSellOrders = "";
                    marketSummaryResponse.PrevDay = "";
                    marketSummaryResponse.Created = "";

                    Console.WriteLine("Bittrex : (do_process_getmarketsummary_response), " + e.Message);
                }
            }
            
            marketSummaryResponse.MarketName = "";
            marketSummaryResponse.High = "";
            marketSummaryResponse.Low = "";
            marketSummaryResponse.Volumn = "";
            marketSummaryResponse.Last = "";
            marketSummaryResponse.BaseVolumn = "";
            marketSummaryResponse.TimeStamp = "";
            marketSummaryResponse.Bid = "";
            marketSummaryResponse.Ask = "";
            marketSummaryResponse.OpenBuyOrders = "";
            marketSummaryResponse.OpenSellOrders = "";
            marketSummaryResponse.PrevDay = "";
            marketSummaryResponse.Created = "";

            return false;
        }

        public override void DoThread()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                
                string json_response = public_getmarketsummary(FirstCoin, SecondCoin);

                if (do_process_getmarketsummary_response(json_response))
                {
                    
                }
                else
                {

                }
            }
        }

        public override void DoInfoThread()
        {

        }
        public void Dispose()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
