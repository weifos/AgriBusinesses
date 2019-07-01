using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.Entity.UserModule;
using WeiFos.SDK.Model;

namespace Solution.API.Controllers
{
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
            string s = "";
        }

        //域名
        public string WeiFos_Com;
        //接口地址
        public string WeiFos_Api;
        //资源站点
        public string WeiFos_Res;
        //手机站点
        public string WeiFos_Mob;
        //签名字符串
        public SignPackage Sign;
        //当前json格式字符串
        internal protected string DynamicStr;
        //当前参数对象
        internal protected dynamic Dynamic;
        //当前用户信息
        public User user = null;
    }
}