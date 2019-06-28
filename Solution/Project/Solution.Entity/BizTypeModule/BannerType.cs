using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Entity.BizTypeModule
{
    /// <summary>
    /// 广告图片类型
    /// @author yewei 
    /// @date 2013-07-24
    /// </summary>
    public class BannerType
    {
         
        /// <summary>
        /// 微信或APP轮播广告图
        /// </summary>
        public const int AppBanner = 200;


        public static Dictionary<int, string> BannerList = new Dictionary<int, string>()
        {
            {BannerType.AppBanner,"微信或APP—轮播广告图"}
        };


        public static string GetValueBykey(int key)
        {
            foreach (var item in BannerList)
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