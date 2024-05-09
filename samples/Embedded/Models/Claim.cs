using OpenBusinessWorkflow.Core.Model;

namespace Embedded.Models 
{
    public class Claim : WorkflowEntity
    {
        public Claim() 
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}