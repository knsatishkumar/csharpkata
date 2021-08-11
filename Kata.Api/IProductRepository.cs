using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.Api
{
    public interface IProductRepository 
    {
        Product GetById(int id);
        void Add(Product product);
        void Delete(int id);
    }
}
