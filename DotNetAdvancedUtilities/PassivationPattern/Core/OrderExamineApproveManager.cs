using DotNetAdvancedUtilities.PassivationPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PassivationPattern.Core
{
    [Serializable]
    public class OrderExamineApproveFlowManager
    {
        public OrderExamineApproveManagerHandler Flows;
        public static OrderExamineApproveFlowManager CreateFlows()
        {
            OrderExamineApproveFlowManager flowManager = new OrderExamineApproveFlowManager();

            Informationer informationer = new Informationer();
            flowManager.Flows += informationer.CheckPrices;
            flowManager.Flows += informationer.CheckNumber;
            BusinessManager businessManager = new BusinessManager();
            flowManager.Flows += businessManager.CallPhoneConfirm;
            flowManager.Flows += businessManager.SendEmailNotice;
            GeneralManager gm = new GeneralManager();
            flowManager.Flows += gm.FinalConfirm;
            flowManager.Flows += gm.SignAndRecord;

            return flowManager; 
        }

        public void RunFlows(Order order)
        {
            this.Flows(order,ref this.Flows);
        }
    }
}
