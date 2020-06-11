using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ProviderPattern
{
    public class LogEntityFactory
    {
        public static LogEntity CreateLogEntity(string message,string type,string level)
        {
            LogEntity logEntity = new LogEntity();
            logEntity.Type = new LogType(type);
            logEntity.Level = new LogLevel(level);
            return logEntity;
        }
    }
}
