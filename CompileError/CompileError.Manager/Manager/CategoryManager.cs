using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;
using CompileError.Repository.Repository;

namespace CompileError.Manager.Manager
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();

        }
    }
}
