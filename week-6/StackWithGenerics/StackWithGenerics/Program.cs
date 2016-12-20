using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithGenerics
{


    class Parent { }
    class Child: Parent { }


    class Pet { }

    class Family<T, K>
    {
        public List<T> Members { get; set; } = new List<T>();
        public List<K> Animals { get; set; } = new List<K>();
    }
    class Stack<T>
    {
        private List<T> stack { get; set; } = new List<T>();
        
        public T GetDefaultValue()
        {
            return default(T);
        }

        public T Pop()
        {
            var last = stack.Last();
            stack.Remove(last);
            return last;
        }
        public void Push(T item)
        {
            stack.Add(item);
        }
    }

    class Program
    {
        public static int RecursiveCounter(int counter)
        {
            if (counter == 0)
            {
                Console.WriteLine("BlastOff!!!!");
                return 0;
            }
            else
            {
                Console.WriteLine($"CountDown {counter}");
                return RecursiveCounter(counter -1);
            }
        }

        static void Main(string[] args)
        {
            var dad = new Parent();


            var fam = new Family<Parent, Child>();

            fam.Members.Add(new Child());
            fam.Members.Add(new Parent());


            var intStack = new Stack<int, int>();

            var def = intStack.GetDefaultValue();

            intStack.Push(12);
            intStack.Push(3);
            intStack.Push(5);

            var l = intStack.Pop();
            var m = intStack.Pop();
            var n = intStack.Pop();


            Console.ReadLine();
        }
    }
}
