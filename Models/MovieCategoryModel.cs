namespace MovieApp.Models
{
    public class MovieCategoryModel
    {
        public Movie_ Movie { get; set; }
        public IEnumerable<Movie_> Movies { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }

}