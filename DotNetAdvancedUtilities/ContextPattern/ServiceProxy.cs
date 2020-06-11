using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ContextPattern
{
    public class ServiceProxy:ServiceContextManager
    {
        public void SetTicketPrice(string ticketId,int price)
        {
            base.ApperceiveContextProperties(new ServiceProxyRequest() {TicketId=ticketId,Price=price });
        }

        public void UpdateTicketCache(string ticketId,int price)
        {
            base.ApperceiveContextProperties(new ServiceProxyRequest() { TicketId = ticketId, Price = price });
        }
    }
}
