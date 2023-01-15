namespace HealthHub.Shared;

public class Client
{
    public Guid ID { get; set; }
    public Guid ClientId { get; set; }
    public string FirstName { get; set; }
    public string? SecondName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string IDNumber { get; set; }
}
