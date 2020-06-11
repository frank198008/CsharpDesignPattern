using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    /// <summary>
    /// 辅助类:符合管道对象需要添加的处理方法委托对象签名的一列方法的组合体，如果不考虑复用完全可以使用你们匿名方法或lambda表达式替代。
    /// </summary>
    public class ClientPipelineModules
    {
        public static void CheckRequestContent(Request4Pipe request)
        {
            if (request == null || request.ClientContent == null || string.IsNullOrEmpty(request.ClientContent.Content))
            {
                throw new InvalidOperationException("无效请求");
            } 
        }

        public static void AddRequestHead(Request4Pipe request)
        {
            if (request.Head != null)
            {
                request.Head.Append("Request Source:SOA Client");
            }else
            {
                throw new NullReferenceException("Request.Head is Null");
            }
        }

        public static void TransferRequestFormat(Request4Pipe request)
        {
            request.ClientContent.Content = TransferRequestForRest.Transfer(request.ClientContent.Content);
        }

        public static void ReduceRequest(Request4Pipe request)
        {
            ReduceRequestBody.Reduce(request);
        }
    }
}
