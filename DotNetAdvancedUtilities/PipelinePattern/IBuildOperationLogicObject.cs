using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    /// <summary>
    /// 通过此接口来实现管道对象创建与管道对象运行方法的分离
    /// </summary>
    interface IBuildOperationLogicPipelineObject
    {
        OperationLogicPipelineObject BuildOperationPipeline(Request4Pipe request);
    }
}
