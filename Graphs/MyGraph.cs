using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureAndAlgorithms.Graphs
{
    public class MyGraph
    {
        public int numberOfNodes { get; private set; }
        public List<GraphNode> nodes { get; private set; }
        public List<AdjacentData> adjacentList { get; private set; }
        public MyGraph()
        {
            numberOfNodes = 0;
            adjacentList = new List<AdjacentData>();
            nodes = new List<GraphNode>();
        }
        public void AddVertex(int Data)
        {
            nodes.Add(new GraphNode(Data));
            numberOfNodes++;
        }

        public void AddEdge(int Node1, int Node2)
        {
            var node1 = nodes.Where(x => x.Data == Node1).FirstOrDefault();
            var node2 = nodes.Where(x => x.Data == Node2).FirstOrDefault();
            if(node1 !=null && node2 != null)
            {
                node1.Next.Add(node2);
                node2.Next.Add(node1);
            }
            else
            {
                throw new Exception($"Nodes can't be connected as Node1 = {node1} and Node2 ={node2} is not present in the graph");
            }
        }

        public void showConnections()
        {
            foreach(var node in nodes)
            {
                Console.Write($"{node.Data}----->");
                foreach(var nextNode in node.Next)
                {
                    Console.Write($"{nextNode.Data} ");
                }
                Console.WriteLine();
            }
        }
    }
    public class AdjacentData
    {
        public List<GraphNode> Connections;
    }
    public class GraphNode
    {
        public List<GraphNode> Next { get; set; }
        public int Data { get; set; }
        public GraphNode(int NodeData)
        {
            this.Data = NodeData;
            Next = new List<GraphNode>();
        }
    }
}
