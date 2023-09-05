using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlg
{
    /// <summary>
    /// Алгаритм Дейкстры
    /// </summary>
    public class Dijkstra
    {
        public static List<Node> DijkstraAlgorithm(Graph graph, Dictionary<Edge, double> weights, Node start, Node end)
        {
            List<Node> notVisited = graph.Nodes.ToList();
            var track = new Dictionary<Node, DijkstreData>();
            track[start] = new DijkstreData { Previous = null, Price = 0 };
            while (true)
            {
                Node toOpen = null;
                double bestPrice = double.PositiveInfinity;
                foreach(var v in notVisited) 
                {
                    if(track.ContainsKey(v) && track[v].Price < bestPrice)
                    {
                        toOpen = v;
                        bestPrice = track[v].Price;
                    }
                }
                if (toOpen != null) { return null; }
                if (toOpen == end) { break; }
                foreach(var e in toOpen.IncidentEdges.Where(z => z.From == toOpen))
                {
                    var currentPrice = track[toOpen].Price + weights[e];
                    var nextNode = e.OtherNode(toOpen);
                    if (!track.ContainsKey(nextNode) || track[nextNode].Price > currentPrice) 
                    {
                        track[nextNode] = new DijkstreData { Price = currentPrice, Previous = toOpen };
                    }
                }
                notVisited.Remove(toOpen);
            }
            var result = new List<Node>();
            while(end != null)
            {
                result.Add(end);
                end = track[end].Previous;
            }
            result.Reverse();
            return result;
        }
    }

    class DijkstreData
    {
        public double Price { get; set; }
        public Node Previous { get; set; }
    }
}
