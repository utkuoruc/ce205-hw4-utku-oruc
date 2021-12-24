/****************************************************************************
 * Copyleft (L) 2021 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 ****************************************************************************/

/**
 * @file Seperate.cs
 * @author Utku Oruc
 * @date 21 December 2021
 *
 * @brief <b> Seperate Chaining algorithm </b>
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
    public class Seperate
    {
        public HashNode[] table;
        public class HashNode
        {
            public int data;
            public HashNode next;

            /**
		*
			@name  AddHashNode
			@brief \b Adds node
			Add node to the table.
		    **/
            public void AddHashNode(int data, int index, HashNode[] table)
            {
                if (table[index] == null)
                {

                    HashNode node = new HashNode();

                    node.data = data;
                    node.next = null;

                    table[index] = node;
                }
                else
                {
                    HashNode tmp = table[index];
                    HashNode node = new HashNode();

                    while (tmp.next != null)
                    {
                        tmp = tmp.next;
                    }
                    tmp.next = node;
                    node.data = data;
                    node.next = null;
                }
            }

        }
        /**
		*
			@name  AddHashNode
			@brief \b Insert element
			Inserts element
		    **/
        public void Inserty(int data, HashNode[] table)
        {
            int key = data % table.Length;
            HashNode node = new HashNode();
            if (Searchy(data, table) == true)
            {
                //duplicate items
                return;
            }
            else
            {
                node.AddHashNode(data, key, table);
            }

        }
        /**
		*
			@name  AddHashNode
			@brief \b List
		    **/
        public void Listy(HashNode[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                HashNode tmp = table[i];
                //HashNode node = new HashNode();
                Console.WriteLine("Index: " + i);
                while (tmp != null)
                {
                    Console.WriteLine(tmp.data);
                    tmp = tmp.next;
                }

            }

        }
        /**
		*
			@name  Searchy
			@brief \b Search element
		    **/
        public bool Searchy(int value, HashNode[] table)
        {
            int key = value % table.Length;
            HashNode tmp = table[key];

            while (tmp != null)
            {
                if (value == tmp.data)
                    return true;
                else
                    tmp = tmp.next;

            }
            return false;

        }
        /**
		*
			@name  Searchy
			@brief \b Delete element
		    **/
        public void Deletey(int value, HashNode[] table)
        {
            int key = value % table.Length;
            HashNode tmp = table[key];
            if (Searchy(value, table) == false)
            {
                Console.WriteLine("There is no such key");
                return;
            }
            else
            {
                if (tmp.data == value)
                {
                    table[key] = tmp.next;
                    Console.WriteLine("Value was stored in the array index directly, and removed.");
                    return;
                }
                else
                {
                    HashNode prev = tmp;
                    while (tmp != null)
                    {
                        if (value == tmp.data)
                        {
                            prev.next = tmp.next;
                            tmp.next = null;
                            Console.WriteLine("Deleted");
                            return;
                        }

                        else
                        {
                            prev = tmp;
                            tmp = tmp.next;
                        }
                    }
                    Console.WriteLine("Couldn't delete.");
                    return;

                }
            }
        }
        public void SeperateHashing(int length, ref Microsoft.Msagl.Drawing.Graph grapObject)
        {
            /*
            HashNode[] table = new HashNode[length];
            Seperate desperate = new Seperate();

            desperate.Inserty(7, table);
            desperate.Inserty(11, table);
            desperate.Inserty(50, table);
            desperate.Inserty(4, table);
            desperate.Inserty(21, table);
            desperate.Inserty(31, table);
            desperate.printTable(table, ref grapObject);
            */
        }
        /**
		*
			@name  printTable
			@brief \b print table
		    **/
        public void printTable(HashNode[] table, ref Microsoft.Msagl.Drawing.Graph grapObject)
        {
            for (int i = 0; i < table.Length; i++)
            {
                HashNode tmp = table[i];
                string prevNode = "i: " + i.ToString();
                //HashNode node = new HashNode();
                while (tmp != null)
                {
                    string dest = tmp.data.ToString();
                    Edge edge = grapObject.AddEdge(prevNode, tmp.data.ToString());
                    grapObject.FindNode(dest).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Cyan;
                    prevNode = tmp.data.ToString();
                    tmp = tmp.next;
                }

            }
        }
    }
}
