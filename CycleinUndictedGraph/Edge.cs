using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleinUndictedGraph
{
    class Edge
    {
        public int V;
        public int Source, Destination;
        public Edge(int V)
        {
            this.V = V;
        }

        public Edge(int Source, int Destination)
        {
            this.Source = Source;
            this.Destination = Destination;
        }

        public bool DetectCycle(List<Edge> LE)
        {
            JoinSet js = new JoinSet();
            int len = LE.Count;
            JoinSet[] JS = js.Set(len);
            for (int i = 0; i <len ; i++)
            {
                int S = LE[i].Source;
                int D = LE[i].Destination;

                if (JS[S].Parent != JS[D].Parent)
                    js.Union(JS, S, D);
                else
                    return true;
            }
            return false;
        }
    }
}
