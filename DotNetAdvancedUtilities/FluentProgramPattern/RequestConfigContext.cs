using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.FluentProgramPattern
{
    public class RequestConfigContext
    {
        public static RequestConfigContext configContext = new RequestConfigContext();
        public string Formal { get; set; }
        public int Size { get; set; }
        public RequestProtocol Protocol { get; set; }
        public Func<RequestContext,bool> SafetyChecks { get; set; }
    }
}
