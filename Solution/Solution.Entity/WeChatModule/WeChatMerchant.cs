using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeiFos.ORM.Data.Attributes;

namespace Solution.Entity.WeChatModule
{
    /// <summary>
    /// 微信公众号商户信息
    /// @author yewei 
    /// add by @date 2015-10-20
    /// </summary>
    [Serializable]
    [Table(Name = "tb_wx_merchant")]
    public class WeChatMerchant 
    {

        /// <summary>
        /// 主键ID
        /// </summary>
        [ID]
        public long id { get; set; }

        /// <summary>
        /// APPID
        /// </summary>
        public string app_id { get; set; }

        /// <summary>
        /// 商户号ID
        /// </summary>
        public string mch_id { get; set; }

        /// <summary>
        /// app秘钥
        /// </summary>
        public string app_secret { get; set; }

        /// <summary>
        /// app支付key
        /// </summary>
        public string pay_key { get; set; }
    }
}
