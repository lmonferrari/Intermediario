namespace Exercicio1_Secao6
{
    class Program
    {

        static void Main(string[] args)
        {
            var workFlowEngine = new WorkflowEngine(new VideoUpload());
            workFlowEngine.Run();

            workFlowEngine = new WorkflowEngine(new SendEmail());
            workFlowEngine.Run();
        }
    }
}
