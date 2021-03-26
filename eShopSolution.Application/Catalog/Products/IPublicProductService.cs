﻿using eShopSolution.ViewModels.Catalog.Products;
//using eShopSolution.ViewModels.Catalog.Products.Public;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategory(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
