#define TEST1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAdvancedUtilities.ProviderPattern;
using DotNetAdvancedUtilities.FluentProgramPattern;
using DotNetAdvancedUtilities.ContextPattern;
using DotNetAdvancedUtilities.PipelinePattern;
using DotNetAdvancedUtilities.PassivationPattern;
using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern;

namespace DotNetAdvancedUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //ProviderPattern
            LogEntity logEntity =LogEntityFactory.CreateLogEntity("xxx", LogType.Exception, LogLevel.Warning);
            logEntity.Content.LogTrackInfo = "Program.Main";
            ILogSaveProvider saveProvider = new LogSaveLocalhostProvider();
            saveProvider.SaveLog(logEntity);

            //FluentPattern
            RequestConfigManager.Config
                .SetGlobalRequestSize(10)
                .SetGlobalRequestProtocol(new RequestProtocol(RequestProtocol.Soap))
                .SetGlobalRequestFormatJson()
                .SetGlobalRequestFormatBinary()
                .SetGlobalRequestSafty(requestContext => requestContext.Size < RequestConfigContext.configContext.Size);


            //PipelinePattern
            Request4Pipe request = new Request4Pipe() { Head = new StringBuilder(), ClientType = new RequestClientType() { type = RequestClientType.App }, ClientContent = new RequestContent() { Content = "" } };
            ClientPipelineObject client = new ClientPipelineObject();
            client.AddModule(ClientPipelineModules.CheckRequestContent);
            client.AddModule(ClientPipelineModules.AddRequestHead);
            client.AddModule(ClientPipelineModules.TransferRequestFormat);
            client.AddModule(ClientPipelineModules.ReduceRequest);
            client.RunPipeline(request);

            ServicePipelineObject service = new ServicePipelineObject();
            service.AddModule(ServicePipelineModules.RestoreReduce);
            service.AddModule(ServicePipelineModules.RestoreTransfer);
            service.AddModule(ServicePipelineModules.AnalyseHead);
            service.AddModule(ServicePipelineModules.Route);
            service.RunPipeline(request);

            IBuildOperationLogicPipelineObject pipelineObjBuilder = new BuildOperationLogicPipelineForApp();
            pipelineObjBuilder.BuildOperationPipeline(request).RunPipeline(request);
            pipelineObjBuilder = new BuildOperationLogicPipelineForClient();
            pipelineObjBuilder.BuildOperationPipeline(request).RunPipeline(request);
            */


            //ContextPattern
            //ServiceProxy proxy = new ServiceProxy();
            //using(SoaServiceCallContext context = new SoaServiceCallContext(true,true))
            //{
            //    context.BeginRecordLogTrackEvent += Context_BeginRecordLogTrackEvent;
            //    context.TransactionEndEvent += Context_TransactionEndEvent;
            //    proxy.SetTicketPrice("360", 21423);
            //    proxy.UpdateTicketCache("360", 21423);
            //}



            //PassvivationPattern
            //PassivationClient localClient = new PassivationClient();
            //localClient.PersistFlow();
            //Console.WriteLine("Persist flow finished");

            //PassivationClient remoteClient = new PassivationClient();
            //remoteClient.ExecuteFlow();
            //Console.WriteLine("Flow Execute");

            //SpecificationOutsideHitchPattern
            SpecificationOutsideHitchClient specOutsideHithClient = new SpecificationOutsideHitchClient();
            
            specOutsideHithClient.SubmitOrderByDefaultSpecManager();

            specOutsideHithClient.SubmitOrderByEditedSpecManager();

            Console.ReadKey();
        }

        private static void Context_TransactionEndEvent(TransactionActionInfo arg)
        {
            Console.WriteLine(arg.Info);
        }

        private static void Context_BeginRecordLogTrackEvent(LogTrackLocation arg)
        {
            Console.WriteLine(arg.Location);
        }
    }
    //使用扩展方法实现链式编程
    static class RequestConfigManagerEx
    {
        public static RequestConfigManager SetGlobalRequestFormatBinary(this RequestConfigManager configManager)
        {
            if (string.IsNullOrEmpty(RequestConfigContext.configContext.Formal))
                RequestConfigContext.configContext.Formal = "Binary";
            return configManager;
        }

        public static RequestConfigManager SetGlobalRequestSafty(this RequestConfigManager configManager,Func<RequestContext,bool> checkLogic)
        {
            RequestConfigContext.configContext.SafetyChecks = checkLogic;
            return configManager;
        }

        
    }
}
