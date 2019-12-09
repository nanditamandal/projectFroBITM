﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;
using CompileError.DatabaseContext.DatabaseContext;

namespace CompileError.Repository.Repository
{
    public class ProductRepository
    {
        ProjectDbContext _projectDbContext = new ProjectDbContext();
        public List<Product> GetAll()
        {

            return _projectDbContext.Products.ToList();


        }
    }
}
