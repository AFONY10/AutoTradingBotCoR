using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATB_ChainPattern.DummyData;

namespace ATB_ChainPattern.BaseHandlers
{
    // Interface for product handlers
    public interface IProductHandler
    {
        void SetSuccessor(IProductHandler successor);
        void AnalyzeProduct(string productName, string productType);
    }
}
