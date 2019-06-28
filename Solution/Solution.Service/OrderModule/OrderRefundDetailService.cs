﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeiFos.ORM.Data;
using Solution.Entity.OrderModule;
using Solution.Service.Common;

namespace Solution.Service.MessageModule
{


    public class OrderRefundDetailService : BaseService<OrderRefundDetail>
    {
        public List<OrderRefundDetail> GetListByOrderId(long refund_id)
        {
            using (ISession s = SessionFactory.Instance.CreateSession())
            {
                return s.List<OrderRefundDetail>(@" where refund_id = @0 ", refund_id);
            }
        }
    }




}
