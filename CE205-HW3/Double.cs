using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    public class Double
    {
        int[] table;
        public Double(int length)
        {
            table = new int[length];
            for (int i = 0; i < length; i++)
            {
                table[i] = -1;
            }
        }
        public int Hash1(int data)
        {
            return data % table.Length;
        }
        public int Hash2(int data)
        {
            return 7 - data % 7;
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
            if (TableLength() == table.Length)
            {
                Console.WriteLine("Array is full");
                MessageBox.Show("Array is full", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (data < 0)
            {
                Console.WriteLine("Do not add negative numbers");
                MessageBox.Show("Do not add negative numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int j = 0;
            int key = Hash1(data);
            int actualKey = key;

            if (table[key] != -1)
            {
                while (table[key] != -1)
                {
                    j++;
                    key = j * Hash2(data);
                    if (key >= table.Length)
                    {
                        //key = key - table.Length;
                        key = key % table.Length;
                    }
                    
                }
                table[key] = data;
                Console.WriteLine("added at" + key);
                return;
            }
            else
            {
                table[key] = data;
                Console.WriteLine("added at" + key);
                return;
            }
            Console.WriteLine("no add");

        }
        public bool Search(int data)
        {
            int key = Hash1(data);
            int actualKey = key;
            int j = 0;
            int tries = 0;
            while (table[key] != data)
            {
                j++;
                tries++;
                key = j * Hash2(data);
                if (key >= table.Length)
                {
                    //key = key - table.Length;
                    key = key % table.Length;
                }
                if (tries > table.Length * table.Length)
                {
                    break;
                }
                tries++;
            }

            if (table[key] == data)
            {
                Console.WriteLine("Found at key: " + key);
                return true;
            }
            else
            {
                Console.WriteLine("Not found!");
                return false;
            }

        }
        public void Delete(int data)
        {
            int key = Hash1(data);
            int actualKey = key;
            int j = 0;
            if (data < 0)
            {
                Console.WriteLine("Do not add negative numbers");
                return;
            }
            while (table[key] != data)
            {
                j++;
                key = j * Hash2(data);
                if (key >= table.Length)
                {
                    //key = key - table.Length;
                    key = key % table.Length;
                }
            }

            if (table[key] == data)
            {
                Console.WriteLine("Deleted {0} at key: {1}", data, key);
                table[key] = -1;
                return;
            }
            else
            {
                Console.WriteLine("no such number as: " + data);
                return;
            }
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
                if (table[i] >= 0)
                {
                    Edge edge = grapObject.AddEdge(prevNode, dest);
                    grapObject.FindNode(dest).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Cyan;
                }

            }
        }
    }

}
