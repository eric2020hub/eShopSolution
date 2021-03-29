using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageViewModel
    {
        public int Id { set; get; }

        public int ProductId { get; set; }
        public string ImagePath { set; get; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }

        //public IFormFile ImageFile { get; set; }
    }
}
