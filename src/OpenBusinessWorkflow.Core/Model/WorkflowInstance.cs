
namespace OpenBusinessWorkflow.Core.Model
{
    public class WorkflowInstance
    {
        public WorkflowInstance()
        {
            Workflow = new Workflow();
        }
        public Guid InstanceId { get; set; }
        public Workflow Workflow { get; set; }
    }
}
