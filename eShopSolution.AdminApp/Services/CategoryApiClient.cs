using eShopSolution.ViewModels.Catalog.Categories;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, configuration, httpContextAccessor)
        {
            //_httpClientFactory = httpClientFactory;
            //_configuration = configuration;
            //_httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            return await GetsListAsync<CategoryVm>("/api/categories?languageId=" + languageId);
        }
    }
}
