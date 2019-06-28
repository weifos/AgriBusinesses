using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeiFos.Core.EnumHelper;

namespace Solution.Entity.Enums
{
    /// <summary>
    /// 短信业务类型
    /// @author yewei 
    /// @date 2015-05-17
    /// </summary>
    public enum SendSmsType
    {
        /// <summary>
        /// 会员注册
        /// </summary>
        [EnumAttribute("会员注册")]
        Register = 1,

        /// <summary>
        /// 绑定新手机
        /// </summary>
        [EnumAttribute("绑定新手机")]
        BindNewMobile = 5,

        /// <summary>
        /// 找回密码
        /// </summary>
        [EnumAttribute("找回密码")]
        ForgetPsw = 10,

        /// <summary>
        /// 设置密码
        /// </summary>
        [EnumAttribute("设置密码")]
        SetPsw = 11,

        /// <summary>
        /// 充值
        /// </summary>
        [EnumAttribute("充值")]
        Recharge = 15,

        /// <summary>
        /// 申请会员
        /// </summary>
        [EnumAttribute("申请会员")]
        ApplyMember = 16,

        /// <summary>
        /// 退款申请审核
        /// </summary>
        [EnumAttribute("退款申请审核")]
        Refund = 20

    }
}
