using FristExersiceZhenic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FristExersiceZhenic.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                id = 1,
                Name = "آیفون 13",
                Category = "اپل",
                Description = "13 عالیه ولی گرونه ",
                Price = 80
            }, new Product
            {
                id = 2,
                Name = "آیفون 14",
                Category = "اپل",
                Description = "عالیه ولی گرونه 14 ",
                Price = 90
            }, new Product
            {
                id = 3,
                Name = "آیفون 15",
                Category = "اپل",
                Description = "عالیه ولی گرونه 15 ",
                Price = 100
            }, new Product
            {
                id = 4,
                Name = "گلکسی a56",
                Category = "سامسونگ",
                Description = "ارزونه ولی عالی نیست ",
                Price = 38
            }, new Product
            {
                id = 5,
                Name = "گلکسی s24 fe",
                Category = "سامسونگ",
                Description = "عالیه گرونم نیست ",
                Price = 48
            }, new Product
            {
                id = 6,
                Name = "گلکسی s25 اولترا",
                Category = "سامسونگه",
                Description = "عالیه ولی گرونه خیلیم گرونه ",
                Price = 150
            }, new Product
            {
                id = 7,
                Name = "شیائومی 15 الترا",
                Category = "شیائومی",
                Description = "ادای عالی هارو در میاره... نه ارزونه  نه گرون  ",
                Price = 70
            }
                );
        }
    }
}


