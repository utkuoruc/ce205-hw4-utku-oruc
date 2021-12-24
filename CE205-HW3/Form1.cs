/**
  * @file Form1.cs
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

using CE205_HW3.libs;

namespace CE205_HW3
{
    public partial class Form1 : Form
    {
        private Microsoft.Msagl.Drawing.Graph _graphObject;
        public void SetIndexes(int length, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            graphObject = new Microsoft.Msagl.Drawing.Graph("graph");

            string prevNode = "i: 0";
            for (int i = 1; i < length; i++)
            {
                string nodeName = "i: " + i.ToString();

                //graphObject.AddEdge(prevNode, nodeName).Attr.Color = Microsoft.Msagl.Drawing.Color.White;
                graphObject.AddEdge(prevNode, nodeName).IsVisible = false;
                graphObject.FindNode(nodeName).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                graphObject.FindNode(nodeName).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                graphObject.FindNode(prevNode).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                graphObject.FindNode(prevNode).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                prevNode = nodeName;

                /*
                string nodeName = "i: " + i.ToString();
                graphObject.AddNode(nodeName);
                graphObject.FindNode(nodeName).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                graphObject.FindNode(nodeName).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                */
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //_graphObject.AddEdge("A", "B");
            //_graphObject.AddEdge("B", "C");
            //_graphObject.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //_graphObject.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            //_graphObject.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            //Microsoft.Msagl.Drawing.Node c = _graphObject.FindNode("C");
            //c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            //c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            ////bind the graph to the viewer 
            //gViewer1.Graph = _graphObject;

            //gViewer1.Refresh();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void rdBtnSeperate_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdBtnLineer_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        const int length = 10;
        Seperate.HashNode[] table = new Seperate.HashNode[length];
        Seperate desperate = new Seperate();
        Lineer lin1 = new Lineer(length);
        Quad quad1 = new Quad(length);
        Double db1 = new Double(length);
        public void button1_Click(object sender, EventArgs e)
        {
            if (rdBtnSeperate.Checked)
            {
                SetIndexes(length, ref _graphObject);

                desperate.printTable(table, ref _graphObject);

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnLineer.Checked)
            {
                SetIndexes(length, ref _graphObject);

                lin1.printTable(ref _graphObject);

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnQuad.Checked)
            {
                SetIndexes(length, ref _graphObject);

                quad1.printTable(ref _graphObject);

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnDouble.Checked)
            {
                SetIndexes(length, ref _graphObject);

                db1.printTable(ref _graphObject);

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
        }
        private bool MessageBoxes(int textBoxNum)
        {
            TextBox textBoxy = new TextBox();
            if (textBoxNum == 1) textBoxy = textBox1;
            else if (textBoxNum == 2) textBoxy = textBox2;
            else if (textBoxNum == 3) textBoxy = textBox3;

            bool isNumeric = int.TryParse(textBoxy.Text, out int n);
            if (isNumeric == false)
            {
                MessageBox.Show("You can only add integers. \n" +
                    "Range can be between -2,147,483,648 to 2,147,483,647", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxy.Text = null;
                return false;
            }
            if (textBoxy.Text.Length == 0)
            {
                MessageBox.Show("Box can't be free", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (rdBtnSeperate.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = desperate.Searchy(insertVal, table);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                SetIndexes(length, ref _graphObject);
                desperate.Inserty(insertVal, table);
                desperate.printTable(table, ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnLineer.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = lin1.Search(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                SetIndexes(length, ref _graphObject);
                lin1.Insert(insertVal);
                lin1.printTable(ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }

            else if (rdBtnQuad.Checked)
            {
                
                if (!MessageBoxes(1)) return;
                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = quad1.Search(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                SetIndexes(length, ref _graphObject);
                quad1.Insert(insertVal);
                quad1.printTable(ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnDouble.Checked)
            {
                if (!MessageBoxes(1)) return;

                int insertVal = Convert.ToInt32(textBox1.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                bool result = db1.Search(insertVal);
                if (result)
                {
                    MessageBox.Show("Item already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = null;
                    return;
                }

                SetIndexes(length, ref _graphObject);
                db1.Insert(insertVal);
                db1.printTable(ref _graphObject);

                textBox1.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (rdBtnSeperate.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                bool result = desperate.Searchy(insertVal, table);

                SetIndexes(length, ref _graphObject);
                desperate.printTable(table, ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                desperate.printTable(table, ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnLineer.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }

                bool result = lin1.Search(insertVal);

                SetIndexes(length, ref _graphObject);
                lin1.printTable(ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lin1.printTable(ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnQuad.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }


                bool result = quad1.Search(insertVal);

                SetIndexes(length, ref _graphObject);
                quad1.printTable(ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                quad1.printTable(ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnDouble.Checked)
            {
                if (!MessageBoxes(3)) return;

                int insertVal = Convert.ToInt32(textBox3.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = null;
                    return;
                }


                bool result = db1.Search(insertVal);

                SetIndexes(length, ref _graphObject);
                db1.printTable(ref _graphObject);

                if (result)
                {
                    _graphObject.FindNode(insertVal.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    _graphObject.FindNode(insertVal.ToString()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db1.printTable(ref _graphObject);

                textBox3.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (rdBtnSeperate.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }


                SetIndexes(length, ref _graphObject);
                bool result = desperate.Searchy(insertVal, table);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }
                desperate.Deletey(insertVal, table);


                desperate.printTable(table, ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnLineer.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }


                SetIndexes(length, ref _graphObject);
                bool result = lin1.Search(insertVal);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }
                lin1.Delete(insertVal);

                lin1.printTable(ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnQuad.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }

                SetIndexes(length, ref _graphObject);

                bool result = quad1.Search(insertVal);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }
                quad1.Delete(insertVal);

                quad1.printTable(ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
            else if (rdBtnDouble.Checked)
            {
                if (!MessageBoxes(2)) return;

                int insertVal = Convert.ToInt32(textBox2.Text);

                if (!(insertVal >= 0))
                {
                    MessageBox.Show("Do not enter negative numbers, okay?", "Promise me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = null;
                    return;
                }

                SetIndexes(length, ref _graphObject);

                bool result = db1.Search(insertVal);
                if (!result)
                {
                    MessageBox.Show("Item does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db1.Delete(insertVal);

                db1.printTable(ref _graphObject);

                textBox2.Text = null;

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();
            }
        }
        private void btnPreviousStep_Click(object sender, EventArgs e)
        {

        }
    }
}