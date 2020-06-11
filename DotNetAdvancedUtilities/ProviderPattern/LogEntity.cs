using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ProviderPattern
{
    public class LogEntity
    {
        public LogType Type{get;set;}
        public LogLevel Level{ get; set;}
        public LogContent Content { get; set; }
    }
}
