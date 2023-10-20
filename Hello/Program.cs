// See https://aka.ms/new-console-template for more information
using Entity;
using BzLayer;
MovieBz mz=new MovieBz();
List<Movie> movies=mz.GetMovies();
if(movies!=null)
{
    foreach(var m in movies)
    {
        Console.WriteLine($"ID: {m.Id} Name: {m.Name} Ratings: {m.Ratings} Year: {m.Ryear}");
    }
}
    else
    {
        Console.WriteLine("No Movies Present");
    }
