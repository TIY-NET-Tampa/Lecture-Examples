using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview_Calculator
{
    public class MyMath
    {
        public double LastAnswer { get; set; }
        public double MemorySlot { get; set; }
        public double Add(double x, double y)
        {
            var rv = x + y;
            this.LastAnswer = rv;
            return rv;
        }

        public double TogglesTheSignOfLastAnswer()
        {
            this.LastAnswer *= -1;
            return this.LastAnswer;
        }

        public double SaveLastAnswerToMemory()
        {
            this.MemorySlot = this.LastAnswer;
            return this.MemorySlot;
        }

        public double RecallLastMemory()
        {
            return this.MemorySlot;
        }

    }
}
