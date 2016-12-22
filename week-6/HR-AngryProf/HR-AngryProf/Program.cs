using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_AngryProf
{
    class Program
    {
        public enum ClassStatus
        {
            NO,
            YES
        }

        public static ClassStatus ProcessTestCase(int N, int K, IEnumerable<int> times)
        {
            var present = times.Count(c => c <= 0);
            return present < K ? ClassStatus.YES : ClassStatus.NO;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var outputs = new List<ClassStatus>();
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                outputs.Add(ProcessTestCase(n, k, a));    
            }
            foreach (var item in outputs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
