using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace course
{
    public partial class Form1 : Form
    {
        private Class.RBTree<Class.RBTreeNode<int, string>, int, string> tree;

        public Form1()
        {
            InitializeComponent();
            tree = new Class.RBTree<Class.RBTreeNode<int, string>, int, string>();
        }

        Bitmap bmpTemp = null;
        Bitmap bmp = null;
        Bitmap bmpTemp1 = null;
        Bitmap bmpTemp2 = null;
        Bitmap bmpTemp3 = null;
        Bitmap bmpTempbmp1 = null;
        bool rb5 = false, rb6 = false;
        public Bitmap getControlScreenshot(Control c)
        {
            Bitmap res = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(res, new Rectangle(Point.Empty, c.Size));
            return res;
        }
        private void AddToTreeView(Class.RBTreeNode<int, string> node, TreeNode tvNode)
        {
            if (node == null) return;

            TreeNode newtvNode;

            if (node.IsBlack)
            {
                newtvNode = new TreeNode("Key=" + node.Key.ToString() + " Color= Black");
                tvNode.Nodes.Add(newtvNode);
                AddToTreeView(node.Left, newtvNode);
                AddToTreeView(node.Right, newtvNode);
            }
            else
            {
                newtvNode = new TreeNode("Key=" + node.Key.ToString() + " Color= Red");
                tvNode.Nodes.Add(newtvNode);
                AddToTreeView(node.Left, newtvNode);
                AddToTreeView(node.Right, newtvNode);
            }
            //    i = (node.IsBlack ? 0 : 1);
            //newtvNode = new TreeNode("Key=" + node.Key.ToString() + "; Data=" + node.Data.ToString() + "; Count=" + node.Count, i, i);
            //tvNode.Nodes.Add(newtvNode);
            //AddToTreeView(node.Left, newtvNode);
            //AddToTreeView(node.Right, newtvNode);

        }

        private void ShowRBTree()
        {
            try
            {
                tvRB.Nodes.Clear();
                if (tree.Count == 0) return;

                string color;
                if (tree.Root.IsBlack)
                {
                    color = "black";
                    tvRB.Nodes.Add(tree.Root.Key.ToString(), "Key=" + tree.Root.Key.ToString() + "; Color= Black");
                    AddToTreeView(tree.Root.Left, tvRB.Nodes[0]);
                    AddToTreeView(tree.Root.Right, tvRB.Nodes[0]);
                }
                else
                {
                    color = "red";
                    tvRB.Nodes.Add(tree.Root.Key.ToString(), "Key=" + tree.Root.Key.ToString() + "; Color= Red");
                    AddToTreeView(tree.Root.Left, tvRB.Nodes[0]);
                    AddToTreeView(tree.Root.Right, tvRB.Nodes[0]);
                }


                //tvRB.Nodes.Add(tree.Root.Key.ToString(), "Key=" + tree.Root.Key.ToString() + "; Data=" + tree.Root.Data.ToString() + "; Count=" + tree.Root.Count, (tree.Root.IsBlack ? 0 : 1));
                //tvRB.Nodes.Add(tree.Root.Key.ToString(), "Key=" + tree.Root.Key.ToString() + "; Data=" + tree.Root.Data.ToString() + "; Count=" + tree.Root.Count, (tree.Root.IsBlack ? 0 : 1));
                //AddToTreeView(tree.Root.Left, tvRB.Nodes[0]);
                //AddToTreeView(tree.Root.Right, tvRB.Nodes[0]);

                tvRB.ExpandAll();

                if (bmpTemp != null)
                {
                    lbl_pictureLabel.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введенные данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Class.RBTreeNode<int, string> node;
            int key;
            string data;
            //for view picture

            try
            {
                key = Convert.ToInt32(nodeKey_txtBx.Text);
                data = nodeData_txtBx.Text.ToString();
                node = new Class.RBTreeNode<int, string>(key, data);
                tree.InsertNode(node);
                bmpTemp = bmp;
                bmpTemp1 = bmpTemp;
                bmpTemp2 = bmpTemp1;
                ShowRBTree();
                bmp = getControlScreenshot(tvRB);

                pictureBox1.Image = bmpTemp;
                pictureBox2.Image = bmpTemp;
                pictureBox3.Image = bmpTemp;
                //if (bmpTemp != null)
                //    counter++;
                //if (counter %2 != 0)
                //{
                //    bmpTemp1 = bmp1;

                //    ShowRBTree();
                //    bmp1 = getControlScreenshot(treeView1);

                //    pictureBox1.Image = bmpTemp1;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введенные данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_5_node_Click(object sender, EventArgs e)
        {
            Class.RBTreeNode<int, string> node;
            int i, k;
            Random rnd = new Random();

            for (i = 1; i <= 5; i++)
            {
                k = rnd.Next(100);
                node = new Class.RBTreeNode<int, string>(k, k.ToString());
                tree.InsertNode(node);
            }

            bmpTemp = bmp;
            ShowRBTree();
            bmp = getControlScreenshot(tvRB);

            pictureBox1.Image = bmpTemp;
        }

        private void del_Click(object sender, EventArgs e)
        {
            Class.RBTreeNode<int, string> node;
            int i, k;

            try { i = Convert.ToInt32(txtKey.Text); }
            catch { i = -1; }
            node = tree.Find(i, out k);
            if (k == 0)
            {
                tree.DeleteNode(node);
                bmpTemp = bmp;
                ShowRBTree();
                bmp = getControlScreenshot(tvRB);

                pictureBox1.Image = bmpTemp;

                MessageBox.Show("Элемент исключем " + node.Key + " удален!", "Удаление элемента", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else MessageBox.Show("Элемент ненайден!", "Удаление элемента", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Clr_Click(object sender, EventArgs e)
        {
            txtKey.Text = null;
            textBox3.Text = null;
            textBoxKey1.Text = null;
            textBoxData1.Text = null;
            textBoxNumber.Text = null;
            tree.Root = null;
            ShowRBTree();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            bmp = null;
            bmpTemp = null;
            bmpTemp1 = null;
            bmpTemp2 = null;
            lbl_pictureLabel.Visible = false;
        }

        private void find_Click(object sender, EventArgs e)
        {
            Class.RBTreeNode<int, string> node;
            int i, k;

            try
            {
                i = Convert.ToInt32(textBox3.Text);
                node = tree.Find(i, out k);
                if (k == 0)
                {
                    MessageBox.Show("Элемент с ключем " + node.Key + " найден!\nDATA = " + node.Data.ToString(), "Поиск элемента", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Элемент с ключем " + i + " не найден!", "Поиск элемента", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Элемент ненайден!", "Поиск элемента", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            groupBoxOne.Enabled = false;
            groupBoxMany.Enabled = true;
            groupBoxHelp.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            tree.Root = null;
            ShowRBTree();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            bmp = null;
            bmpTemp = null;
            lbl_pictureLabel.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 1000;
            this.Width = 1288;
            groupBoxOne.Enabled = true;
            groupBoxMany.Enabled = false;
            groupBoxHelp.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            tree.Root = null;
            ShowRBTree();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            bmp = null;
            bmpTemp = null;
            lbl_pictureLabel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb5 == false && rb6 == false)
                    MessageBox.Show("Не выбранно количество деревьев для показа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                {
                    int emountOfVertex = Convert.ToInt32(textBoxNumber.Text);
                    Class.RBTreeNode<int, string> node;
                    int i, k;
                    Random rnd = new Random();

                    for (i = 1; i <= emountOfVertex; i++)
                    {
                        k = rnd.Next(100);
                        node = new Class.RBTreeNode<int, string>(k, k.ToString());
                        tree.InsertNode(node);
                    }

                    //bmpTemp = bmp;
                    //ShowRBTree();
                    //bmp = getControlScreenshot(tvRB);
                    bmpTemp2 = bmpTemp1;
                    bmpTemp1 = bmpTemp;
                    bmpTemp = bmp;


                    ShowRBTree();
                    bmp = getControlScreenshot(tvRB);
                    pictureBox1.Image = bmpTemp;
                    pictureBox3.Image = bmpTemp2;
                    pictureBox2.Image = bmpTemp1;

                    pictureBox1.Image = bmpTemp;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введенные данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int counter = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Class.RBTreeNode<int, string> node;
            int key;
            string data;

            //for view picture
            try
            {
                if (rb5 == false && rb6 == false)
                    MessageBox.Show("Не выбранно количество деревьев для показа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                {

                    key = Convert.ToInt32(textBoxKey1.Text);
                    data = textBoxData1.Text.ToString();
                    node = new Class.RBTreeNode<int, string>(key, data);
                    tree.InsertNode(node);


                    //bmpTemp = bmp;

                    //ShowRBTree();
                    //bmp = getControlScreenshot(tvRB);
                    //pictureBox1.Image = bmpTemp;
                    bmpTemp2 = bmpTemp1;
                    bmpTemp1 = bmpTemp;
                    bmpTemp = bmp;


                    ShowRBTree();
                    bmp = getControlScreenshot(tvRB);
                    pictureBox1.Image = bmpTemp;
                    pictureBox3.Image = bmpTemp2;
                    pictureBox2.Image = bmpTemp1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введенные данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            rb5 = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            rb6 = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }
    }
}




