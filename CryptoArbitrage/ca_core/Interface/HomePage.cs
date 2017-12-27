using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ca_core.Interface
{
    public abstract class HomePage
    {
        protected Thread connectThread;
        protected string FirstCoin;
        protected string SecondCoin;

        public abstract string URL { get; }

        public abstract void DoThread();

        public HomePage()
        {
            this.connectThread = new Thread(DoThread)
            {
                IsBackground = true
            };
        }

        public string DoGet(string param)
        {
            string responseText = string.Empty;
            string get_url = URL + param;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(get_url);
            request.Method = "GET";
            request.Timeout = 30 * 1000; // 30 sec
            request.Headers.Add("Authorization", "BASIC SGVsbG8=");

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);  // if true "OK"

                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
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
        }
    }
}
