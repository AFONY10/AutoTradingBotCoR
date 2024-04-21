using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATB_ChainPattern.BaseHandlers;
using ATB_ChainPattern.DummyData;


namespace ATB_ChainPattern.ConcreteHandlers
{
    public class CommodityHandler : ProductHandlerBase
    {
        protected override bool CanAnalyzeProduct(string productName, string productType)
        {

            // Check if the product type is "Commodity" and the product name exists in the ProductData
            return productType == "Commodity" && Enum.TryParse(productName, true, out ProductName productNameEnum) &&
                   ProductData.ProductTypeMap.ContainsKey(productNameEnum);
        }
        protected override void Analyze(string productName, string productType)
        {
            if (productName == "Gold")
            {
                Console.WriteLine("CommodityHandler: Analyzing Gold...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: Gold is worth buying.");
                Console.ResetColor();
                return;
            }
            
            if (productName == "Silver")
            {
                Console.WriteLine("CommodityHandler: Analyzing Silver...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Silver is NOT worth buying.");
                Console.ResetColor();
                return;
            }
            
            if (productName == "Oil")
            {
                Console.WriteLine("CommodityHandler: Analyzing Oil...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: Oil is worth buying.");
                Console.ResetColor();
                return;
            }
            
            if (productName == "Bronze")
            {
                Console.WriteLine("CommodityHandler: Analyzing Bronze...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Bronze is not worth buying.");
                Console.ResetColor();
                return;
            }


        }
    }
}
