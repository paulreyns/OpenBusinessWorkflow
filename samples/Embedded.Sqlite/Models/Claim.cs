using OpenBusinessWorkflow.Core.Model;

namespace Embedded.Sqlite.Models 
{
    public class Claim : WorkflowEntity
    {
        public Claim() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}