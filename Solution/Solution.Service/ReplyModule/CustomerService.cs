using System;
using WeiFos.Core.XmlHelper;
using WeiFos.WeChat.WXRequest;
using WeiFos.WeChat.WXResponse;

namespace Solution.Service.ReplyModule
{
    /// <summary>
    /// 客服回复Service
    /// 2014-9-28
    /// @author yewei
    /// </summary>
    public class CustomerService
    {
        /// <summary>
        /// 微信客服回复序列化
        /// </summary>
        /// <param name="wxRequest"></param>
        /// <returns></returns>
        public string GetWXResponseMsg(WXReqBaseMsg wxRequest)
        {

                WXRepBaseMsg wXRepTextReply = new WXRepBaseMsg();

                wXRepTextReply.CreateTime = DateTime.Now.Ticks;
                wXRepTextReply.FromUserName = wxRequest.ToUserName;
                wXRepTextReply.ToUserName = wxRequest.FromUserName;
                wXRepTextReply.MsgType = "transfer_customer_service";

                return XmlConvertHelper.SerializeObject<WXRepBaseMsg>(wXRepTextReply);


        }
    }
}
