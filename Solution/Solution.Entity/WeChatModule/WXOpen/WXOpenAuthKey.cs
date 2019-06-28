﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiFos.Core.EnumHelper;

namespace Solution.Entity.WeChatModule.WXOpen
{

    /// <summary>
    /// 微信开放平台参数key
    /// @author yewei 
    /// @date 2018-04-15
    /// </summary>
    public enum WXOpenAuthKey
    {

        /// <summary>
        /// 10分钟会推送一次的component_verify_ticket
        /// </summary>
        cmpt_verify_ticket,

        /// <summary>
        /// 操作成功
        /// </summary>
        cmpt_access_token,

        /// <summary>
        /// 预授权码
        /// </summary> 
        pre_auth_code,

        /// <summary>
        /// 授权code,会在授权成功时返回给第三方平台，详见第三方平台授权流程说明
        /// </summary> 
        auth_code,

        /// <summary>
        /// 授权信息
        /// </summary> 
        auth_info,

        /// <summary>
        /// 刷新令牌，有效期，为2小时
        /// </summary> 
        auth_refresh_token,

        /// <summary>
        /// 授权后接口调用（UnionID）
        /// access_token 接口调用凭证超时时间
        /// </summary> 
        auth_code_access_token,

        /// <summary>
        /// access_token是调用授权关系接口的调用凭证，由于access_token有效期（目前为2个小时）较短，当access_token超时后，
        /// 可以使用refresh_token进行刷新，access_token刷新结果有两种：
        /// 1. 若access_token已超时，那么进行refresh_token会获取一个新的access_token，新的超时时间；
        /// 2. 若access_token未超时，那么进行refresh_token不会改变access_token，但超时时间会刷新，相当于续期access_token。
        /// refresh_token拥有较长的有效期（30天），当refresh_token失效的后，需要用户重新授权，所以，请开发者在refresh_token即将过期时（如第29天时），
        /// 进行定时的自动刷新并保存好它。
        /// </summary> 
        auth_code_refresh_access_token,

        /// <summary>
        /// 第三方平台的授权公众号token,
        /// 换取jsApi_ticket票据
        /// </summary> 
        wx_open_jsApi_ticket,


    }
}
