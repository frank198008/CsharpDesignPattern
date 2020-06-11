using DotNetAdvancedUtilities.LanguageComponentPattern.Data;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DotNetAdvancedUtilities.LanguageComponentPattern.Core
{
    public class LanguageComponentManagerFactory
    {
        public const string LanguageFileName = "language.xml";

        public LanguageComponentManager CreateNewOrderLanguageComponent(Order order)
        {
            LanguageComponentManager manager = new LanguageComponentManager() { Parameter=order};
            var sendEmail = new SendEmailOrderItemConfirmComponent();
            var forLanguage = new ForLanguageComponent<Order>(sendEmail, null);
            var ifelseLanguage = new IfLanguageComponent<Order>(forLanguage, null);
            ifelseLanguage.SetIfExpression(ord => order.Customer.CustomerType == CustomerType.Vip, order);
            manager.TrackMark += ifelseLanguage.Run;
            manager.TrackMark += forLanguage.Run;
            manager.TrackMark += sendEmail.Run;

            manager.FirstLanguage = ifelseLanguage;

            return manager;
        }


        public static void FreeLanguageComponentObject(LanguageComponentManager languageComponentManager)
        {
            using(Stream stream = File.Open(LanguageFileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, languageComponentManager);
            }
        }

        public static LanguageComponentManager ReBuildLanguageComponent()
        {
            using (Stream stream = File.Open(LanguageFileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream) as LanguageComponentManager;
            }
        }
    }
}