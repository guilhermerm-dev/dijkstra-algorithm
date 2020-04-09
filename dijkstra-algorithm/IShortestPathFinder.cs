namespace dijkstra_algorithm
{
    public interface IShortestPathFinder
    {
        Node[] FindShortestPath(Node from, Node to);
    }
}
