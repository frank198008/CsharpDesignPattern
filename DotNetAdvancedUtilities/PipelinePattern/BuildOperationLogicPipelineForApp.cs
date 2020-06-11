using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.PipelinePattern
{
    public class BuildOperationLogicPipelineForApp : IBuildOperationLogicPipelineObject
    {
        public OperationLogicPipelineObject BuildOperationPipeline(Request4Pipe request)
        {
            var pipeline = new OperationLogicPipelineObject();
            pipeline.Add(requestObj => {
                //对request进行操作，记录App请求Log的方法
            });

            pipeline.Add(requestObj => {
                //对request进行操作，执行App请求的方法
            });

            return pipeline;
        }
    }
}
