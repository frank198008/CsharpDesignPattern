using DotNetAdvancedUtilities.PassivationPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PassivationPattern.Core
{

    //要实现持久化，需要添加序列化特性
    [Serializable]
    public class Informationer
    {
        public bool CheckPrices(Order order,ref OrderExamineApproveManagerHandler handler)
        {
            if (order.Items.Any(i => i.Product.Price <= 0)?false:true)//三元运算来取代取反，是语法更通顺
            {
                handler -= this.CheckPrices;//完成检查后取消绑定
                Console.WriteLine("Informationer have checked price");
                return true;
            }
            return false;
        }

        public bool CheckNumber(Order order,ref OrderExamineApproveManagerHandler handler)
        {
            if (order.Items.Any(i => i.Number > 0) ? false : true)
            {
                handler -= this.CheckNumber;
                Console.WriteLine("Informationer have checked number");
                return true;
            }
            return false;
        }
    }
}
