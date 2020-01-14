using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebJobs
{
    public class ContinuousFunction
    {
        private readonly Service service;

        public ContinuousFunction(Service service)
        {
            this.service = service;
        }

        [FunctionName("ContinuousFunction")]
        [NoAutomaticTrigger]
        public async Task Execute()
        {
            while (true)
            {
                this.service.Execute();
                await Task.Delay(3000);
            }
            
        }
    }
}
