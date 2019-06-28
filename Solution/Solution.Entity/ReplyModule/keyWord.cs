using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiFos.ORM.Data.Attributes;

namespace Solution.Entity.ReplyModule
{
    /// <summary>
    /// 关键字实体类
    /// @author yewei 
    /// @date 2013-09-21
    /// </summary>
    [Serializable]
    [Table(Name = "")]
    public class KeyWord : BaseClass
    {
 

		/// <summary>
		/// 主键ID
		/// </summary>
        [ID]
        public int id { get; set; }

        /// <summary>
        /// 公众号ID
        /// </summary>
        public int account_id { get; set; }

		/// <summary>
		/// 回复关键词
		/// </summary>
        public string keyword { get; set; }

        /// <summary>
        /// 查询类型 ture 按关键词全部匹配，false 按关键词 包含匹配
        /// </summary>
        public bool search_type { get; set; }

        /// <summary>
        /// 所属模块业务  
        /// </summary>
        public string biz_type { get; set; }

        /// <summary>
        /// 所属模块业务ID
        /// </summary>
        public long biz_id { get; set; }


        /// <summary>
        /// 是否有效
        /// </summary>
        public bool is_enable { get; set; }
    }
}
