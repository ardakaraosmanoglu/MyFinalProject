using System;
using System.Collections.Generic;
using Entities;

namespace Business.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
