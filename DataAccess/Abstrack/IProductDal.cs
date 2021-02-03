using System;
using System.Collections.Generic;
using DataAccess.Abstrack;
using Entities;

namespace DataAccess
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
