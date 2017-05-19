using System;

namespace Exercicio1_Secao6
{
    class SendEmail : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }
}
