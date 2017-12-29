using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ca_core.Interface
{
    public abstract class AHomePage
    {
        protected Thread connectThread;
        protected Thread infoThread;
        protected string FirstCoin;
        protected string SecondCoin;

        public abstract string URL { get; }

        public abstract void DoThread();
        public abstract void DoInfoThread();

        public AHomePage()
        {
            this.connectThread = new Thread(DoThread)
            {
                IsBackground = true
            };

            this.infoThread = new Thread(DoInfoThread)
            {
                IsBackground = true
            };
        }

        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string DoGet(string param)
        {
            string responseText = string.Empty;
            string get_url = URL + param;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(get_url);
            request.Method = "GET";
            request.Timeout = 10 * 1000; // 30 sec
            request.Headers.Add("Authorization", "BASIC SGVsbG8=");

            try
            {
                using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
                {
                    HttpStatusCode status = resp.StatusCode;
                    //Console.WriteLine(status);  // if true "OK"

                    Stream respStream = resp.GetResponseStream();
                    using (StreamReader sr = new StreamReader(respStream))
                    {
                        responseText = sr.ReadToEnd();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Http request Error");  // timeout
            }

            return responseText;
        }

        public void setParam(string param1, string param2)
        {
            FirstCoin = param1;
            SecondCoin = param2;
        }

        public void start()
        {
            connectThread.Start();
            infoThread.Start();
        }
    }
}
