using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int id { set; get; }
        public string FilePath { set; get; }
        public bool IsDefault { get; set; }
        public long FileSize { get; set; }
    }
}
