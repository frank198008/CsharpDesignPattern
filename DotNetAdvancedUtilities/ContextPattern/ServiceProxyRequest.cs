using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ContextPattern
{
    public class ServiceProxyRequest:Request
    {
        public string TicketId { get; set; }
        public int Price { get; set; }
    }
}
