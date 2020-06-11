using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Core
{
    public class OrderBusiness
    {
        private OrderSpecificationManager OrderSpecManager;
        public OrderBusiness(OrderSpecificationManager orderSpecManger)
        {
            this.OrderSpecManager = orderSpecManger;
        }

        public void SubmitOrder(Order order)
        {
            var spec = this.OrderSpecManager.GetSpecificationByCustomerType(order.Customer.CustomerType);
            if (order.Customer.CustomerType == CustomerType.Vip)
            {
                if (spec(order))
                {
                    Console.WriteLine(order.Customer.CustomerType+"以处理vip客户的逻辑提交");
                }
                else
                {
                    Console.WriteLine(order.Customer.CustomerType + "以处理Normal客户的逻辑提交");
                }
            }
            else if (order.Customer.CustomerType == CustomerType.Normal)
            {
                if (spec(order))
                {
                    Console.WriteLine(order.Customer.CustomerType + "以处理Normal客户的逻辑提交");
                }
                else
                {
                    Console.WriteLine(order.Customer.CustomerType + "以处理vip客户的逻辑提交");
                }
            }
        }

    }
}
