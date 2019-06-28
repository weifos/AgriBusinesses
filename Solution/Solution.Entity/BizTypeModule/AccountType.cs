using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Entity.BizTypeModule
{
    /// <summary>
    /// 账号类型 实体类
    /// @author yewei 
    /// @date 2015-03-16
    /// </summary>
    public class AccountType
    {
        /// <summary>
        /// 0：平台账号
        /// </summary>
        public const int Platform = 0;

        /// <summary>
        /// 2: 门店
        /// </summary>
        public const int Store = 2;

        /// <summary>
        /// 4: 门店员工
        /// </summary>
        public const int Employee = 4;

        /// <summary>
        /// 账号类型
        /// </summary>
        public static List<int> AccountTypeList = new List<int>(){
            AccountType.Platform,
            AccountType.Store,
            AccountType.Employee
        };

    }

}
