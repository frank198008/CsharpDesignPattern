using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.LanguageComponentPattern.Core
{
    public class IfLanguageComponent<TParameter>:LanguageComponent where TParameter:class,new()
    {
        public LanguageComponent If { get; set; }
        public LanguageComponent Else { get; set; }
        public TParameter Parameter { get; set; }
        public Func<TParameter,bool> Expression { get; private set; }
        public IfLanguageComponent(LanguageComponent ifLanguage,LanguageComponent elseLanguage)
        {
            this.If = ifLanguage;
            this.Else = elseLanguage;
        }

        public void SetIfExpression(Func<TParameter,bool> expression,TParameter parameter)
        {
            this.Expression = expression;
            this.Parameter = parameter;
        }

        public override void Run(object parameter, LanguageComponentManager trackMark)
        {
            trackMark.Index = 0;
            if(this.Expression(parameter as TParameter))
            {
                this.If.Run(parameter, trackMark);
            }else if(Else!=null)
            {
                this.Else.Run(parameter, trackMark);
            }
        }

        public override void Run(LanguageComponentManager trackMark)
        {
            this.Run(this.Parameter, trackMark);
        }

    }
}
