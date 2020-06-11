using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    /// <summary>
    /// 核心委托：需要添加的处理方法的签名
    /// </summary>
    /// <param name="request"></param>
    public delegate void ClientPipelineObjectModules(Request4Pipe request);

    /// <summary>
    /// 核心类：包含委托对象引用，添加处理方法逻辑，运行委托实例的逻辑，委托实例的运行会带动一系列挂载方法运行。
    /// </summary>
    public class ClientPipelineObject
    {
        private ClientPipelineObjectModules modules;

        public void AddModule(ClientPipelineObjectModules module)
        {
            modules += module;
        }

        public void RunPipeline(Request4Pipe request)
        {
            modules(request);
        }
    }
}
