using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ATB_ChainPattern.DummyData;

namespace ATB_ChainPattern.BaseHandlers
{
    // Base class for product handlers
    public abstract class ProductHandlerBase : IProductHandler
    {
        protected IProductHandler successor;

        public void SetSuccessor(IProductHandler successor)
        {
            this.successor = successor;
        }

        public virtual void AnalyzeProduct(string productName, string productType)
        {
            // If this handler can analyze the product, do the analysis
            if (CanAnalyzeProduct(productName, productType))
            {
                Analyze(productName, productType);
            }
            // If there is a next handler, pass the product to it
            else if (successor != null)
            {
                successor.AnalyzeProduct(productName, productType);
            }
            // No handler in the chain can analyze the product
            else
            {
                Console.WriteLine("Error: Product not supported.");
            }
        }

        protected abstract bool CanAnalyzeProduct(string productName, string productType);
        protected abstract void Analyze(string productName, string productType);

    }

}
