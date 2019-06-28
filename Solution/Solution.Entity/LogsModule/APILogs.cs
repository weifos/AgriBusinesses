using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeiFos.ORM.Data.Attributes;

namespace Solution.Entity.LogsModule
{
    /// <summary>
    /// 接口日志 实体类
    /// @author yewei 
    /// add by @date 2015-09-25
    /// </summary>
    [Serializable]
    [Table(Name = "tb_logs_api")]
    public class APILogs
    {

        /// <summary>
        /// 主键ID
        /// </summary>
        [ID]
        public long id { get; set; }


        /// <summary>
        /// 操作内容
        /// </summary>
        public string content { get; set; }


        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime created_date { get; set; }


        /// <summary>
        /// 日志类型
        /// </summary>
        public int type { get; set; }

    }
}
