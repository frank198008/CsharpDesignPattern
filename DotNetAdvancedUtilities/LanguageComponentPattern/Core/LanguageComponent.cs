using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.LanguageComponentPattern.Core
{
    [Serializable]
    public abstract class LanguageComponent
    {
        public virtual void Run(LanguageComponentManager trackMark) { }
        public virtual void Run(object parameter,LanguageComponentManager trackMark) { }
    }
}
