using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    public delegate void OperationLogicPipelineObjectModules(Request4Pipe request);
    public class OperationLogicPipelineObject
    {
        private OperationLogicPipelineObjectModules modules;

        public void Add(OperationLogicPipelineObjectModules module)
        {
            modules += module;
        }

        public void RunPipeline(Request4Pipe request)
        {
            modules(request);
        }
    }
}
