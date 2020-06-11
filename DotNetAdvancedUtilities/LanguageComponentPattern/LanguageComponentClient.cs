using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAdvancedUtilities.LanguageComponentPattern.Data;
using DotNetAdvancedUtilities.LanguageComponentPattern.Core;

namespace DotNetAdvancedUtilities.LanguageComponentPattern
{
    public class LanguageComponentClient
    {

        public void RunLang()
        {
            Order order = new Order() { Customer = new Customer() { CustomerType = CustomerType.Vip } };
            order.Add(new OrderItem() { Product = new Product() { Id="12343",Name="IPhone6",Price=5000},Number=100});
            order.Add(new OrderItem() { Product = new Product() { Id = "34567", Name = "M6", Price = 3000 }, Number = 1000 });

            using(var lang = LanguageComponentManagerFactory.ReBuildLanguageComponent())
            {
                lang.Resume();
            }
        }
    }
}
