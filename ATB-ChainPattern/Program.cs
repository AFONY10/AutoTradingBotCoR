using System;
using ATB_ChainPattern.BaseHandlers;
using ATB_ChainPattern.ConcreteHandlers;
using ATB_ChainPattern.DummyData;

namespace ATB_ChainPattern
{
    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATB Chain Pattern!");
            Console.WriteLine();
            Console.WriteLine("Press 1 if you have a product you want analyzed, " +
                              "Press 2 to view products of a specified type, " +
                              "or Press 3 to exit");
            string response;
            do
            {
                response = Console.ReadLine();

                switch (response)
                {
                    // Case 1: Analyze a product (This case demonstrates CoR)
                    case "1":
                        Console.WriteLine("Enter product name to analyze (TeslaStock, Bitcoin, Oil):");
                        string productName = Console.ReadLine();

                        Console.WriteLine("Enter product type (Forex, Commodity, Stock, Crypto, OtherCurrency):");
                        string productType = Console.ReadLine();

                        // Redirect to the appropriate handler based on the product name and type
                        DistributeHandler handler = new DistributeHandler();
                        handler.AnalyzeProduct(productName, productType);
                        break;

                    // Case 2: View products of a specified type before analyzing
                    case "2":
                        Console.WriteLine("Enter product type (Forex, Commodity, Stock, Crypto, Currency):");
                        string chosenType = Console.ReadLine();

                        ProductType selectedType;
                        if (Enum.TryParse(chosenType, true, out selectedType))
                        {
                            List<ProductName> productNames = ProductData.GetProductsByType(selectedType);
                            if (productNames.Count > 0)
                            {
                                Console.WriteLine($"Products of type {chosenType}:");
                                foreach (var name in productNames)
                                {
                                    // Retrieve the actual type associated with the product name
                                    List<ProductType> types = ProductData.ProductTypeMap[name];
                                    Console.WriteLine($"{name} ({string.Join(", ", types)})");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No products found for the specified type.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid product type. Please try again.");
                        }
                        break;

                    // Case 3: Exit the program
                    case "3":
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid response. Please try again.");
                        break;
                }

                if (response != "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press 1 to analyze another product, Press 2 to view products of another type, or Press 3 to exit");
                }
            } while (response != "3");
        }
    }
}
