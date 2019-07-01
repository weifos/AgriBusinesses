﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.API.Code;
using Solution.Entity.Enums;
using Solution.Service;
using Solution.Service.LogsModule;

namespace Solution.API.Controllers
{
    /// <summary>
    /// Home控制器
    /// @author yewei 
    /// @date 2019-06-10
    /// </summary>
    //  [Authorize(Policy = "SignPolicy")]
    [Authorize]
    public class HomeController : BaseController
    {

        /// <summary>
        /// Home接口入口
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int id)
        {
            switch (id)
            {
                //登录
                case 200: return await Func200();
                //默认返回失败
                default: return Ok(APIResponse.GetResult(StateCode.State_6));
            }
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        private async Task<IActionResult> Func200()
        {
            return await Task.Run(() =>
            {
                try
                {
                    return APIResponse.GetResult(StateCode.State_200);
                }
                catch (Exception ex)
                {
                    ServiceIoc.Get<APILogsService>().Save("登录接口==>" + ex.ToString());
                    return APIResponse.GetResult(StateCode.State_500);
                }
            });
        }



    }
}