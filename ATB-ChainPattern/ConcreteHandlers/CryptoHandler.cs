using ATB_ChainPattern.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATB_ChainPattern.ConcreteHandlers
{
    // Concrete handler for handling cryptocurrency analysis
    class CryptoHandler : CurrencyHandler // Inheriting from CurrencyHandler, but could also inherit from ProductHandlerBase
    {
        protected override bool CanAnalyzeProduct(string productName, string productType)
        {
            // Check if the product type is "Crypto" and the product name exists in the ProductData
            return productType == "Crypto" && Enum.TryParse(productName, true, out ProductName productNameEnum) &&
                   ProductData.ProductTypeMap.ContainsKey(productNameEnum);
        }
        protected override void Analyze(string productName, string productType)
        {
            if (productName == "Bitcoin")
            {
                Console.WriteLine("CryptoHandler: Analyzing Bitcoin...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: Bitcoin is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "Ethereum")
            {
                Console.WriteLine("CryptoHandler: Analyzing Ethereum...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Result: Ethereum is worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "Starknet")
            {
                Console.WriteLine("CryptoHandler: Analyzing Starknet...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Starknet is NOT worth buying.");
                Console.ResetColor();
                return;
            }

            if (productName == "Ripple")
            {
                Console.WriteLine("CryptoHandler: Analyzing Ripple...");
                Thread.Sleep(3000);

                // Perform cryptocurrency analysis
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Ripple is NOT worth buying.");
                Console.ResetColor();
                return;
            }
        }
    }
}
