using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3.libs
{
    public class Quad
    {
        int[] table;
        public Quad(int length)
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
            int key = Hash(data);
            int actualKey = key;
            int tries = 0;

            if (table[key] != -1)
            {
                while (table[key] != -1)
                {
                    j++;
                    key = (actualKey + j * j);
                    if (key >= table.Length)
                    {
                        //key = key - table.Length;
                        key = key % table.Length;
                    }
                    if (tries > 100)
                    {

                        Console.WriteLine("After more than 100 steps, we couldn't add your number.");
                        MessageBox.Show("After more than 100 steps, we couldn't add your number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tries++;
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
            int key = Hash(data);
            int actualKey = key;
            int j = 0;
            int tries = 0;
            while (table[key] != data)
            {
                j++;
                key = (actualKey + j * j);
                if (key >= table.Length)
                {
                    //key = key - table.Length;
                    key = key % table.Length;
                }
                if (tries > 100)
                {

                    Console.WriteLine("we couldn't find your number.");
                    return false;
                }
                tries++;
            }

            if (table[key] == data)
            {
                Console.WriteLine("Found!");
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
            int key = Hash(data);
            int actualKey = key;
            int j = 0;
            int tries = 0;
            while (table[key] != data)
            {
                j++;
                key = (actualKey + j * j);
                if (key >= table.Length)
                {
                    //key = key - table.Length;
                    key = key % table.Length;
                }
                if (tries > 100)
                {

                    Console.WriteLine("nothing to delete: " + data);
                    MessageBox.Show("nothing to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tries++;
            }

            if (table[key] == data)
            {
                Console.WriteLine("deleted: " + data);
                table[key] = -1;
                return;
            }
            else
            {
                Console.WriteLine("nothing to delete: " + data);
                MessageBox.Show("nothing to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
