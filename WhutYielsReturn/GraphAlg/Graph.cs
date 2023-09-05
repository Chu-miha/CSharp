using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlg
{
    public class Graph
    {
        // public readonly List<Node> Nodes = new List<Node>();

        private readonly Node[] nodes;

        public Graph(int nodesCount) 
        {
            nodes = Enumerable.Range(0, nodesCount).Select(z => new Node(z)).ToArray();
        }

        public Node this[int index]
        {
            get { return nodes[index]; }
        }

        public Edge this[int index0, int index1]
        {
            get
            {
                if (nodes[index0].IncidentEdges.First().IsIncident(nodes[index1]))
                {
                    return nodes[index0].IncidentEdges.First();
                }
                return null;
            }
        }

        public IEnumerable<Node> Nodes 
        { 
            get 
            { 
                foreach (var node in nodes) yield return node; 
            }
        }

        public IEnumerable<Edge> Edges
        {
            get
            {
                return Nodes.SelectMany(z => z.IncidentEdges).Distinct();
            }
        }

        public void Connect (int v1, int v2)
        {
            nodes[v1].Connect(nodes[v2]);
        }

        public static Graph MakeGraph(params int[] incidentNodes)
        {
            var graph = new Graph(incidentNodes.Max() + 1);
            for (int i = 0; i < incidentNodes.Length - 1; i += 2)
            {
                graph.Connect(incidentNodes[i], incidentNodes[i + 1]);
            }
            return graph;
        }
    }
}
