using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            ElasticSearchService myservice = new ElasticSearchService();
            myservice.Ondebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else 
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ElasticSearchService()


            };
            ServiceBase.Run(ServicesToRun);

#endif
        }
    }
}
