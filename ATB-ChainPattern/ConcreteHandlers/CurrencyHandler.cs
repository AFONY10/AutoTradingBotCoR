using ATB_ChainPattern.BaseHandlers;
using ATB_ChainPattern.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATB_ChainPattern.ConcreteHandlers
{
    // Base class for handling currency-related products
    public class CurrencyHandler : ProductHandlerBase
    {
        // Common functionality for handling currency-related products
        // This could include methods or properties specific to currencies

        protected override bool CanAnalyzeProduct(string productName, string productType)
        {
            if (productType == "OtherCurrency" || productType == "Crypto" || productType == "Forex")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void Analyze(string productName, string productType)
        {

            Console.WriteLine("CurrencyHandler: Analyzing " + productName + "...");
            Thread.Sleep(3000);

            if (productType == "Crypto")
            {
                Console.WriteLine("Your product is of type Crypto currency! Let me redirect you to our Crypto specialist");
                Thread.Sleep(3000);

                IProductHandler handler = GetSuccessor(ProductType.Crypto);
                SetSuccessor(handler);
                successor.AnalyzeProduct(productName, productType);


            }
            else if (productType == "Forex")
            {
                Console.WriteLine("Your product is of type Forex currency! Let me redirect you to our Forex specialist");
                Thread.Sleep(3000);

                IProductHandler handler = GetSuccessor(ProductType.Forex);
                SetSuccessor(handler);
                successor.AnalyzeProduct(productName, productType);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your product:" + productName + " is NOT worth buying!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Try look for the popular currencies");


            }
        }

        private IProductHandler GetSuccessor(ProductType productType)
        {
            // Determine the appropriate handler based on the product type
            switch (productType)
            {
                case ProductType.Crypto:
                    return new CryptoHandler();
                case ProductType.Forex:
                    return new ForexHandler(); 
                default:
                    throw new ArgumentException("I can't redirect you further, try again");
            }
        }

    }
}
