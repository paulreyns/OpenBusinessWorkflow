namespace Embedded.Sqlite.Models 
{
    public class Claim 
    {
        public Claim() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}