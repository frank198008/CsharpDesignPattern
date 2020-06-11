using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ContextPattern
{
    public class ServiceContextManager
    {
        public SoaServiceCallContext CurrentContext
        {
            get
            {
                return SoaServiceCallContext.context;
            }
        }

        protected void ApperceiveContextProperties(Request request)
        {
            if (SoaServiceCallContext.context != null)
            {
                //new Guid().toString() = 00000000-0000-0000-0000-000000000000
                string info = string.Empty;
                if (CurrentContext.LogTrack)
                {
                    request.LogTrackId =  Guid.NewGuid();
                    CurrentContext.BeginRecordLogTrack(new LogTrackLocation() { Location = request.LogTrackId.ToString() });
                }else
                {
                    request.LogTrackId = new Guid();
                }
                if (CurrentContext.Transaction)
                {
                    request.TransactionId = Guid.NewGuid();
                } else
                {
                    request.TransactionId = new Guid();
                }
                info += request.LogTrackId;
                info += request.TransactionId;
                CurrentContext.TransactionEnd(new TransactionActionInfo() { Info = info });
            }
        }

    }
}
