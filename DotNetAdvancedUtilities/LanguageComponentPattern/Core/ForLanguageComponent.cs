using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.LanguageComponentPattern.Core
{
    public class ForLanguageComponent<TParameter>:LanguageComponent where TParameter:class,IList
    {
        public LanguageComponent ItemExpression { get; set; }
        private TParameter Parameter { get; set; }
        private int CurrentIndex { get; set; }
        public ForLanguageComponent(LanguageComponent itemExpression,TParameter parameter)
        {
            this.ItemExpression = itemExpression;
            this.Parameter = parameter;
        }

        public override void Run(object parameter, LanguageComponentManager trackMark)
        {
            trackMark.Index = 1;
            var Plist = (parameter as TParameter);
            for(int index = CurrentIndex; index < Plist.Count; index++)
            {
                this.CurrentIndex = index;
                if (ItemExpression != null)
                {
                    ItemExpression.Run(Plist[index], trackMark);
                }
            }
        }

        public override void Run(LanguageComponentManager trackMark)
        {
            this.Run(this.Parameter, trackMark);
        }

    }
}
