using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    class FileLogger : ILogger
    {
        public List<Log> GetLogs()
        {
            // reads file
            throw new NotImplementedException();
        }

        public void WriteLog(string message)
        {
          // writes to a file
        }
    }
}
