namespace Graph;

static class Program
{

    public static Graph create_nodirected_graph()
    {
        Graph graph = new Graph(false, 7);
        graph.add_edge(0, 1);
        graph.add_edge(1, 2);
        graph.add_edge(2, 4);
        graph.add_edge(4, 6);
        graph.add_edge(6, 5);
        graph.add_edge(5, 3);
        graph.add_edge(3, 1);
        return graph;
    }
    public static void Main(string[] args)
    {
        Graph graph = create_nodirected_graph();
        Console.WriteLine(graph.get_total_edges());
        Console.WriteLine(graph.get_total_nodes());
    }
}