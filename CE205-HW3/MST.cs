/**
  * @file MST.cs
  * @author Utku ORUC
  * @date 20 November 2021
  *
  *
  */
using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3.libs
{
    public class MST
    {
        // A utility function to find
        // the vertex with minimum key
        // value, from the set of vertices
        // not yet included in MST
        public int minKey(int[] key, bool[] mstSet, int vertexSize)
        {
            //no diff
            // Initialize min value
            int min = int.MaxValue, min_index = -1;


            for (int v = 0; v < vertexSize; v++)
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    min_index = v;
                }

            return min_index;

        }

        // A utility function to print
        // the constructed MST stored in
        // parent[]
        public void printMST(int[] parent, int[,] graph, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {

            if (clearEdges)
            {
                graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
            }

            int vertexSize = graph.GetLength(0);

            Console.WriteLine("Edge \tWeight");

            for (int i = 1; i < vertexSize; i++)
            {
                string fromNode = Util.GetNodeLetter(parent[i]);
                string toNode = Util.GetNodeLetter(i);
                string weight = graph[i, parent[i]].ToString();

                Node node = graphObject.FindNode(fromNode);

                if (node != null)
                {
                    node.RemoveOutEdge(new Microsoft.Msagl.Drawing.Edge(fromNode, weight, toNode));
                }

                Edge edge = graphObject.AddEdge(fromNode, weight, toNode);

                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                edge.Attr.LineWidth = 5;

                //Console.WriteLine(parent[i] + " - " + i + "\t" + graph[i, parent[i]]);
            }

        }

        // Function to construct and
        // print MST for a graph represented
        // using adjacency matrix representation
        public void primMST(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph grapObject)
        {

            int vertexSize = graphArray.GetLength(0);

            // Array to store constructed MST
            int[] parent = new int[vertexSize];

            // Key values used to pick
            // minimum weight edge in cut
            int[] key = new int[vertexSize];

            // To represent set of vertices
            // included in MST
            bool[] mstSet = new bool[vertexSize];

            // Initialize all keys
            // as INFINITE
            for (int i = 0; i < vertexSize; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            // Always include first 1st vertex in MST.
            // Make key 0 so that this vertex is
            // picked as first vertex
            // First node is always root of MST
            key[0] = 0;
            parent[0] = -1;

            // The MST will have V vertices
            for (int count = 0; count < vertexSize - 1; count++)
            {

                // Pick thd minimum key vertex
                // from the set of vertices
                // not yet included in MST
                int u = minKey(key, mstSet, vertexSize);

                // Add the picked vertex
                // to the MST Set
                mstSet[u] = true;

                // Update key value and parent
                // index of the adjacent vertices
                // of the picked vertex. Consider
                // only those vertices which are
                // not yet included in MST
                for (int v = 0; v < vertexSize; v++)

                    // graph[u][v] is non zero only
                    // for adjacent vertices of m
                    // mstSet[v] is false for vertices
                    // not yet included in MST Update
                    // the key only if graph[u][v] is
                    // smaller than key[v]
                    if (graphArray[u, v] != 0 && mstSet[v] == false
                        && graphArray[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graphArray[u, v];
                    }
            }

            // print the constructed MST
            printMST(parent, graphArray, clearEdges, ref grapObject);
        }
    }
}