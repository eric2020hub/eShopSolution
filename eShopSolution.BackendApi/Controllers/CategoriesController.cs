using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;
        public CategoriesController(ICategoryService CategoryService)
        {
            //_publicProductService = publicProductService;
            _CategoryService = CategoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging(string languageId)
        {
            var products = await _CategoryService.GetAll(languageId);
            return Ok(products);
        }
    }
}