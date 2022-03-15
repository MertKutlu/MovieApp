using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{

    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {

            new Category() {Id=1,Name="Comedy"},
            new Category() {Id=2,Name="Horror"},
            new Category() {Id=3,Name="Action"},
            new Category() {Id=4,Name="Sci-fi"},
            new Category() {Id=5,Name="War"},

            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}