using System;
namespace DotNetAdvancedUtilities.LanguageComponentPattern.Data
{
    [Serializable]
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Number { get; set; }
    }
}