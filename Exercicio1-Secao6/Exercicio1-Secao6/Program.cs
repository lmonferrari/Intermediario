namespace Exercicio1_Secao6
{
    class Program
    {      
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new VideoUpload());
            workflow.AddActivity(new SendEmail());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
