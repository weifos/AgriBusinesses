using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiFos.Core.EnumHelper;

namespace Solution.Entity.Enums
{
    /// <summary>
    /// 全局状态返回码
    /// @author yewei 
    /// @date 2015-05-17
    /// </summary>
    public enum StateCode
    {

        #region 常用状态

        /// <summary>
        /// 操作失败
        /// </summary>
        [EnumAttribute("操作失败")]
        State_500 = 500,

        /// <summary>
        /// 操作成功
        /// </summary>
        [EnumAttribute("操作成功")]
        State_200 = 200,

        /// <summary>
        /// 验证通过
        /// </summary>
        [EnumAttribute("验证通过")]
        State_0 = 0,

        /// <summary>
        /// 验证未通过
        /// </summary>
        [EnumAttribute("验证未通过")]
        State_1 = 1,

        /// <summary>
        /// 数据不存在
        /// </summary>
        [EnumAttribute("数据不存在")]
        State_2 = 2,

        /// <summary>
        /// 配置参数不存在或未启用
        /// </summary>
        [EnumAttribute("配置参数不存在或未启用")]
        State_3 = 3,

        /// <summary>
        /// 用户原始密码不正确
        /// </summary>
        [EnumAttribute("用户原始密码不正确")]
        State_4 = 4,

        /// <summary>
        /// 签名失败
        /// </summary>
        [EnumAttribute("签名失败")]
        State_5 = 5,

        /// <summary>
        /// 配置参数错误
        /// </summary>
        [EnumAttribute("配置参数错误")]
        State_6 = 6,

        #endregion


        #region 短信模块状态码 范围（50~100）

        /// <summary>
        /// 手机号码不能为空
        /// </summary>
        [EnumAttribute("手机号码不能为空")]
        State_50 = 50,

        /// <summary>
        /// 验证码不存在
        /// </summary>
        [EnumAttribute("验证码不存在")]
        State_51 = 51,

        /// <summary>
        /// 验证码已过期
        /// </summary>
        [EnumAttribute("验证码已过期")]
        State_52 = 52,

        /// <summary>
        /// 验证码错误
        /// </summary>
        [EnumAttribute("验证码错误")]
        State_53 = 53,

        /// <summary>
        /// 请点击获取验证
        /// </summary>
        [EnumAttribute("请点击获取验证")]
        State_54 = 54,

        /// <summary>
        /// 验证码不能为空
        /// </summary>
        [EnumAttribute("验证码不能为空")]
        State_55 = 55,

        /// <summary>
        /// 验证码已经被使用过了
        /// </summary>
        [EnumAttribute("验证码已经被使用过了")]
        State_56 = 56,

        /// <summary>
        /// 手机号码格式有误
        /// </summary>
        [EnumAttribute("手机号码格式有误")]
        State_57 = 57,

        #endregion


        #region 系统用户状态 范围（101~150）

        /// <summary>
        /// 用户或密码错误
        /// </summary>
        [EnumAttribute("用户或密码错误")]
        State_101 = 101,

        /// <summary>
        /// 登录超时
        /// </summary>
        [EnumAttribute("登录超时")]
        State_102 = 102,

        /// <summary>
        /// 密码错误
        /// </summary>
        [EnumAttribute("密码错误")]
        State_103 = 103,

        /// <summary>
        /// 验证码错误
        /// </summary>
        [EnumAttribute("验证码错误")]
        State_104 = 104,


        #endregion


        #region 微信公众号状态码 范围（151~200）

        /// <summary>
        /// 微信公众号类型验证失败
        /// </summary>
        [EnumAttribute("微信公众号类型验证失败,请核对输入是否有误! 错误代码")]
        State_151 = 151,

        /// <summary>
        /// 微信菜单设置失败
        /// </summary>
        [EnumAttribute("微信菜单设置失败")]
        State_152 = 152,

        #endregion


        #region 平台用户业务状态 （201~250）

        /// <summary>
        /// 登录名或登录密码不正确
        /// </summary>
        [EnumAttribute("登录名或登录密码不正确")]
        State_201 = 201,

        /// <summary>
        /// 该用户已经被注册
        /// </summary>
        [EnumAttribute("该用户已经被注册")]
        State_202 = 202,

        /// <summary>
        /// 两次密码不一致
        /// </summary>
        [EnumAttribute("两次密码不一致")]
        State_203 = 203,

        /// <summary>
        /// 无效的令牌token
        /// </summary>
        [EnumAttribute("无效的令牌token")]
        State_204 = 204,

        /// <summary>
        /// 登录信息已失效
        /// </summary>
        [EnumAttribute("登录信息已失效")]
        State_205 = 205,

        /// <summary>
        /// 手机号码已经被注册
        /// </summary>
        [EnumAttribute("手机号码已经被注册")]
        State_206 = 206,

        /// <summary>
        /// 不存在的手机号码
        /// </summary>
        [EnumAttribute("不存在的手机号码")]
        State_207 = 207,

        /// <summary>
        /// 请绑定新手机号码
        /// </summary>
        [EnumAttribute("请绑定新手机号码")]
        State_208 = 208,

        /// <summary>
        /// 用户已被冻结
        /// </summary>
        [EnumAttribute("用户已被冻结")]
        State_209 = 209,

        /// <summary>
        /// 无效的令牌token
        /// </summary>
        [EnumAttribute("无效的令牌token")]
        State_210 = 210,

        /// <summary>
        /// 令牌Token不能为空
        /// </summary>
        [EnumAttribute("请登录后再操作")]
        State_211 = 211,

        /// <summary>
        /// 登录信息已失效
        /// </summary>
        //[EnumAttribute("登录信息已失效")]
        //State_212 = 212,

        /// <summary>
        /// 用户已被冻结
        /// </summary>
        [EnumAttribute("用户已被冻结")]
        State_213 = 213,

        /// <summary>
        /// 手机号码已经被注册
        /// </summary>
        [EnumAttribute("手机号码已经被注册")]
        State_214 = 214,
        /// <summary>
        /// 邮箱已经被注册
        /// </summary>
        [EnumAttribute("邮箱已经被注册")]
        State_215 = 215,
        /// <summary>
        /// 证件已经被注册
        /// </summary>
        [EnumAttribute("证件已经被注册")]
        State_216 = 216, 
        /// <summary>
        /// 请绑定新手机号码
        /// </summary>
        [EnumAttribute("请绑定新手机号码")]
        State_217 = 217,
        /// <summary>
        /// 邮箱不能为空
        /// </summary>
        [EnumAttribute("邮箱不能为空")]
        State_218 = 218,
        /// <summary>
        /// 请不要绑定当前邮箱
        /// </summary>
        [EnumAttribute("请不要绑定当前邮箱")]
        State_219 = 219,

        /// <summary>
        /// 邮件已发送
        /// </summary>
        [EnumAttribute("邮件已发送")]
        State_220 = 220,

        /// <summary>
        /// 邮件发送失败
        /// </summary>
        [EnumAttribute("邮件发送失败")]
        State_221 = 221,
        /// <summary>
        /// 请绑定手机号码
        /// </summary>
        [EnumAttribute("请绑定手机号码")]
        State_222 = 222,

        /// <summary>
        /// 不存在该用户
        /// </summary>
        [EnumAttribute("用户信息不存在")]
        State_223 = 223,

        /// <summary>
        /// 暂未配送邮件模板
        /// </summary>
        [EnumAttribute("暂未配送邮件模板")]
        State_224 = 224,

        /// <summary>
        /// 邮件发送失败
        /// </summary>
        [EnumAttribute("邮件发送失败")]
        State_225 = 225,

        /// <summary>
        /// 不存在的认证信息
        /// </summary>
        [EnumAttribute("不存在的认证信息")]
        State_226 = 226,

        /// <summary>
        /// 添加购物车数量不能为空
        /// </summary>
        [EnumAttribute("添加购物车数量不能为空")]
        State_227 = 227,

        /// <summary>
        /// 会员等级不满足借书
        /// </summary>
        [EnumAttribute("会员等级不满足借书")]
        State_228 = 228,

        /// <summary>
        /// 会员借书数量已达上限
        /// </summary>
        [EnumAttribute("会员借书数量已达上限")]
        State_229 = 229,

        /// <summary>
        /// 会员借书总额已达上限
        /// </summary>
        [EnumAttribute("会员借书总额已达上限")]
        State_230 = 230,

        /// <summary>
        /// 会员借阅近期借阅次数已达上限
        /// </summary>
        [EnumAttribute("会员借阅近期借阅次数已达上限")]
        State_231 = 231,

        /// <summary>
        /// 未绑定微信账号
        /// </summary>
        [EnumAttribute("未绑定微信账号")]
        State_232 = 232,

        /// <summary>
        /// 该会员已存在申请的会员信息
        /// </summary>
        [EnumAttribute("该会员已存在申请的会员信息")]
        State_233 = 233,

        /// <summary>
        /// 该会员信息认证未完成
        /// </summary>
        [EnumAttribute("该会员信息认证未完成")]
        State_234 = 234,

        /// <summary>
        /// 不存在的微信用户
        /// </summary>
        [EnumAttribute("不存在的微信用户")]
        State_235 = 235,

        /// <summary>
        /// 不存在的押金记录
        /// </summary>
        [EnumAttribute("不存在的押金记录")]
        State_236 = 236,

        /// <summary>
        /// 不存在的借阅记录
        /// </summary>
        [EnumAttribute("不存在的借阅记录")]
        State_237 = 237,

        /// <summary>
        /// 该罚金已经支付
        /// </summary>
        [EnumAttribute("该罚金已经支付")]
        State_238 = 238,

        /// <summary>
        /// 该信息存在逾期罚金未缴纳，不能还书
        /// </summary>
        [EnumAttribute("该信息存在逾期罚金未缴纳，不能还书")]
        State_239 = 239,

        /// <summary>
        /// 会员预约数量已达上限
        /// </summary>
        [EnumAttribute("会员预约数量已达上限")]
        State_240= 240,

        #endregion


        #region RFID标签模块 （251~300）

        /// <summary>
        /// 该库存未借阅
        /// </summary>
        [EnumAttribute("该库存未借阅")]
        State_251 = 251,

        /// <summary>
        /// 该库存已上架
        /// </summary>
        [EnumAttribute("该库存已上架")]
        State_252 = 252,

        /// <summary>
        /// 新增二维码数量必须大于0 且小于10000
        /// </summary>
        [EnumAttribute("新增二维码数量必须大于0 且小于10000")]
        State_253 = 253,

        #endregion


        #region 资源上传模板状态码 范围（351~400）

        /// <summary>
        /// 上传参数异常
        /// </summary>
        [EnumAttribute("上传参数异常")]
        State_351 = 351,

        /// <summary>
        /// 上传票据校验失败
        /// </summary>
        [EnumAttribute("上传票据校验失败")]
        State_352 = 352,

        #endregion


        #region 图书借阅模块（401~450）


        /// <summary>
        /// 该图书未上架
        /// </summary>
        [EnumAttribute("该图书未上架，不能外借")]
        State_401 = 401,

        /// <summary>
        /// 该图书未设置借阅状态
        /// </summary>
        [EnumAttribute("该图书未设置借阅状态，不能外借")]
        State_402 = 402,

        /// <summary>
        /// 该图书不存在，请联系管理员
        /// </summary>
        [EnumAttribute("该图书不存在，请联系管理员")]
        State_403 = 403,

        /// <summary>
        /// 该图书未入库
        /// </summary>
        [EnumAttribute("该图书未入库")]
        State_404 = 404,

        /// <summary>
        /// 该图已被预约
        /// </summary>
        [EnumAttribute("该图书已被预约")]
        State_405 = 405,

        /// <summary>
        /// 该图书已被外借
        /// </summary>
        [EnumAttribute("该图书已被外借")]
        State_406 = 406,

        #endregion


        #region 待定 （450~500）


        #endregion


        #region 平台商品模块 范围（501~550）

        /// <summary>
        /// 该商品不存在
        /// </summary>
        [EnumAttribute("该商品不存在")]
        State_501 = 501,

        /// <summary>
        /// 商品库存不足
        /// </summary>
        [EnumAttribute("商品库存不足")]
        State_502 = 502,

        /// <summary>
        /// 该商品存在库存引用
        /// </summary>
        [EnumAttribute("该商品存在库存引用")]
        State_503 = 503,

        /// <summary>
        /// 退订的商品数量不能大于订单商品数量
        /// </summary>
        [EnumAttribute("退订的商品数量不能大于订单商品数量")]
        State_504 = 504,

        /// <summary>
        /// 改商品入库已达订单商品数
        /// </summary>
        [EnumAttribute("该商品入库已达订单商品数")]
        State_505 = 505,

        /// <summary>
        /// TID号已存在
        /// </summary>
        [EnumAttribute("TID号已存在")]
        State_506 = 506,

        /// <summary>
        /// 二维码编号已存在
        /// </summary>
        [EnumAttribute("二维码编号已存在")]
        State_507 = 507,

        /// <summary>
        /// ISBN号已存在
        /// </summary>
        [EnumAttribute("ISBN号已存在")]
        State_508 = 508,

        /// <summary>
        /// 该商品不能外借
        /// </summary>
        [EnumAttribute("该商品不能外借")]
        State_509 = 509,

        /// <summary>
        /// 该商品已经外借
        /// </summary>
        [EnumAttribute("该商品已经外借")]
        State_510 = 510,

        /// <summary>
        /// 该商品未上架，不能外借
        /// </summary>
        [EnumAttribute("该商品未上架，不能外借")]
        State_511 = 511,

        /// <summary>
        /// 二维码编号已绑定
        /// </summary>
        [EnumAttribute("二维码编号已绑定")]
        State_512 = 512,

        /// <summary>
        /// 二维码编号不存在
        /// </summary>
        [EnumAttribute("二维码编号不存在")]
        State_513 = 513,

        /// <summary>
        /// 购物车中存在已外借的图书
        /// </summary>
        [EnumAttribute("购物车中存在已外借的图书")]
        State_514 = 514,

        /// <summary>
        /// 购物车中存在不能外借的图书
        /// </summary>
        [EnumAttribute("购物车中存在不能外借的图书")]
        State_515 = 515,

        /// <summary>
        /// 购物车中存在未上架的图书
        /// </summary>
        [EnumAttribute("购物车中存在未上架的图书")]
        State_516 = 516,

        /// <summary>
        /// 购物车中存在已过期商品
        /// </summary>
        [EnumAttribute("购物车中存在已过期商品")]
        State_517 = 517,

        /// <summary>
        /// 该图书已被外借
        /// </summary>
        [EnumAttribute("该图书已被外借")]
        State_518 = 518,

        /// <summary>
        /// 该图书已被预约
        /// </summary>
        [EnumAttribute("该图书已被预约")]
        State_519 = 519,

        /// <summary>
        /// 不存在的预约记录
        /// </summary>
        [EnumAttribute("不存在的预约记录")]
        State_520 = 520,

        /// <summary>
        /// 未设置借阅参数，请联系管理员
        /// </summary>
        [EnumAttribute("未设置借阅参数，请联系管理员")]
        State_521 = 521,

        /// <summary>
        /// 当前扫码书籍和预约书籍不一致
        /// </summary>
        [EnumAttribute("当前扫码书籍和预约书籍不一致")]
        State_522 = 522,

        /// <summary>
        /// 当前图书已确认预约
        /// </summary>
        [EnumAttribute("当前图书已确认预约")]
        State_523 = 523,

        /// <summary>
        /// 当前图书已自动取消预约
        /// </summary>
        [EnumAttribute("当前图书未被预约")]
        State_524 = 524,

        /// <summary>
        /// 未设置借阅参数，请联系管理员
        /// </summary>
        [EnumAttribute("未设置续借参数，请联系管理员")]
        State_525 = 525,

        /// <summary>
        /// 续借次数已达上限
        /// </summary>
        [EnumAttribute("续借次数已达上限")]
        State_526 = 526,

        /// <summary>
        /// 该图书已逾期，不能续借
        /// </summary>
        [EnumAttribute("该图书已逾期，不能续借")]
        State_527 = 527,

        #endregion


        #region 平台商品订单模块 范围（551~600）

        /// <summary>
        /// 不存在的商品订单
        /// </summary>
        [EnumAttribute("不存在的商品订单")]
        State_551 = 551,

        /// <summary>
        /// 该商品订单未支付
        /// </summary>
        [EnumAttribute("该商品订单未支付")]
        State_552 = 552,

        /// <summary>
        /// 该商品订单未申请退款
        /// </summary>
        [EnumAttribute("该商品订单未申请退款")]
        State_553 = 553,

        /// <summary>
        /// 退款金额不能大于订单金额
        /// </summary>
        [EnumAttribute("退款金额不能大于订单金额")]
        State_554 = 554,

        /// <summary>
        /// 该订单已发货
        /// </summary>
        [EnumAttribute("该订单已发货")]
        State_555 = 555,

        /// <summary>
        /// 订单金额不能为零
        /// </summary>
        [EnumAttribute("订单金额不能为零")]
        State_556 = 556,


        #endregion


        #region 待定（601~650）


        #endregion


        #region 微信支付模块状态码 范围（651~700）

        /// <summary>
        /// 服务端未配置公众号
        /// </summary>
        [EnumAttribute("服务端未配置公众号")]
        State_651 = 651,

        /// <summary>
        /// 服务端未配置公众号商户信息
        /// </summary>
        [EnumAttribute("服务端未配置公众号商户信息")]
        State_652 = 652,

        /// <summary>
        /// 请求支付的订单不存在
        /// </summary>
        [EnumAttribute("请求支付的订单不存在")]
        State_653 = 653,

        /// <summary>
        /// 预付单请求失败
        /// </summary>
        [EnumAttribute("预付单请求失败")]
        State_654 = 654,

        #endregion


        #region 前端管理 范围（701~750）

        /// <summary>
        /// 请选择最后一级导购分类
        /// </summary>
        [EnumAttribute("请选择最后一级导购分类")]
        State_701 = 701,

        #endregion


        #region 资源模块 状态范围[9000至10000]

        /// <summary>
        /// 参数验证失败
        /// </summary>
        [EnumAttribute("参数验证失败")]
        State_9000 = 9000,


        /// <summary>
        /// 参数验证失败
        /// </summary>
        [EnumAttribute("参数验证失败")]
        State_9001 = 9001,

        #endregion


        #region 关键词模块 状态码范围[10001至 11000]

        /// <summary>
        /// 关键词不能为空
        /// </summary>
        [EnumAttribute("关键词不能为空")]
        State_10005 = 10005,

        /// <summary>
        /// 关键词已存在
        /// </summary>
        [EnumAttribute("关键词已存在")]
        State_10010 = 10010,

        #endregion


        #region 微信菜单绑定 状态码范围[11001至 12000]

        /// <summary>
        /// 微信菜单设置失败
        /// </summary>
        [EnumAttribute("微信菜单设置失败")]
        State_11001 = 11001,

        /// <summary>
        /// 微信菜单设置失败
        /// </summary>
        [EnumAttribute("微信菜单设置失败")]
        State_11002 = 11002,

        #endregion
    }
}
