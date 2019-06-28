using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiFos.ORM.Data.Attributes;

namespace Solution.Entity.ReplyModule
{
    /// <summary>
    /// 文本回复实体类
    /// @author yewei 
    /// @date 2013-10-22
    /// </summary>
    [Serializable]
    [Table(Name = "")]
    public class TextReply : BaseClass
    {
        #region Model

        /// <summary>
        /// 主键ID
        /// </summary>
        [ID]
        public int id { get; set; }

        /// <summary>
        /// 账号ID
        /// </summary>
        public int account_id { get; set; }

        /// <summary>
        /// 回复类容
        /// </summary>
        public string reply_contents { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        public bool search_type { get; set; }



        #endregion Model
    }
}
