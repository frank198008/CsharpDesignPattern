using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Core
{
    [Serializable]
    public class SubmitOrderSpecification
    {
        public bool CheckSubmitVipOrder(Order order)
        {
            if (order.Customer.CustomerType == CustomerType.Vip)
            {
                return true;
            }
            return false;
        }

        public bool CheckSubmitNormalOrder(Order order)
        {
            if (order.Customer.CustomerType == CustomerType.Normal)
            {
                return true;
            }
            return false;
        }
    }
}
