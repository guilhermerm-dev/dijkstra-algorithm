namespace dijkstra_algorithm
{
    public struct NeighborHoodInfo
    {
        public NeighborHoodInfo(Node node, int weightToNode)
        {
            Node = node;
            WeightToNode = weightToNode;
        }

        public Node Node { get; }
        public int WeightToNode { get; }
    }
}
