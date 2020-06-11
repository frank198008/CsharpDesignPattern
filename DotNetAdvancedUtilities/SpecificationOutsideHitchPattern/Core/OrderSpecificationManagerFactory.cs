using DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedUtilities.SpecificationOutsideHitchPattern.Core
{
    public class OrderSpecificationManagerFactory
    {
        public const string SpecificationFileName = "OrderSubmitSpec.xml";
        public static OrderSpecificationManager CreateNewOrderSpecificationManager()
        {
            OrderSpecificationManager specManager = new OrderSpecificationManager();
            specManager.Specification = new Dictionary<Data.CustomerType, OrderSpecificationIndex>();
            SubmitOrderSpecification submitOrderSpec = new SubmitOrderSpecification();
            specManager.Specification.Add(CustomerType.Normal,submitOrderSpec.CheckSubmitNormalOrder);
            specManager.Specification.Add(CustomerType.Vip, submitOrderSpec.CheckSubmitVipOrder);
            return specManager;
        }

        public static void FreezeSpecificationManager(OrderSpecificationManager specManager)
        {
            using(Stream stream = File.Open(SpecificationFileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, specManager);
            }
        }

        public static OrderSpecificationManager RebuildOrderSpecificationManager()
        {
            using(Stream stream = File.Open(SpecificationFileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var specManager = formatter.Deserialize(stream) as OrderSpecificationManager;
                return specManager;
            }
        }
    }
}
