using System;
using System.Collections.Generic;
using Business.Abstrack;
using DataAccess;
using DataAccess.Concrete.InMemory;
using Entities;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // IsKodlari
            return _productDal.GetAll();

        }
    }
}
