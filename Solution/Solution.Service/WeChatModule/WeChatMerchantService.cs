using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeiFos.ORM.Data;
using Solution.Entity.WeChatModule;
using Solution.Service.Common;

namespace Solution.Service.WeChatModule
{
    /// <summary>
    /// 微信商户 Service
    /// @author yewei 
    /// @date 2015-10-05
    /// </summary>
    public class WeChatMerchantService : BaseService<WeChatMerchant>
    {

        /// <summary>
        /// 获取商户信息
        /// </summary>
        /// <returns></returns>
        public WeChatMerchant Get()
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                return s.Get<WeChatMerchant>("", "");
            }
        }



        /// <summary>
        /// 保存商户信息
        /// </summary>
        /// <param name="merchant"></param>
        public void Save(WeChatMerchant merchant)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                int exist = s.Exist<WeChatMerchant>("where id > 0");
                if (exist == 0)
                {
                    s.Insert<WeChatMerchant>(merchant);
                }
                else
                {
                    s.Update<WeChatMerchant>(merchant);
                }
            }
        }



    }
}