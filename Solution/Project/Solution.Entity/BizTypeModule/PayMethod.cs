using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Entity.BizTypeModule
{
    /// <summary>
    /// 支付方式 
    /// 1微信网页支付，2微信APP支付，5支付宝支付
    /// </summary>
    public class PayMethod
    {

        /// <summary>
        /// 1微信网页支付
        /// </summary>
        public const int WeChat_JsApi = 1;

        /// <summary>
        /// 5微信APP支付
        /// </summary>
        public const int WeChat_App = 5;

        /// <summary>
        /// 6微信扫码支付
        /// </summary>
        public const int WeChat_Native = 6;

        /// <summary>
        /// 10支付宝支付
        /// </summary>
        public const int AliPay = 10;




        public static Dictionary<int, string> PayMethods = new Dictionary<int, string>()
        {
            { WeChat_JsApi,"微信网页支付"},
            { WeChat_App,"微信APP支付"},
            { WeChat_Native,"微信扫码支付"},
            { AliPay,"支付宝支付"}
        };


        public static string GetName(int key)
        {
            foreach (var item in PayMethods)
            {
                if (key.Equals(item.Key))
                {
                    return item.Value;
                }
            }
            return "--";
        }



    }
}
