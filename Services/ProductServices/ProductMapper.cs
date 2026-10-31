using AutoMapper;
using IForce.WebFormsTest.Entities;

namespace IForce.WebFormsTest.Services.ProductServices
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductResponse>();
        }
    }
}
