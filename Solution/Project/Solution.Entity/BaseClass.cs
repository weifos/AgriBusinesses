using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Entity
{
    /// <summary>
    /// 实体类基类
    /// @author yewei 
    /// @date 2013-09-21
    /// </summary>
    [Serializable]
    public class BaseClass
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        public long? created_user_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? created_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? updated_date { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public long? updated_user_id { get; set; }

    }
}
