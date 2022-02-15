using Algorithms.LinkListMiddleNode;
using Algorithms.Trees;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the middle of a link list
            //TortoiseAndHare.RunSample();
            DepthOfTree.RunSample();

            //solve(4, "A", "B", "C");

            //recursion(4);
        }


        public static void solve(int n, string start, string auxiliary, string end)
        {
            if (n == 1)
            {
                Console.WriteLine(start + " -> " + end);
            }
            else
            {
                solve(n - 1, start, end, auxiliary);
                Console.WriteLine(start + " -> " + end);
                solve(n - 1, auxiliary, start, end);
            }
        }


        public static void recursion(int x,string t =null)
        {
            if (x == 0)
                return;
            Console.WriteLine(x+ t);
            x--;
            recursion(x);
            recursion(x, "'");
        }
    }
}
