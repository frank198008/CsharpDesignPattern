using System;
namespace DotNetAdvancedUtilities.LanguageComponentPattern.Data
{
    [Serializable]
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}