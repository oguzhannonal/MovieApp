using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class ProductCategoryModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public Movie Movie { get; set; }

    }
}
