using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ContextPattern
{
    public delegate void SoaServiceCallContextHandler<T>(T arg);
    public class SoaServiceCallContext:IDisposable
    {
        internal static SoaServiceCallContext context;
        public bool LogTrack { get; private set; }
        public bool Transaction { get; private set; }
        public SoaServiceCallContext(bool logTrack,bool transaction)
        {
            this.LogTrack = logTrack;
            this.Transaction = transaction;
            SoaServiceCallContext.context = this;
        }

        private SoaServiceCallContextHandler<LogTrackLocation> beginRecordLogTrackHandler;
        public event SoaServiceCallContextHandler<LogTrackLocation> BeginRecordLogTrackEvent
        {
            add
            {
                beginRecordLogTrackHandler += value;
            }
            remove
            {
                if (beginRecordLogTrackHandler != null)
                {
                    beginRecordLogTrackHandler -= value;
                }
            }
        }

        private SoaServiceCallContextHandler<TransactionActionInfo> transactionEndHandler;
        public event SoaServiceCallContextHandler<TransactionActionInfo> TransactionEndEvent
        {
            add
            {
                this.transactionEndHandler += value;
            }
            remove
            {
                if (this.transactionEndHandler != null)
                {
                    this.transactionEndHandler -= value;
                }
            }
        }

        public void BeginRecordLogTrack(LogTrackLocation location)
        {
            if (beginRecordLogTrackHandler != null)
            {
                beginRecordLogTrackHandler(location);
            }
        }

        public void TransactionEnd(TransactionActionInfo info)
        {
            if (transactionEndHandler != null)
            {
                transactionEndHandler(info);
            }
        }


        public void Dispose()
        {
            this.transactionEndHandler = null;
            this.beginRecordLogTrackHandler = null;
        }
    }
}
