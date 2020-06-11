using DotNetAdvancedUtilities.PassivationPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PassivationPattern.Core
{
    //这是此设计模式中最为经典的设计，就是参数和处理模式贯穿处理流最为重要的格式。
    public delegate bool OrderExamineApproveManagerHandler(Order order,ref OrderExamineApproveManagerHandler manager);
}
