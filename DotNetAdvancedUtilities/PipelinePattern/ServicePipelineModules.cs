using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    public class ServicePipelineModules
    {
        public static void RestoreReduce(Request4Pipe request)
        {
            ReduceRequestBody.Restore(request);
        }

        public static void RestoreTransfer(Request4Pipe request)
        {
            request.ClientContent.Content = TransferRequestForRest.RestoreTransfer(request.ClientContent.Content);
        }

        public static void AnalyseHead(Request4Pipe request)
        {
            if (request.Head != null)
            {
                if (request.Head.ToString().IndexOf("SOA") != -1)
                {
                    //对消息进行SOA处理
                }
            }
        }

        public static void Route(Request4Pipe request)
        {
            //对消息进行路由
        }

    }
}
