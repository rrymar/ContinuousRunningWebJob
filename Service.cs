using System;
using System.Collections.Generic;
using System.Text;

namespace WebJobs
{
    public class Service
    {
        public void Execute()
        {
            Console.Out.WriteLine(DateTime.Now);
        }
    }
}
