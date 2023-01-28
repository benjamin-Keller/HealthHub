namespace HealthHub.Server.Data;

public partial class DataStore
{
    private readonly ApplicationDbContext _context;

    public DataStore(ApplicationDbContext context)
    {
        _context = context;
    }
}
