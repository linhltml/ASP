using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lethimylinh_2122130036.Context;

namespace lethimylinh_2122130036.Models
{
    public class HomeModel
    {
        public List<Product> listProduct { get; set; }

        public List<Category> listCategory { get; set; }
    }
}