using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Entity.BizTypeModule
{
    /// <summary>
    /// 企业信息配置实体类
    /// @author yewei 
    /// @date 2013-09-11
    /// </summary>
    public class WebIntroductionType
    {
        /// <summary>
        /// 关于我们
        /// </summary>
        public const string AboutUs = "AboutUs";

        /// <summary>
        /// 联系我们
        /// </summary>
        public const string Contact = "Contact";

        /// <summary>
        /// 蚂蚁学院
        /// </summary>
        public const string AntCollege = "AntCollege";

        /// <summary>
        /// 蚂蚁学院-易货流程
        /// </summary>
        public const string BarterProcess = "BarterProcess";

        /// <summary>
        /// 蚂蚁学院-注册流程
        /// </summary>
        public const string RegisterProcess = "RegisterProcess";

        /// <summary>
        /// 蚂蚁学院-易货知识
        /// </summary>
        public const string BarterKnowledge = "BarterKnowledge";

        /// <summary>
        /// 蚂蚁学院-易货规则
        /// </summary>
        public const string BarterRule = "BarterRule";

        /// <summary>
        /// 蚂蚁学院-蚂蚁问答
        /// </summary>
        public const string AntQa = "AntQa";


        /// <summary>
        /// 书房系统邮箱发送模板
        /// </summary>
        public const string EmailTmp = "EmailTmp";


        public static Dictionary<string, string> intList = new Dictionary<string, string>()
        {
            {WebIntroductionType.Contact,"联系我们"},
            {WebIntroductionType.AboutUs,"关于我们"},
            {WebIntroductionType.AntCollege,"蚂蚁学院"},
            {WebIntroductionType.BarterProcess,"蚂蚁学院-易货流程"},
            {WebIntroductionType.RegisterProcess,"蚂蚁学院-注册流程"},
            {WebIntroductionType.BarterKnowledge,"蚂蚁学院-易货知识"},
            {WebIntroductionType.BarterRule,"蚂蚁学院-易货规则" },
            {WebIntroductionType.AntQa,"蚂蚁学院-蚂蚁问答" },
            {WebIntroductionType.EmailTmp,"书房系统邮箱发送模板" }
        };


        public static string GetValueBykey(string key)
        {
            foreach (var item in intList)
            {
                if (key.Equals(item.Key))
                {
                    return item.Value;
                }
            }
            return "暂无";
        }


    }


}