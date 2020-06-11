using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    public class Request4Pipe
    {
        public StringBuilder Head { get; set; }
        public RequestClientType ClientType { get; set; }
        public RequestContent ClientContent { get; set; }
    }
}
