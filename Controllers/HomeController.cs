using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        /*public IActionResult Get()
        {
            return View();
            
        }
        */
        public IActionResult Index(int? id)
        {
            var movies = ProductRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            ProductCategoryModel model = new ProductCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Movies = movies;


            //hem kategori hem movie göndermek lazım
            return View(model);
        }
        public IActionResult Details(int id)
        {
            ProductCategoryModel modell = new ProductCategoryModel();
            modell.Movie = ProductRepository.GetById(id);
            modell.Categories = CategoryRepository.Categories;
            modell.Movies = ProductRepository.Movies;

            return View(modell);
        }
        public IActionResult Contact()
        {
            return View();
            
        }

    }
}