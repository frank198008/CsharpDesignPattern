using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ProviderPattern
{
    public abstract class LogSaveBaseProvider : ILogSaveProvider
    {
        public bool SaveLog(LogEntity logEntity)
        {
            if (!this.IsSaveLogWithConfiguration(logEntity)) return false;
            if (!this.ValidatorLogEntity(logEntity)) return false;
            this.FormatLogContent(logEntity);
            return this.DoSaveLog(logEntity);
        }
        protected virtual bool IsSaveLogWithConfiguration(LogEntity logEntity)
        {
            string logType = ConfigurationManager.AppSettings["LogType"];
            if (logEntity.Type.Equals(logType))
            {
                return true;
            }else
            {
                return false;
            }
        }

        protected virtual bool ValidatorLogEntity(LogEntity logEntity)
        {
            if (logEntity == null || logEntity.Content == null)
            {
                return false;
            }else
            {
                return true;
            }
        }

        protected virtual void FormatLogContent(LogEntity logEntity)
        {
            //根据需求对要保存的内容进行格式化处理
        }

        protected abstract bool DoSaveLog(LogEntity logEntity);

    }
}
