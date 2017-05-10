using IntroToTesting.DataContext;
using IntroToTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToTesting
{
   public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int? Add(IEnumerable<int?> nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException("nums");
            }
            if (nums.Any( a => a == null))
            {
                throw new NullReferenceException();
            }
            return nums.Sum();
        }

        public Answer AddAndSaveToDatasebase(int x, int y)
        {
            var total = this.Add(x, y);
            var answer = new Answer()
            {
                Result = total.ToString()
            };
            var db = new CalcContext();
            db.Answers.Add(answer);
            db.SaveChanges();
            return answer;
        }

    }
}
