using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.LanguageComponentPattern.Data
{
    [Serializable]
    public class Order : List<OrderItem>, IEnumerable<OrderItem>
    {
        public Customer Customer{get;set;}
        public string OrderNo { get; set; }
    }
}
