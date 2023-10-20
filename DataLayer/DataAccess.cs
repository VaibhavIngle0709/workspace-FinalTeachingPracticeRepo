using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List<Movie> movies=new List<Movie>()
    {
        new Movie{Id=1,Name="Toofan",Ryear=2021,Ratings=3},
        new Movie{Id=2,Name="Ludo",Ryear=2021,Ratings=3},
        new Movie{Id=3,Name="Gunjan",Ryear=2021,Ratings=3},
        new Movie{Id=4,Name="Jawan",Ryear=2021,Ratings=3},
        new Movie{Id=5,Name="Pathan",Ryear=2021,Ratings=3},
    };

    public List<Movie> GetMovies()
    {
        return movies;
    }
}
