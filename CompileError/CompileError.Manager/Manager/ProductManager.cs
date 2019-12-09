using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;
using CompileError.Repository.Repository;

namespace CompileError.Manager.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        public List<Product> GetAll()
        {
            return _productRepository.GetAll();

        }
    }
}
