using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchScheduler
{
    public static class test
    {
        public static void function1() {
            string a = "";
            a = "asd";
            WriteToFile("{0}");
        }
        private static void WriteToFile(string text)
        {
            string path = "D:\\es_scheduler.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                writer.Close();
            }
        }
    }

  
}
