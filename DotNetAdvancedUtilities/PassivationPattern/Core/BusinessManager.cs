using DotNetAdvancedUtilities.PassivationPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PassivationPattern.Core
{
    [Serializable]
    public class BusinessManager
    {
        public bool CallPhoneConfirm(Order order,ref OrderExamineApproveManagerHandler handler)
        {
            if (Regex.IsMatch(order.Customer.Phone, @"^(130|131|132|133|134|135|136|137|138|139)\d{8}$"))
            {
                handler -= this.CallPhoneConfirm;
                Console.WriteLine("Business Manager have confirm call");
                return true;
            }
            return false;
        }

        public bool SendEmailNotice(Order order, ref OrderExamineApproveManagerHandler handler)
        {
            if (Regex.IsMatch(order.Customer.Email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                handler -= this.SendEmailNotice;
                Console.WriteLine("Business Manager have confirm call");
                return true;
            }
            return false;
        }


    }
}
