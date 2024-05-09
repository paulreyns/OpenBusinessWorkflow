using Embedded.Models;

public class ClaimStore
{
    private static readonly List<Claim> _claims = new List<Claim>()
    {
        // Example Claim for Demo purposes
        new Claim() { Name = "Test" }
    };
    
    public List<Claim> List()
    {
        return _claims;
    }

    public Claim Get(Guid id)
    {
        return _claims.FirstOrDefault(x => x.Id == id) ?? new Claim() { Id = Guid.Empty };
    }

    public void Set(Claim claim)
    {
        var existing = Get(claim.Id);
        if (existing == null) {
            _claims.Add(claim);
        }
        else
        {
             _claims.Remove(existing);
             _claims.Add(claim);
        }
    }
}