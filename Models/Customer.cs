using System.IO;
using static System.Net.WebRequestMethods;

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Assuming a Film can have multiple customers
    public ICollection<Film> PurchasedFilms { get; set; }
    public string FavoriteGenres { get; set; }
}
