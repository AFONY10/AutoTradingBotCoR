using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATB_ChainPattern.DummyData;

namespace ATB_ChainPattern.ConcreteHandlers
{
    class ForexHandler : CurrencyHandler
    {
        protected override bool CanAnalyzeProduct(string productName, string productType)
        {
            // Check if the product type is "Forex" and the product name exists in the ProductData
            return productType == "Forex" && Enum.TryParse(productName, true, out ProductName productNameEnum) &&
                   ProductData.ProductTypeMap.ContainsKey(productNameEnum);
        }
        protected override void Analyze(string productName, string productType)
        {
            if (productName == "USD")
            {
                Console.WriteLine("ForexHandler: Analyzing USD...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: USD is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "EUR")
            {
                Console.WriteLine("ForexHandler: Analyzing EUR...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: EUR is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "GBP")
            {
                Console.WriteLine("ForexHandler: Analyzing GBP...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: GBP is NOT worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "JPY")
            {
                Console.WriteLine("ForexHandler: Analyzing JPY...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: JPY is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "CAD")
            {
                Console.WriteLine("ForexHandler: Analyzing CAD...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: CAD is NOT worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "DKK")
            {
                Console.WriteLine("ForexHandler: Analyzing DKK...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: DKK is NOT worth buying.");
                Console.ResetColor();
                return;
            }

        }
    }
}
