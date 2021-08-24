using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleinUndictedGraph
{
    class JoinSet
    {
        public int Parent;
        public int Rank;
        JoinSet[] JS;

        public JoinSet()
        {

        }
        public JoinSet[] Set(int Vertex)
        {
            JS = new JoinSet[Vertex];
            for (int i = 0; i < Vertex; i++)
            {
                JS[i] = new JoinSet();
                JS[i].Rank = 0;
                JS[i].Parent = i;
            }
            return JS;
        }

        public int FindParent(JoinSet[] JS , int V)
        {
            if (JS[V].Parent != V)
                JS[V].Parent = FindParent(JS, JS[V].Parent);
            return JS[V].Parent;
        }

        public void Union(JoinSet[] JS, int X, int Y)
        {
            int Xparent = FindParent(JS, X);
            int Yparent = FindParent(JS, Y);

            if (JS[Yparent].Rank > JS[Xparent].Rank)
                JS[Xparent].Parent = Yparent;
            if (JS[Yparent].Rank < JS[ Xparent].Rank)
                JS[Yparent].Parent = Xparent;
            if(JS[Xparent].Rank == JS[Yparent].Rank)
            {
                JS[Xparent].Rank++;
                JS[Yparent].Parent = X;
            }
        } 
        
    }
}
