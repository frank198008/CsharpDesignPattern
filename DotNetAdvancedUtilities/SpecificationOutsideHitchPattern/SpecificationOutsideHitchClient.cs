using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Core;
using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Data;

namespace DotNetAdvancedUtilities.SpecificationOutsideHitchPattern
{
    public class SpecificationOutsideHitchClient
    {
        public void SubmitOrderByDefaultSpecManager()
        {
            var manager = OrderSpecificationManagerFactory.CreateNewOrderSpecificationManager();
            OrderBusiness business = new OrderBusiness(manager);
            using (manager)
            {
                var orderList = new List<Order>()
                {
                    new Order() { Customer=new Customer() {CustomerType = CustomerType.Normal} },
                    new Order() {Customer=new Customer() { CustomerType=CustomerType.Vip} }
                };
                Console.WriteLine("---Submit Order By Default SpecManager---");
                orderList.ForEach(o => business.SubmitOrder(o));
            }
            //manager 的dispose方法会被调用，在此方法中OrderSpecificationManagerFactory将默认规则管理器持久化起来
        }

        public void SubmitOrderByEditedSpecManager()
        {
            OrderSpecificationManager manager = OrderSpecificationManagerFactory.CreateNewOrderSpecificationManager();
            
            //动态修改规则
            manager.Specification[CustomerType.Normal] = (o => o.Customer.CustomerType == CustomerType.Vip);
            OrderBusiness business = new OrderBusiness(manager);
            //如果程序在别的机子上，也可以通过using将改变后的规则持久化，这新规则被保存到新的目录中，不会覆盖初始规则
            var orderList = new List<Order>()
                {
                    new Order() { Customer=new Customer() {CustomerType = CustomerType.Normal} },
                    new Order() {Customer=new Customer() { CustomerType=CustomerType.Vip} }
                };
            Console.WriteLine("---Submit Order By Edited SpecManager---");
            orderList.ForEach(o => business.SubmitOrder(o));
            
            //还原规则

            manager = OrderSpecificationManagerFactory.RebuildOrderSpecificationManager();
            business = new OrderBusiness(manager);
            Console.WriteLine("---Submit Order By RebuildOrderSpecificationManager---");
            orderList.ForEach(o => business.SubmitOrder(o));
        }
    }
}
