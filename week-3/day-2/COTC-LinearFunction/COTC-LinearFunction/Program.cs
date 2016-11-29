using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/


//The program:
//Your program must compute the value of a linear function at the given points.

//A linear function is of the form (answer = a* x + b), with a and b,
//two constant values.You are given the values a, b 
//and a set of N values of x.You must compute the value of f(x) for each of 
//the N values of x.

//INPUT:
//Line 1 : two space-separated integers a and b
//Line 2 : an integer N
//N next lines : an integer x on each line

//OUTPUT:
//N lines : the value of f(x) for each x value given as input

//CONSTRAINTS:
//-100 < a, b< 100
//-100 < x< 100

//EXAMPLE:
//Input
//5 -2
//3
//3
//8
//-1
//Output
//13
//38
//-7



class Solution
{
    static int Linear(int a, int b, int x)
    {
        return a * x + b;
    }

    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Linear(a, b, x));
        }

    }
}