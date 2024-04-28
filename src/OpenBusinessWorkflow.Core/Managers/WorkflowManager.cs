using OpenBusinessWorkflow.Core.Model;

namespace OpenBusinessWorkflow.Core.Managers
{
    /// <summary>
    /// For managing Workflows CRUD operations
    /// </summary>
    public class WorkflowManager
    {

        /// <summary>
        /// Creates a new workflow in the Store
        /// </summary>
        /// <param name="workflow"></param>
        public async Task Create(Workflow workflow)
        {
            await Task.Delay(0);
            return;
        }

        /// <summary>
        /// Gets an existing Workflow from the Store
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Workflow> Read(Guid id)
        {
            await Task.Delay(0);
            return new Workflow()
            {
                Id = id,
            };
        }

        /// <summary>
        /// Updates an existing Workflow in the Store
        /// </summary>
        /// <param name="workflow"></param>
        public async Task Update(Workflow workflow)
        {
            await Task.Delay(0);
            return;
        }

        /// <summary>
        /// Deletes the existing Workflow from the Store
        /// </summary>
        /// <param name="id"></param>
        public async Task Delete(Guid id)
        {
            await Task.Delay(0);
            return;
        }
    }
}

