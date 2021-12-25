/****************************************************************************
 * Copyleft (L) 2021 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 ****************************************************************************/

/**
 * @file Quad.cs
 * @author Utku Oruc
 * @date 21 December 2021
 *
 * @brief <b> Quadratic Probing algorithm </b>
 *
 * HW-4 Sample Lib Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
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
    public class Quad
    {
        int[] table;
        /**
		*
			@name  Quad
			@brief \b constructor
		    **/
        public Quad(int length)
        {
            table = new int[length];
            for (int i = 0; i < length; i++)
            {
                table[i] = -1;
            }
        }
        /**
		*
			@name  Hash
			@brief \b hash function
		    **/
        public int Hash(int data)
        {
            return data % table.Length;
        }
        /**
		*
			@name  TableLength
			@brief \b return the numbe rof elements in the list
		    **/
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
        /**
		*
			@name  Insert
			@brief \b insert a value 
		    **/
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
        /**
		*
			@name  Search
			@brief \b search an element
		    **/
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
        /**
		*
			@name  Delete
			@brief \b deletes an element
		    **/
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
        /**
		*
			@name  Print
			@brief \b print whole thing
		    **/
        public void Print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }
        /**
		*
			@name  printTable
			@brief \b print table by adding nodes
		    **/
        public void ClearTable()
        {
            for (int i = 0; i < table.Length; i++)
            {

                table[i] = -1;
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
