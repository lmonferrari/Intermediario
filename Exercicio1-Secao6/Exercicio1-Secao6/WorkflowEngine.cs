using System.Collections.Generic;

namespace Exercicio1_Secao6
{

    class WorkflowEngine
    {
        private readonly IList<IWorflow> _workflowList;

        public WorkflowEngine(IWorflow workflow)
        {
            _workflowList = new List<IWorflow>();
            _workflowList.Add(workflow);
        }

        public void Run()
        {
            foreach (var workflow in _workflowList)
            {
                workflow.Execute();
            }
        }
    }
}
