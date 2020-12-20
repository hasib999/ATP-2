﻿using Code_First_With_Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Code_First_With_Repository_Pattern.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public List<Product> GetTopProducts(int top)
        {
            return this.GetAll().OrderByDescending(x => x.Price).Take(top).ToList();
        }
    }
}