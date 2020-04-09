namespace dijkstra_algorithm
{
    class Program
    {
        static void Main()
        {
            var a = new Node("A");
            var b = new Node("B");
            var c = new Node("C");
            var d = new Node("D");
            var e = new Node("E");
            var f = new Node("F");

            a.ConnectTo(b, 4);
            a.ConnectTo(c, 2);
            b.ConnectTo(c, 1);
            b.ConnectTo(d, 5);
            c.ConnectTo(d, 8);
            c.ConnectTo(e, 10);
            d.ConnectTo(f, 6);
            d.ConnectTo(e, 2);
            e.ConnectTo(f, 2);
        }
    }
}
