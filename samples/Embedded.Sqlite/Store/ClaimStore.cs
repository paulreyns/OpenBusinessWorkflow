using Embedded.Models;

public class ClaimStore
{
    private static readonly List<Claim> _claims = new List<Claim>();
    
    public List<Claim> List()
    {
        if (_claims.Count == 0) {
            _claims.Add(new Claim());
        }

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