using System.Collections.Generic;

namespace Exercicio1_Secao6
{
    class Workflow
    {
        private readonly IList<IWorkflow> _listActivities;

        public Workflow()
        {
            _listActivities = new List<IWorkflow>();
        }

        public void AddActivity(IWorkflow workflow)
        {
            _listActivities.Add(workflow);
        }

        public IEnumerable<IWorkflow> GetActivities()
        {
            return _listActivities;
        }
    }
}
