﻿using System;
using System.Collections.Generic;
using Entities;

namespace Business.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
