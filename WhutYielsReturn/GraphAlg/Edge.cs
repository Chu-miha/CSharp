using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlg
{
    public class Edge
    {
        public readonly Node First;
        public readonly Node Second;

        public Edge(Node first, Node second)
        {
            First = first;
            Second = second;
        }

        public Node From { get { return First; } }

        public bool IsIncident(Node node)
        {
            return node == First || node == Second;
        }

        public Node OtherNode(Node node)
        {
            if (First == node) return Second;
            else if (Second == node) return First;
            else throw new ArgumentException();
        }
    }
}
