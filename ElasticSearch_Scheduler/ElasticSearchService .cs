using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace ElasticSearchScheduler
{
    partial class ElasticSearchService : ServiceBase
    {
        private static Timer _timer;

        public ElasticSearchService()
        {
            InitializeComponent();
        }

        public void Ondebug()
        {
            OnStart(null);
        }

        protected override void OnStop()
        {
            ServiceController service = new ServiceController("ElasticSearchService");
            try
            {
                this.WriteToFile("Simple Service stopped {0}");
                TimeSpan timeout = TimeSpan.FromMilliseconds(100);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch (Exception ex)
            {
                this.WriteToFile("Error Occured during stopping the service at " + DateTime.Now.ToString() +" ,Error Meassage => " + ex.StackTrace.ToString() + "");
            }
            
        }


        private Timer Schedular;

        public void ScheduleService()
        {
            try
            {
              
                var startTimeSpan = TimeSpan.Zero;
                var periodTimeSpan = TimeSpan.FromMinutes(Convert.ToDouble(ConfigurationManager.AppSettings["schedulertime"]));

               
                var timer = new System.Threading.Timer((e) =>
                {
                    DAL.schdeulerInsertion();
                   // test.function1();
                    string schedule1 = string.Format("{0} day(s) {1} hour(s) {2} minute(s) {3} seconds(s)", periodTimeSpan.Days, periodTimeSpan.Hours, periodTimeSpan.Minutes, periodTimeSpan.Seconds);
                    this.WriteToFile("Simple Service scheduled to run after: " + schedule1 + ".Last run at {0}");
                    this.WriteToFile("-----------------------------------------------------------------------------------------------------------");

                }, null, startTimeSpan, periodTimeSpan);

             
            }
            catch (Exception ex)
            {
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace);
                
            }

        }

        private void SchedularCallback(object e)
        {
            this.WriteToFile("Simple Service Log: {0}");
            this.ScheduleService();
        }

        private void WriteToFile(string text)
        {
            string path = "D:\\es_scheduler.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                writer.Close();
            }
        }


        public void OnDebug()
        {
            OnStart(null);
        }

    }
}
