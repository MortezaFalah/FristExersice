using FristExersiceZhenic.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FristExersiceZhenic.Controllers
{
    public class HomeController(IProductRepository productRepository) : Controller
    {
        private readonly int PageSize = 4;
        [Route("/")]
        [Route("/home/index/{page?}")]
        public IActionResult Index(int page = 1)
        {

            return View(productRepository.GetAll(page, PageSize));
        }
    }
}
