using Entity;
using DataLayer;
namespace BzLayer;
public class MovieBz

{
 public List<Movie> GetMovies()
 {
    DataAccess d=new DataAccess();
    return d.GetMovies();
 }   
}
