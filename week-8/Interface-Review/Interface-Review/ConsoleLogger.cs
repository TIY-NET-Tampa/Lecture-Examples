using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class ConsoleLogger : ILogger
    {
        public List<Log> GetLogs()
        {
            return new List<Log>();
        }

        public void WriteLog(string message)
        {
            Console.WriteLine("Logging ****************" + DateTime.Now);
            Console.WriteLine(message);
        }
    }
}
