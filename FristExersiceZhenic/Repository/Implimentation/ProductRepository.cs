using FristExersiceZhenic.Context;
using FristExersiceZhenic.Models;
using FristExersiceZhenic.Paging;
using FristExersiceZhenic.Repository.Interfaces;

namespace FristExersiceZhenic.Repository.Implimentation
{
    public class ProductRepository(MyZhenicDbContext _context) : IProductRepository
    {
        public PageData<Product> GetAll(int pagenumber, int pagesize)
        {
            var res = _context.Products.Skip((pagenumber - 1) * pagesize).Take(pagesize).ToList();

            PageData<Product> pro = new PageData<Product>()
            {
                PageInfo = new PageInfo
                {
                    PageNumber = pagenumber,
                    PageSize = pagesize,
                    TotalCount = _context.Products.Count()
                },
                Data = res
            };

            return pro;
        }
    }
}
