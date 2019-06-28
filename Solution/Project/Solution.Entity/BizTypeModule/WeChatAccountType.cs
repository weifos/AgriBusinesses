using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Entity.BizTypeModule
{
    /// <summary>
    /// 公众号类型 配置类
    /// @author yewei 
    /// @date 2013-10-03
    /// </summary>
    public class WeChatAccountType
    {
        /// <summary>
        /// 订阅号
        /// </summary>
        public const int Subscriber = 1;

        /// <summary>
        /// 认证订阅号
        /// </summary>
        public const int AuthSubscriber = 2;

        /// <summary>
        /// 服务号
        /// </summary>
        public const int Service = 3;

        /// <summary>
        /// 认证服务号
        /// </summary>
        public const int AuthService = 4;

        public static Dictionary<int, string> accountTypeList = new Dictionary<int, string>()
        {
            {WeChatAccountType.Subscriber,"订阅号"},
            {WeChatAccountType.AuthSubscriber,"认证订阅号"},
            {WeChatAccountType.Service,"服务号"},
            {WeChatAccountType.AuthService,"认证服务号"}
        };

        /// <summary>
        /// 根据key获取值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValueByKey(int key)
        {
            foreach (var item in accountTypeList)
            {
                if (key.Equals(item.Key))
                {
                    return item.Value;
                }
            }
            return "暂无";
        }

    }

}
