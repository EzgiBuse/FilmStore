public class Film
{
    public int FilmId { get; set; }
    public string FilmName { get; set; }
    public int FilmYear { get; set; }
    public string FilmType { get; set; }
    public decimal Price { get; set; }

    // Relationships
    public ICollection<Actor> Actors { get; set; }
    public Director Director { get; set; }
}

