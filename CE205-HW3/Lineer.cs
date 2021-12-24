using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CE205_HW3.libs
{
    public class Lineer
    {
        int[] table;
        public Lineer(int length)
        {
            table = new int[length];
            for (int i = 0; i < length; i++)
            {
                table[i] = -1;
            }
        }
        public int Hash(int data)
        {
            return data % table.Length;
        }
        public int TableLength()
        {
            int result = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] >= 0)
                {
                    result++;
                }
            }
            return result;
        }
        public void Insert(int data)
        {
            if (data < 0)
            {
                Console.WriteLine("Do not add negative numbers");
                return;
            }
            if (TableLength() == table.Length)
            {
                Console.WriteLine("Array is full");
                MessageBox.Show("Array full.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int key = Hash(data);
            int actualKey = key;
            for (; key < table.Length + 1; key++)
            {
                if (key == table.Length)
                {
                    for (int v = 0; v < actualKey + 1; v++)
                    {
                        if (table[v] < 0)
                        {
                            table[v] = data;
                            Console.WriteLine("added");
                            return;
                        }
                    }
                    Console.WriteLine("no add at actualKey");
                    return;
                }
                if (table[key] < 0)
                {
                    table[key] = data;
                    Console.WriteLine("added");
                    return;
                }
            }
            Console.WriteLine("no add");

        }
        public bool Search(int data)
        {
            int key = Hash(data);
            int actualKey = key;
            for (; key < table.Length + 1; key++)
            {
                if (key == table.Length)
                {
                    for (int v = 0; v < actualKey + 1; v++)
                    {
                        if (data == table[v])
                        {
                            Console.WriteLine("Found! at actualKey");
                            return true;
                        }
                    }
                    Console.WriteLine("Not found! at actualKey");
                    return false;
                }
                if (data == table[key])
                {
                    Console.WriteLine("Found!");
                    return true;
                }
            }
            Console.WriteLine("Not found!");
            return false;
        }
        public void Delete(int data)
        {
            int key = Hash(data);
            int actualKey = key;
            for (; key < table.Length + 1; key++)
            {
                if (key == table.Length)
                {
                    for (int v = 0; v < actualKey + 1; v++)
                    {
                        if (data == table[v])
                        {
                            Console.WriteLine("Deleted! at actualKey");
                            table[v] = -1;
                            return;
                        }
                    }
                    Console.WriteLine("Not Deleted! at actualKey");
                    return;
                }
                if (data == table[key])
                {
                    Console.WriteLine("Deleted!");
                    table[key] = -1;
                    return;
                }
            }
            Console.WriteLine("Not Deleted!");
            return;
        }
        public void Print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }

        public void printTable(ref Microsoft.Msagl.Drawing.Graph grapObject)
        {
            for (int i = 0; i < table.Length; i++)
            {
                string prevNode = "i: " + i.ToString();

                string dest = table[i].ToString();
                if(table[i] >= 0)
                {
                    Edge edge = grapObject.AddEdge(prevNode, dest);
                    grapObject.FindNode(dest).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Cyan;
                }

            }
        }
    }
}
