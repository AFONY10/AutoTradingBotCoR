using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ATB_ChainPattern.DummyData
{
    public class ProductData
    {
        // Dictionary to map each product name to its associated product types
        public static Dictionary<ProductName, List<ProductType>> ProductTypeMap = new Dictionary<ProductName, List<ProductType>>
        {
            { ProductName.TeslaStock, new List<ProductType> { ProductType.Stock } },
            { ProductName.AppleStock, new List<ProductType> { ProductType.Stock } },
            { ProductName.MicrosoftStock, new List<ProductType> { ProductType.Stock } },
            { ProductName.GoogleStock, new List<ProductType> { ProductType.Stock } },
            { ProductName.Gold, new List<ProductType> { ProductType.Commodity } },
            { ProductName.Silver, new List<ProductType> { ProductType.Commodity } },
            { ProductName.Bronze, new List<ProductType> { ProductType.Commodity } },
            { ProductName.Oil, new List<ProductType> { ProductType.Commodity } },
            { ProductName.USD, new List<ProductType> { ProductType.Forex } },
            { ProductName.EUR, new List<ProductType> { ProductType.Forex } },
            { ProductName.GBP, new List<ProductType> { ProductType.Forex } },
            { ProductName.JPY, new List<ProductType> { ProductType.Forex } },
            { ProductName.CAD, new List<ProductType> { ProductType.Forex } },
            { ProductName.DKK, new List<ProductType> { ProductType.Forex } },
            { ProductName.Bitcoin, new List<ProductType> { ProductType.Crypto } },
            { ProductName.Ethereum, new List<ProductType> { ProductType.Crypto } },
            { ProductName.Ripple, new List<ProductType> { ProductType.Crypto } },
            { ProductName.Starknet, new List<ProductType> { ProductType.Crypto } },
            { ProductName.SonicRings, new List<ProductType> { ProductType.OtherCurrency } },
            { ProductName.EurodollarCP, new List<ProductType> { ProductType.OtherCurrency } },
            { ProductName.MarioCoins, new List<ProductType> { ProductType.OtherCurrency } }
        };

        // Dictionary to map each product type to its associated product names
        public static Dictionary<ProductType, List<ProductName>> ProductNameMap = new Dictionary<ProductType, List<ProductName>>
        {
            { ProductType.Stock, new List<ProductName> { ProductName.TeslaStock, ProductName.AppleStock, ProductName.MicrosoftStock, ProductName.GoogleStock } },
            { ProductType.Commodity, new List<ProductName> { ProductName.Gold, ProductName.Silver, ProductName.Bronze, ProductName.Oil } },
            { ProductType.Forex, new List<ProductName> { ProductName.USD, ProductName.EUR, ProductName.GBP, ProductName.JPY, ProductName.CAD, ProductName.DKK } },
            { ProductType.Crypto, new List<ProductName> { ProductName.Bitcoin, ProductName.Ethereum, ProductName.Ripple, ProductName.Starknet } },
            { ProductType.OtherCurrency, new List<ProductName> { ProductName.SonicRings, ProductName.EurodollarCP, ProductName.MarioCoins } },
            { ProductType.Currency, new List<ProductName> { ProductName.USD, ProductName.EUR, ProductName.GBP, ProductName.JPY, ProductName.CAD, ProductName.DKK,
                                                            ProductName.Bitcoin, ProductName.Ethereum, ProductName.Ripple, ProductName.Starknet,
                                                            ProductName.SonicRings, ProductName.EurodollarCP, ProductName.MarioCoins }}
            
        };

        // Method to get all product names associated with a given product type
        public static List<ProductName> GetProductsByType(ProductType type)
        {
            if (ProductNameMap.ContainsKey(type))
            {
                return ProductNameMap[type];
            }
            return new List<ProductName>();
        }

    }

    // Enum to represent the different product types
    public enum ProductType
    {
        [EnumMember(Value = "Forex")]
        Forex,
        [EnumMember(Value = "Commodity")]
        Commodity,
        [EnumMember(Value = "Stock")]
        Stock,
        [EnumMember(Value = "Crypto")]
        Crypto,
        [EnumMember(Value = "OtherCurrency")]
        OtherCurrency,
        [EnumMember(Value = "Currency")]
        Currency
    }

    // Enum to represent the different product names
    public enum ProductName
    {
        // Stocks
        [EnumMember(Value = "TeslaStock")]
        TeslaStock,
        [EnumMember(Value = "AppleStock")]
        AppleStock,
        [EnumMember(Value = "MicrosoftStock")]
        MicrosoftStock,
        [EnumMember(Value = "GoogleStock")]
        GoogleStock,

        // Commodities
        [EnumMember(Value = "Gold")]
        Gold,
        [EnumMember(Value = "Silver")]
        Silver,
        [EnumMember(Value = "Bronze")]
        Bronze,
        [EnumMember(Value = "Oil")]
        Oil,

        // Forex
        [EnumMember(Value = "USD")]
        USD,
        [EnumMember(Value = "EUR")]
        EUR,
        [EnumMember(Value = "GBP")]
        GBP,
        [EnumMember(Value = "JPY")]
        JPY,
        [EnumMember(Value = "CAD")]
        CAD,
        [EnumMember(Value = "DKK")]
        DKK, // Not worth buying

        // Crypto
        [EnumMember(Value = "Bitcoin")]
        Bitcoin, // Worth buying
        [EnumMember(Value = "Ethereum")]
        Ethereum, // Worth buying
        [EnumMember(Value = "Ripple")]
        Ripple, // Not worth buying
        [EnumMember(Value = "Starknet")]
        Starknet, // Not worth buying

        // OtherCurrency
        [EnumMember(Value = "MarioCoins")]
        MarioCoins,
        [EnumMember(Value = "SonicRings")]
        SonicRings,
        [EnumMember(Value = "EurodollarCP")]
        EurodollarCP

    }
}