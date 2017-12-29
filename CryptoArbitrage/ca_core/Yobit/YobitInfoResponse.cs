using System;
using System.Collections.Generic;
using System.Text;

namespace ca_core.Yobit
{
    public class YobitInfoResponse
    {
        public double server_time;
        public Dictionary<string, Info_Item> infos;

        public YobitInfoResponse()
        {

        }
    }

    public class Info_Item
    {
        public int decimal_places;
        public double min_price;
        public double max_price;
        public double min_amount;
        public double min_total;
        public double hidden;
        public double fee;
        public double fee_buyer;
        public double fee_seller;

        public Info_Item()
        {

        }
    }
}
