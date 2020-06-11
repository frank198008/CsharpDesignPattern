using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.ProviderPattern
{
    public class LogLevel
    {
        /// <summary>
        /// 警告
        /// </summary>
        public const string Warning = "Warning";

        /// <summary>
        /// 严重，需立即处理
        /// </summary>
        public const string Graveness = "Graveness";

        private string _level;
        
        public LogLevel(string level)
        {
            this._level = level;
        }
    }
}
