using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.API.Controllers;
using WeiFos.Core.NetCoreConfig;
using Solution.Entity.Enums;
using Solution.Entity.UserModule;
using WeiFos.SDK.Model;
using WeiFos.SDK.Sign;
using Solution.Service;
using Solution.Service.UserModule;
using static IdentityModel.OidcConstants;

namespace Solution.API.Code.Filters
{
    /// <summary>
    /// 验签登录过滤器
    /// @author yewei 
    /// @date 2019-06-10
    /// </summary>
    public class CheckSignAttribute : ActionFilterAttribute
    { 
             
        /// <summary>
        /// 签名密钥
        /// </summary>
        private static string sign_secret = ConfigManage.AppSettings<string>("Jwt:Key"); 

        /// <summary>
        /// 执行Action之前
        /// </summary>
        /// <param name="context"></param>
        public async override void OnActionExecuting(ActionExecutingContext context)
        {
            //获取基类控制器
            var baseController = ((BaseController)context.Controller);
            
            //获取请求参数
            byte[] buffer = new byte[1024];
            var len = await context.HttpContext.Request.Body.ReadAsync(buffer, 0, buffer.Length);
            List<byte> list = new List<byte>();
            while (len > 0)
            {
                list.AddRange(buffer.Take(len));
                //读取完成跳出循环
                len = await context.HttpContext.Request.Body.ReadAsync(buffer, 0, buffer.Length);
            }
            //基类控制器
            baseController.DynamicStr = Encoding.UTF8.GetString(list.ToArray());
            //动态运行时对象
            baseController.Dynamic = JsonConvert.DeserializeObject<dynamic>(baseController.DynamicStr);

            //post提交方式
            if ("post".Equals(context.HttpContext.Request.Method.ToLower()))
            {
                if (context.HttpContext.User.Identity.IsAuthenticated)
                { 
                    string token = context.HttpContext.Request.Headers["Authorization"];
                    if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                    {
                        token = token.Substring("Bearer ".Length).Trim();
                    }
                }

                //数据包
                baseController.Sign = JsonConvert.DeserializeObject<SignPackage>(baseController.Dynamic.Global.ToString());

                //签名校验
                if (!WeiFosSign.SignAuth(sign_secret, baseController.DynamicStr))
                {
                    if (!ConfigManage.AppSettings<bool>("AppSettings:IsDebugModel"))
                    {
                        context.Result = APIResponse.GetResult(StateCode.State_5);
                    }
                    else
                    {
                        context.Result = APIResponse.GetResult(StateCode.State_5);
                    }
                    return;
                }
            } 
        }


        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
           await base.OnActionExecutionAsync(context, next);
        }


 





    }
}
