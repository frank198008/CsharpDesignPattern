using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAdvancedUtilities.LanguageComponentPattern.Data;

namespace DotNetAdvancedUtilities.LanguageComponentPattern.Core
{
    public class SendEmailOrderItemConfirmComponent:LanguageComponent
    {
        public override void Run(object parameter, LanguageComponentManager trackMark)
        {
            if (parameter != null)
            {
                var OrderItem = parameter as OrderItem;
                Console.WriteLine("发送采购商品确定邮件：商品名称{0},数量{1}", OrderItem.Product.Name, OrderItem.Number);
            }
        }
    }
}
