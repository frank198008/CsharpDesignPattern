using DotNetAdvancedUtilities.PassivationPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PassivationPattern.Core
{
    [Serializable]
    public class GeneralManager
    {
        public bool FinalConfirm(Order order,ref OrderExamineApproveManagerHandler handler)
        {
            handler -= this.FinalConfirm;
            Console.WriteLine("GM FinalConfirm");
            return true;
        }



        public bool SignAndRecord(Order order,ref OrderExamineApproveManagerHandler handler)
        {
            //do SignAndRecord
            handler -= this.SignAndRecord;
            Console.WriteLine("GM signed and recorded");
            return true;
        }
    }
}
