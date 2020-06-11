using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ContextPattern
{
    public class Request
    {
        public Guid LogTrackId { get; set; }
        public Guid TransactionId { get; set; }
    }
}
