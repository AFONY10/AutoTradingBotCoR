using ATB_ChainPattern.BaseHandlers;
using ATB_ChainPattern.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATB_ChainPattern.ConcreteHandlers
{
    // Concrete handler for handling stock analysis
    class StockHandler : ProductHandlerBase
    {
        protected override bool CanAnalyzeProduct(string productName, string productType)
        {
            
            // Check if the product type is "Stock" and the product name exists in the ProductData
            return productType == "Stock" && Enum.TryParse(productName, true, out ProductName productNameEnum) &&
                   ProductData.ProductTypeMap.ContainsKey(productNameEnum);


        }
        protected override void Analyze(string productName, string productType)
        {
            if (productName == "TeslaStock")
            {
                Console.WriteLine("StockHandler: Analyzing TeslaStock...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: TeslaStock is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "AppleStock")
            {
                Console.WriteLine("StockHandler: Analyzing AppleStock...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: AppleStock is NOT worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "MicrosoftStock")
            {
                Console.WriteLine("StockHandler: Analyzing MicrosoftStock...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: MicrosoftStock is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "GoogleStock")
            {
                Console.WriteLine("StockHandler: Analyzing GoogleStock...");
                Thread.Sleep(3000);

                // Perform analysis and determine if worth buying
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: GoogleStock is NOT worth buying.");
                Console.ResetColor();
                return;
            }
        }
    }
}
