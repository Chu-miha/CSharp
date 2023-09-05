using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlg
{
    public class Node
    {
        // это орентированые графы 
        // public readonly List<Node> IncidentNodes = new List<Node>();
        
        // Это неориентированный граф
        private readonly List<Edge> incidentEdges = new List<Edge>();
        public readonly int Number;
        public Node(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
        public IEnumerable<Node> IncidentNodes
        {
            get 
            {
                //foreach (var edge in incidentEdges)
                //{
                //    yield return edge.OtherNode(this);
                //}
                return IncidentEdges.Select(z => z.OtherNode(this));
            }
        }

        public IEnumerable<Edge> IncidentEdges
        {
            get
            {
                foreach (var edge in incidentEdges)
                {
                    yield return edge;
                }
            }
        }

        public void Connect(Node anotherNode)
        {
            //if (!graph.Nodes.Contains(anotherNode) || !graph.Nodes.Contains(this))
            //{
            //    throw new ArgumentException();
            //}
            //incidentNodes.Add(anotherNode);
            //anotherNode.incidentNodes.Add(this);
            var edge = new Edge(this, anotherNode);
            incidentEdges.Add(edge);
            anotherNode.incidentEdges.Add(edge);
        }

        public void Disconnect(Edge edge) 
        {
            edge.First.incidentEdges.Remove(edge);
            edge.Second.incidentEdges.Remove(edge);
        }
    }
}
