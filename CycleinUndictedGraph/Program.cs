using System;
using System.Collections.Generic;

namespace CycleinUndictedGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Edge E1 = new Edge(0, 1);
            Edge E2 = new Edge(1, 2);
            Edge E3 = new Edge(3, 4);
            Edge E4 = new Edge(2, 3);
            Edge E5 = new Edge(4, 5);
            Edge E6 = new Edge(5, 2);
            List<Edge> LE = new List<Edge>();
            LE.Add(E1);
            LE.Add(E2);
            LE.Add(E3);
            LE.Add(E4);
            LE.Add(E5);
            LE.Add(E6);

            Edge E = new Edge(6);

            Console.WriteLine(E.DetectCycle(LE));
            Console.ReadLine();
        }
    }
}
