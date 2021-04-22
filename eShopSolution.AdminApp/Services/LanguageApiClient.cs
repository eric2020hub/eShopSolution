using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Languages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
        //private readonly IHttpClientFactory _httpClientFactory;
        //private readonly IConfiguration _configuration;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public LanguageApiClient(IHttpClientFactory httpClientFactory, 
            IConfiguration configuration, 
            IHttpContextAccessor httpContextAccessor) 
            : base(httpClientFactory, configuration, httpContextAccessor )
        {
            //_httpClientFactory = httpClientFactory;
            //_configuration = configuration;
            //_httpContextAccessor = httpContextAccessor;
        }
        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
        }
    }
}
