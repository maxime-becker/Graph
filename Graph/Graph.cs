using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Graph
    {

        int order;
        bool directed;
        List<List<int>> adjlists;

        public Graph(bool directed) 
        {
            adjlists = new List<List<int>>();
            order = 0;
        }

        public Graph(bool directed, int order)
        {
            this.directed= directed;
            this.order = order;
            adjlists= new List<List<int>>();
            for(int i =0; i<order; i++)
            {
                adjlists.Add(new List<int>());
            }
        }

        // METHODS

        public void add_node()
        {
            this.order++;
            adjlists.Add(new List<int>());
        }

        public void add_edge(int src, int dst)
        {
            if(dst > order || src > order)
            {
                return;
            }
            if(directed)
            {
                adjlists[src].Add(dst);
            }
            else
            {
                adjlists[src].Add(dst);
                adjlists[dst].Add(src);
            }
        }

        public int get_total_nodes()
        {
            return order;
        }

        public int get_total_edges()
        {
            int count = 0;
            foreach(var val in adjlists)
            {
                foreach(var edge in val)
                {
                    count++;
                }
            }
            if(directed)
            {
                return count;
            }
            return count / 2;
        }

        public void delete_edge(int src, int dst)
        {
            if (dst > order || src > order)
            {
                return;
            }
            if (directed)
            {
                adjlists[src].Remove(dst);
            }
            else
            {
                adjlists[src].Remove(dst);
                adjlists[dst].Remove(src);
            }
        }

        // PROPERTIES

        public bool is_empty()
        {
            if(order == 0) return true;
            return false;
        }

        // DISPLAY METHODS

        public void display_nodes()
        {
            for(int i = 0; i<order; i++)
            {
                Console.WriteLine(i);
            }
        }
       
        public void display_edges()
        {
            for (int i = 0; i < adjlists.Count; i++)
            {
                for (int j = 0; j < adjlists[i].Count; j++)
                {
                    Console.WriteLine("Node : " + i  + " is connected with " + adjlists[i][j]);
                }
            }
        }

        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < adjlists.Count; i++)
            {
                str += (i) + " is connected to ";
                for(int j = 0; j < adjlists[i].Count; j++)
                {
                    str += (adjlists[i][j]).ToString() + " ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
