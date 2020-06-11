using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    public delegate void ServicePipelineObjectModules(Request4Pipe request);
    public class ServicePipelineObject
    {
        private ServicePipelineObjectModules modules;

        public void AddModule(ServicePipelineObjectModules module)
        {
            modules += module;
        }

        public void RunPipeline(Request4Pipe request)
        {
            modules(request);
        }
    }
}
