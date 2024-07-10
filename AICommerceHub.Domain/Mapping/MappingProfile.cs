using AICommerceHub.Domain.DTOs;
using AICommerceHub.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDTO, Order>();
            CreateMap<Order,OrderDTO>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

        }
    }
}
