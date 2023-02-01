using AM.Business.Models;
using AM.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.DataServices
{
    public class BusinessEntityMappings :Profile
    {
        public BusinessEntityMappings()
        {

            CreateMap<ProductModel, Product>().ReverseMap();
        }
    }
}
