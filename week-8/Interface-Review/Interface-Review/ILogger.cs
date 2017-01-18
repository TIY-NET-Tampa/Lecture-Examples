using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{
    
   public interface ILogger
    {
        void WriteLog( string message);
        List<Log> GetLogs();
    }
}
