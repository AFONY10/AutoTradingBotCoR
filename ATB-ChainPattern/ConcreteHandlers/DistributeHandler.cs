
using System;
using System.Collections.Generic;
using ATB_ChainPattern.DummyData;
using ATB_ChainPattern.BaseHandlers;
using ATB_ChainPattern.ConcreteHandlers;
using System.Threading;

namespace ATB_ChainPattern
{
    public class DistributeHandler : ProductHandlerBase
    {

        protected override bool CanAnalyzeProduct(string productName, string productType)
        {
            // DistributeHandler can always handle the analysis
            return true;
        }

        protected override void Analyze(string productName, string productType)
        {
            System.Console.WriteLine("Welcome to DistributeHandler! Let me analyze your request and pass you to the right handler...");
            Thread.Sleep(3000);
            // Validate the product name and type as enums
            if (!Enum.TryParse(productName, true, out ProductName parsedProductName) ||
                !Enum.TryParse(productType, true, out ProductType parsedProductType))
            {
                Console.WriteLine("Invalid product name or type. Request closed.");
                return;
            }

            // Validate the existence of the product name in the data dictionary
            if (!ProductData.ProductTypeMap.ContainsKey(parsedProductName))
            {
                Console.WriteLine("Invalid product name. Request closed.");
                return;
            }

            // Validate the product type for the given product name
            List<ProductType> validProductTypes = ProductData.ProductTypeMap[parsedProductName];
            if (!validProductTypes.Contains(parsedProductType))
            {
                Console.WriteLine("Invalid product type for the given product name. Request closed.");
                return;
            }

            // Determine the appropriate handler based on the product type
            IProductHandler handler = GetSuccessor(parsedProductType);

            // Set up the chain
            SetSuccessor(handler);

            // Pass the product name and type to the chain root for analysis
            successor.AnalyzeProduct(productName, productType);
        }

        private IProductHandler GetSuccessor(ProductType productType)
        {
            // Determine the appropriate handler based on the product type
            switch (productType)
            {
                case ProductType.Stock:
                    return new StockHandler();

                case ProductType.OtherCurrency: 
                case ProductType.Crypto:
                case ProductType.Forex:
                    return new CurrencyHandler(); 

                case ProductType.Commodity:
                    return new CommodityHandler(); 

                // Add cases for other product types as needed
                default:
                    throw new ArgumentException("Invalid product type, can't find handler.");
            }
        }
    }
}
