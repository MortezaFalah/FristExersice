using FristExersiceZhenic.Models;
using FristExersiceZhenic.Paging;

namespace FristExersiceZhenic.Repository.Interfaces
{
    public interface IProductRepository
    {
        PageData<Product> GetAll(int pagesize, int pagenumber);
    }
}
