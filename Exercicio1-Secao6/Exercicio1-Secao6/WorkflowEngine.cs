using System.Collections.Generic;

namespace Exercicio1_Secao6
{

    class WorkflowEngine
    {

        public void Run(Workflow workflow)
        {
            foreach (IWorkflow item in workflow.GetActivities())
            {
                item.Execute();
            }
        }
    }
}
