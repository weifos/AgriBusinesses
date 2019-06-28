using Solution.Entity.OrderModule;
using Solution.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeiFos.ORM.Data;

namespace Solution.Service.OrderModule
{
    /// <summary>
    /// 订单支付流程Service
    /// @author yewei
    /// @date 2018-12-17
    /// </summary>
    public class OrderPayFlowService : BaseService<OrderPayFlow>
    {


        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="order_id"></param>
        public List<OrderPayFlow> GetByOrderId(long order_id)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                return s.List<OrderPayFlow>("where order_id = @0 order by id desc", order_id);
            }
        }







    }
}
