using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    class Program
    {

        public class No5Exception : Exception
        {
            public No5Exception(string message) : base(message)
            {

            }
        }

        static void Main(string[] args)
        {
            try
            {

                var x = 5 * 5;
            }
            catch (Exception)
            {
            }



            var gettingInput = true;
            while (gettingInput)
            {
                try
                {
                    var denominator = int.Parse(Console.ReadLine());
                    if (denominator == 5)
                    {
                        throw new No5Exception("We dont like 5s");
                    }

                    var anwer = 10 / denominator;
                    Console.WriteLine(anwer);
                    gettingInput = false;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Ooops, You need to type a number -- {ex.Message}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Can't divide by Zero, Do you even Math?");
                }
                catch (No5Exception ex)
                {
                    Console.WriteLine($"Nope, no 5s allowed -- {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Not sure what happened, but we didnt like it -- {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Good Work == from Finally");
                }

            }

        }
    }
}
