using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
        [ApiController]
        public class CategoriesController : ControllerBase
        {
            private ICategoryService _categoryService;

            public CategoriesController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
            var result = _categoryService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
        }
    
}
