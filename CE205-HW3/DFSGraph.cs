/**
  * @file DFSGraph.c
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
// C# program to print DFS traversal
// from a given graph

// This class represents a directed graph
// using adjacency list representation
namespace CE205_HW3.libs
{

	// This class represents a directed graph
	// using adjacency list representation
	public class DFSGraph
	{
		public int vertexSize;

		//List<Edge> edges = new List<Edge>();

		// Array of lists for
		// Adjacency List Representation
		public List<int>[] adj;
		public Stack<int> visited;
		public Stack<int> path;
		public Stack<int> finalEdges; //2'li 2'li alıncak
		public DFSGraph()
		{
			visited = new Stack<int>();
			path = new Stack<int>();
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
			@name  printDFS
			@brief \b Copy string
			print DFS solution
		**/
		public void printDFS(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
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
			//some tries, didnt want to delete them. totally unnecessary to read
			/*
			for (int i = 0; i< vertexSize - 1 ; i++)
            {
				
				Console.WriteLine("***********");
				int tmp1 = finalEdges.Peek();
				finalEdges.Pop();
				int tmp2 = finalEdges.Peek();
				string fromNode = Util.GetNodeLetter(tmp1);
				string toNode = Util.GetNodeLetter(tmp2);
				string weight = "1";
				//string weight = graphArray[tmp1, tmp2].ToString();

				Node node = graphObject.FindNode(fromNode);

				if (node != null)
				{
					node.RemoveOutEdge(new Microsoft.Msagl.Drawing.Edge(fromNode, weight, toNode));
				}

				Edge edge = graphObject.AddEdge(fromNode, weight, toNode);

				edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
				edge.Attr.LineWidth = 5;
			}
			*/

		}
		/**
		*
			@name  DFSUtil
			@brief \b Copy string
			for printDFS function, fill the stacks
		**/
		public void DFSUtil(int start)
		{

			if (!visited.Contains(start)) //if n is not visited
			{
				visited.Push(start);
				Console.WriteLine("{0} pushed to visited stack", start);
			}

			if (!path.Contains(start)) //if n is not visited
			{
				path.Push(start);
				Console.WriteLine("{0} pushed to path stack", start);
			}

			List<int> vList = adj[start];
			Console.WriteLine("**********");
			Console.WriteLine("vList len: {0}", vList.Count);

			if (visited.Count < vertexSize)
			{
				int counter = 0;
				foreach (var n in vList)
				{
					if (!visited.Contains(n)) //if n is not visited
					{
						counter++;
						DFSUtil(n);
						Console.WriteLine("here0");
					}

				}
				if (path.Count > 1)
				{
					Console.WriteLine("here1");
					int tmpx1;
					int tmpx2;
					tmpx1 = path.Peek();
					path.Pop();
					Console.WriteLine("{0} removed from path stack", tmpx1);
					tmpx2 = path.Peek();
					finalEdges.Push(tmpx1);
					Console.WriteLine("{0} pushed to finalEdges stack", tmpx1);
					finalEdges.Push(tmpx2);
					Console.WriteLine("{0} pushed to finalEdges stack", tmpx2);
				}
				else if (path.Count == 1)
				{
					int tmp1;
					Console.WriteLine("here y");
					Console.WriteLine("path count: " + path.Count);
					tmp1 = path.Peek();
					path.Pop();
					Console.WriteLine("{0} removed from path stack", tmp1);
					return;
				}
				else
				{
					Console.WriteLine("here v");
					return;
				}

			}
			else
			{
				while (path.Count != 0)
				{
					Console.WriteLine("here2");
					int tmp1;
					int tmp2;
					if (path.Count == 1)
					{
						Console.WriteLine("here3");
						Console.WriteLine("path count: " + path.Count);
						tmp1 = path.Peek();
						path.Pop();
						Console.WriteLine("{0} removed from path stack", tmp1);
						return;
					}
					Console.WriteLine("here4");
					Console.WriteLine("path count: " + path.Count);
					tmp1 = path.Peek();
					path.Pop();
					Console.WriteLine("{0} removed from path stack", tmp1);
					tmp2 = path.Peek();
					finalEdges.Push(tmp1);
					Console.WriteLine("{0} pushed to finalEdges stack", tmp1);
					finalEdges.Push(tmp2);
					Console.WriteLine("{0} pushed to finalEdges stack", tmp2);
					//DFSUtil(tmp2);
				}
				Console.WriteLine("here5");
				return;

			}
		}

		/**
		*
			@name  DFS
			@brief \b Copy string
			main function of this class DFSGraph. 
			convert given array to edges
			solute the problem with filling stacks
			print it
		**/
		public void DFS(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph grapObject)
		{
			incomingGraphToList(graphArray);

			DFSUtil(0); //bozuk.

			printDFS(graphArray, clearEdges, ref grapObject);
		}
	}
}