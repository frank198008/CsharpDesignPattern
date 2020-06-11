using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    public class BuildOperationLogicPipelineForClient : IBuildOperationLogicPipelineObject
    {
        public OperationLogicPipelineObject BuildOperationPipeline(Request4Pipe request)
        {
            var pipeline = new OperationLogicPipelineObject();
            pipeline.Add(requestObj => {
                //对request进行处理，记录dotnet客户端请求Log
            });
            pipeline.Add(requestObj => {
                //对request进行处理，执行dotnet客户端请求
            });
            return pipeline;
        }
    }
}
