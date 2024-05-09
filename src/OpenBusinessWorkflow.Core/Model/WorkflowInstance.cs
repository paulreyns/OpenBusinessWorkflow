
namespace OpenBusinessWorkflow.Core.Model
{
    /// <summary>
    /// Each Workflow Entity has an associated instance
    /// </summary>
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
