using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Core
{
    [Serializable]
    public class OrderSpecificationManager : IDisposable
    {
        public Dictionary<CustomerType,OrderSpecificationIndex> Specification { get; set; }

        public OrderSpecificationIndex GetSpecificationByCustomerType(CustomerType type)
        {
            if (this.Specification.ContainsKey(type))
            {
                return this.Specification[type];
            }
            return null;
        }
        public void Dispose()
        {
            //Console.WriteLine("Dispose 被调用");
            OrderSpecificationManagerFactory.FreezeSpecificationManager(this);
        }
    }
}
