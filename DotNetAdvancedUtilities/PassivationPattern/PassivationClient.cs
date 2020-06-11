using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAdvancedUtilities.PassivationPattern.Data;
using DotNetAdvancedUtilities.PassivationPattern.Core;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DotNetAdvancedUtilities.PassivationPattern
{
    public class PassivationClient
    {
        //持久化只是将代码保存成文件，并不是真正的xml文件。
        public const string PersistXMLFile = "orderCheck.xml";
        #region 在location A 进行处理流程的持久化
        public void PersistFlow()
        {
            OrderExamineApproveFlowManager flowManager = OrderExamineApproveFlowManager.CreateFlows();
            //通过持久化实现了初始化和运行的分离
            using (Stream stream = File.Open(PersistXMLFile, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, flowManager);
            }
        }
        #endregion

        #region 在Location B 进行处理流程的反序列化
        private OrderExamineApproveFlowManager DeserializeFlow()
        {
            OrderExamineApproveFlowManager flowManger = null;
            if (File.Exists(PersistXMLFile))
            {
                using (Stream stream = File.Open(PersistXMLFile, FileMode.Open))
                {

                    BinaryFormatter formatter = new BinaryFormatter();
                    flowManger = formatter.Deserialize(stream) as OrderExamineApproveFlowManager;
                }
            }
            return flowManger;
        }
        private Order InitOrder()
        {
            Order order = new Order()
            {
                Items = new List<OrderItem>(),
                Customer = new CustomerInfo() { Email = "jack@work.com", Name = "jack", Phone = "13756342345" }
            };
            order.Items.Add(new OrderItem() { Number = 10, Product = new Product() { Name = "鼠标", Price = 100 } });
            order.Items.Add(new OrderItem() { Number = 1, Product = new Product() { Name = "笔记本", Price = 25 } });
            return order;
        }

        public void ExecuteFlow()
        {
            OrderExamineApproveFlowManager flow = DeserializeFlow();
            if (flow != null)
            {
                flow.RunFlows(InitOrder());
            }
        }
        #endregion

    }
}
