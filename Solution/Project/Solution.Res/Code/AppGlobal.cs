﻿using System; 
using WeiFos.Core.NetCoreConfig;

namespace Solution.Res
{
    /// <summary>
    /// Copyright (c) 2013-2018 深圳微狐信息科技有限公司
    /// 描 述：系统全局配置类型 
    /// 创建人：叶委
    /// 日 期：2019.01.10
    /// </summary>
    public class AppGlobal
    {

        #region 单列模式  

        /*私有构造器，不能该类外部new对象*/
        private AppGlobal() { }

        private static AppGlobal instance = null;
        public static AppGlobal Instance
        {
            get { return instance = instance ?? new AppGlobal(); }
        }

        #endregion


        #region 基础参数配置

        /// <summary>
        /// 资源域名
        /// </summary>
        public static string Res { get { return ConfigManage.AppSettings<string>("AppSettings:DomainRes"); } }

        /// <summary>
        /// 系统后台域名
        /// </summary>
        public static string Admin { get { return ConfigManage.AppSettings<string>("AppSettings:DomainAdmin"); } }

        /// <summary>
        /// 系统名称
        /// </summary>
        public static string SysName { get { return ConfigManage.AppSettings<string>("AppSettings:SysName"); } }

        /// <summary>
        /// 脚本版本版本号
        /// </summary>
        public static string VNo { get { return ConfigManage.AppSettings<string>("AppSettings:VNo"); } }

        #endregion

         

    }
}