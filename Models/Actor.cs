public class Actor
{
    public int ActorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Relationships
    public ICollection<Film> Films { get; set; }
}

