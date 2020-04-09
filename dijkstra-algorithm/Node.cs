using System.Collections.Generic;
using System.Linq;

namespace dijkstra_algorithm
{
    public class Node
    {
        private List<Edge> _edges;

        //Vértice
        public Node(string label)
        {
            Label = label;
            _edges = new List<Edge>();
        }

        public string Label { get; }
        public IEnumerable<Edge> Edges => _edges;
        public IEnumerable<NeighborHoodInfo> Neighbors => Edges.Select(edge =>
        new NeighborHoodInfo(edge.Node1 == this ? edge.Node2 : edge.Node2
            , edge.Value));

        public void Assign(Edge edge)
        {
            _edges.Add(edge);
        }

        public void ConnectTo(Node other, int connectionValue)
        {
            Edge.Create(connectionValue, this, other);
        }

    }
}
