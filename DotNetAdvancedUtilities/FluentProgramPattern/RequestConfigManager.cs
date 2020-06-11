using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.FluentProgramPattern
{
    /// <summary>
    /// 流式编程核心类
    /// </summary>
    public class RequestConfigManager
    {
        public static RequestConfigManager Config = new RequestConfigManager();

        public RequestConfigManager SetGlobalRequestFormatJson()
        {
            if (string.IsNullOrEmpty(RequestConfigContext.configContext.Formal))
                RequestConfigContext.configContext.Formal = "Json";
            return this;
        }

        public RequestConfigManager SetGlobalRequestFormatXml()
        {
            if (string.IsNullOrEmpty(RequestConfigContext.configContext.Formal))
                RequestConfigContext.configContext.Formal = "Xml";
            return this;
        }
        public RequestConfigManager SetGlobalRequestProtocol(RequestProtocol protocol)
        {
            RequestConfigContext.configContext.Protocol = protocol;
            return this;
        }

        public RequestConfigManager SetGlobalRequestSize(int size)
        {
            RequestConfigContext.configContext.Size = size;
            return this;
        }
    }
}
