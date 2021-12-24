/**
  * @file BFSGraph.c
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
	public class BFSGraph
	{
		public int vertexSize;

		//List<Edge> edges = new List<Edge>();

		// Array of lists for
		// Adjacency List Representation
		public List<int>[] adj;
		public Stack<int> visited;
		public Queue<int> path;
		public Stack<int> finalEdges; //2'li 2'li alıncak
		public BFSGraph()
		{
			visited = new Stack<int>();
			path = new Queue<int>();
			finalEdges = new Stack<int>();
		}
		/**
		*
			@name  incomingGraphToList
			@brief \b Copy string
			find edges funct
		**/

		public void incomingGraphToList(int[,] comingArray)
		{

			vertexSize = comingArray.GetLength(0);
			adj = new List<int>[vertexSize];
			for (int i = 0; i < vertexSize; ++i)
				adj[i] = new List<int>();

			for (int i = 0; i < vertexSize; i++)
			{
				for (int j = 0; j < vertexSize; j++)

				{
					if (i == j) continue;

					if (comingArray[i, j] > 0)
					{
						adj[i].Add(j);
					}
				}
			}
		}
		/**
		*
			@name  printBFS
			@brief \b Copy string
			print BFS solution
		**/
		public void printBFS(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
		{

			//dif1
			if (clearEdges)
			{
				graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
			}

			int len = finalEdges.Count;
			int counter = len;
			Console.WriteLine("***********");
			while (finalEdges.Count > 0)
			{
				int tmp1 = finalEdges.Peek();
				finalEdges.Pop();
				int tmp2 = finalEdges.Peek();
				finalEdges.Pop();

				string fromNode = Util.GetNodeLetter(tmp1);
				string toNode = Util.GetNodeLetter(tmp2);
				string weight = Util.GetNodeLetter(graphArray[tmp1, tmp2]);

				Node node = graphObject.FindNode(fromNode);

				if (node != null)
				{
					node.RemoveOutEdge(new Microsoft.Msagl.Drawing.Edge(fromNode, weight, toNode));
				}

				Edge edge = graphObject.AddEdge(fromNode, weight, toNode);

				edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
				edge.Attr.LineWidth = 5;

				counter -= 2;
			}

		}

		/**
		*
			@name  BFSUtil
			@brief \b Copy string
			for printBFS function, fill the queues
		**/
		public void BFSUtil(int start)
		{
			if (!visited.Contains(start)) //if n is not visited
			{
				visited.Push(start);
				Console.WriteLine("{0} pushed to visited stack", start);
			}

			if (!path.Contains(start)) //if n is not visited
			{
				path.Enqueue(start);
				Console.WriteLine("{0} pushed to path queue", start);
			}

			List<int> vList = adj[start];
			Console.WriteLine("**********");
			Console.WriteLine("vList len: {0}", vList.Count);

			foreach (var n in vList)
			{
				if (!visited.Contains(n)) //if n is not visited
				{

					path.Enqueue(n);
					finalEdges.Push(n);
					finalEdges.Push(start);
					visited.Push(n);
				}
			}
			path.Dequeue();
			if (path.Count == 0)
			{
				return;
			}
			else
			{
				BFSUtil(path.First());
			}

		}

		/**
		*
			@name  BFS
			@brief \b Copy string
			main function of this class BFSGraph. 
			convert given array to edges
			solute the problem with filling queues
			print it
		**/
		public void BFS(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph grapObject)
		{
			incomingGraphToList(graphArray);

			BFSUtil(0);

			printBFS(graphArray, clearEdges, ref grapObject);
		}
	}
}