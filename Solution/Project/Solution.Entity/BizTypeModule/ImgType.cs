using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiFos.Core;

namespace Solution.Entity.BizTypeModule
{
    /// <summary>
    /// 图片路径配置实体类
    /// @author yewei 
    /// @date 2013-09-22
    /// </summary>
    public static class ImgType
    {

        /// <summary>
        /// 缺省图片路径
        /// </summary>
        public const string Default = "Default";

        /// <summary>
        /// 系统用户图
        /// </summary>
        public const string Sys_User = "Sys_User";
         
        /// <summary>
        /// 用户图
        /// </summary>
        public const string User = "User";

        /// <summary>
        /// 用户图
        /// </summary>
        public const string Level = "Level";

        /// <summary>
        /// 微信账号 图
        /// </summary>
        public const string WX_Account = "WX_Account";

        /// <summary>
        /// 成功案例 图
        /// </summary>
        public const string Case_Cover = "Case_Cover";

        /// <summary>
        /// 图文封面 图
        /// </summary>
        public const string ImgTextReply_Title = "ImgTextReply_Title";

        /// <summary>
        /// 图文详情 图
        /// </summary>
        public const string ImgTextReply_Details = "ImgTextReply_Details";

        /// <summary>
        /// 文章封面 图
        /// </summary>
        public const string Informt = "Informt";

        /// <summary>
        /// 资讯详情 图
        /// </summary>
        public const string Informt_Details = "Informt_Details";

        /// <summary>
        /// 资讯类别 图
        /// </summary>
        public const string InformtCgty = "InformtCgty";

        /// <summary>
        /// 合作伙伴 图
        /// </summary>
        public const string Partner = "Partner";

        /// <summary>
        /// AppBanner图
        /// </summary>
        public const string Banner = "Banner";

        /// <summary>
        /// 广告图
        /// </summary>
        public const string AppBanner = "AppBanner";

        /// <summary>
        /// 商城广告图
        /// </summary>
        public const string Advertise = "Advertise";

        /// <summary>
        /// 微商城商品封面图
        /// </summary>
        public const string Product_Cover = "Product_Cover";

        /// <summary>
        /// 微商城商品详情图
        /// </summary>
        public const string Product_Details = "Product_Details";

        /// <summary>
        /// 微商城商品导购类别图
        /// </summary>
        public const string GuideProduct_Cgty = "GuideProduct_Cgty";

        /// <summary>
        /// 商品品牌图
        /// </summary>
        public const string Product_Brand = "Product_Brand";



        public static List<string> ImgTypeList = new List<string>(){
            ImgType.Sys_User, 
            ImgType.User,
            ImgType.WX_Account,
            ImgType.ImgTextReply_Title,
            ImgType.ImgTextReply_Details,
            ImgType.Informt,
            ImgType.Informt_Details,
            ImgType.InformtCgty,
            ImgType.Partner,
            ImgType.Banner,
            ImgType.AppBanner, 
            ImgType.Case_Cover,
            ImgType.Product_Cover,
            ImgType.Product_Details,
            ImgType.Product_Brand,
            ImgType.GuideProduct_Cgty,
            ImgType.Partner
        };


        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="imgtype"></param>
        /// <returns></returns>
        public static bool exist(string imgtype)
        {
            return ImgTypeList.Contains(imgtype);
        }



    }
}
