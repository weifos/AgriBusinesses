using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Entity.Enums;
using Solution.Res.Code.Upload;
using Solution.Entity.Common;

namespace Solution.Res.Code
{
    /// <summary>
    /// 上传票据校验
    /// @author yewei 
    /// @date 2016-04-21
    /// </summary>
    public class CheckUp : ActionFilterAttribute
    {


        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            bool ispass = Uploader.CheckUploadFile(actionContext.HttpContext);
            if (!ispass)
            {
                actionContext.Result = APIResponse.Instance.ContentResult(StateCode.State_5);
            }
            return;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionContext"></param>
        //public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next);
        //{ 
        //    bool ispass = Uploader.CheckUploadFile();
        //    if (!ispass)
        //    {
        //        actionContext.Result = APIResponse.toJson(StateCode.State_500, "上传票据校验失败");
        //    }
        //    return;
        //}


    }
}
