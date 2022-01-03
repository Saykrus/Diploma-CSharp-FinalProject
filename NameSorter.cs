using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMCClient
{
    public partial class NameSorter : Form
    {
        public NameSorter()
        {
            InitializeComponent();
            StatusStripText.Text = "Welcome";
        }

        AVLTree namesTree = new AVLTree();

        private void AddNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextboxInput.Text.Length > 1)
                {
                    namesTree.Add(TextboxInput.Text);
                    StatusStripText.Text = TextboxInput.Text + " added to tree.";
                    TextboxInput.Clear();
                    Display();
                }
                else
                {
                    StatusStripText.Text = "Please enter a name to add";
                }
            }
            catch
            {

            }
        }

        private void RemoveNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextboxInput.Text.Length > 1)
                {
                    namesTree.Delete(TextboxInput.Text);
                    StatusStripText.Text = TextboxInput.Text + " removed from tree.";
                    TextboxInput.Clear();
                    Display();
                }
                else
                {
                    StatusStripText.Text = "Please enter a name to remove";
                }

            }
            catch
            {

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (TextboxInput.Text.Length > 1)
            {
                StatusStripText.Text = namesTree.Find(TextboxInput.Text);
                TextboxInput.Clear();
            }
            else
            {
                StatusStripText.Text = "Please enter a name to search";
            }
        }

        private void PreFillButton_Click(object sender, EventArgs e)
        {
            namesTree.Add("Alphonse");
            namesTree.Add("Zubu");
            namesTree.Add("Ben");
            namesTree.Add("Yasmin");
            namesTree.Add("Charlie");
            namesTree.Add("Xavier");
            namesTree.Add("Dennis");
            namesTree.Add("Willow");
            namesTree.Add("Elvis");
            namesTree.Add("Vicky");
            namesTree.Add("Frank");
            namesTree.Add("Ulysses");
            namesTree.Add("Greg");
            namesTree.Add("Tasha");
            namesTree.Add("Harry");
            namesTree.Add("Sarah");
            namesTree.Add("Indi");
            namesTree.Add("River");
            namesTree.Add("Juliet");
            namesTree.Add("Quinella");
            namesTree.Add("Krystal");
            namesTree.Add("Penelope");
            namesTree.Add("Luna");
            namesTree.Add("Oscar");
            namesTree.Add("Mike");
            namesTree.Add("Nigel");
            Display();
        }

        private void Display() //TO BE FIXED HERE: NULL REFERENCE EXCEPTION AS STATED IN HEADER
        {
            //Root Level
            if (namesTree.GetRoot() != null)
                RootNode.Text = namesTree.GetRoot().GetData();
            //Sub 1 Level
            if (namesTree.GetRoot().GetLeft() != null)
                NodeL.Text = namesTree.GetRoot().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight() != null)
                NodeR.Text = namesTree.GetRoot().GetRight().GetData();
            //Sub 2 Level
            if (namesTree.GetRoot().GetLeft().GetLeft() != null)
                NodeLL.Text = namesTree.GetRoot().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight() != null)
                NodeLR.Text = namesTree.GetRoot().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft() != null)
                NodeRL.Text = namesTree.GetRoot().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetRight() != null)
                NodeRR.Text = namesTree.GetRoot().GetRight().GetRight().GetData();
            //Sub 3 Level
            if (namesTree.GetRoot().GetLeft().GetLeft().GetLeft() != null)
                NodeLLL.Text = namesTree.GetRoot().GetLeft().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetLeft().GetRight() != null)
                NodeLLR.Text = namesTree.GetRoot().GetLeft().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight().GetLeft() != null)
                NodeLRL.Text = namesTree.GetRoot().GetLeft().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight().GetRight() != null)
                NodeLRR.Text = namesTree.GetRoot().GetLeft().GetRight().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft().GetLeft() != null)
                NodeRLL.Text = namesTree.GetRoot().GetRight().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft().GetRight() != null)
                NodeRLR.Text = namesTree.GetRoot().GetRight().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetRight().GetLeft() != null)
                NodeRRL.Text = namesTree.GetRoot().GetRight().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetRight().GetRight() != null)
                NodeRRR.Text = namesTree.GetRoot().GetRight().GetRight().GetRight().GetData();
            //Sub 4 Level
            if (namesTree.GetRoot().GetLeft().GetLeft().GetLeft().GetLeft() != null)
                NodeLLLL.Text = namesTree.GetRoot().GetLeft().GetLeft().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetLeft().GetLeft().GetRight() != null)
                NodeLLLR.Text = namesTree.GetRoot().GetLeft().GetLeft().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetLeft().GetLeft().GetRight().GetLeft() != null)
                NodeLLRL.Text = namesTree.GetRoot().GetLeft().GetLeft().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetLeft().GetRight().GetRight() != null)
                NodeLLRR.Text = namesTree.GetRoot().GetLeft().GetLeft().GetRight().GetRight().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight().GetLeft().GetLeft() != null)
                NodeLRLL.Text = namesTree.GetRoot().GetLeft().GetRight().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight().GetLeft().GetRight() != null)
                NodeLRLR.Text = namesTree.GetRoot().GetLeft().GetRight().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight().GetRight().GetLeft() != null)
                NodeLRRL.Text = namesTree.GetRoot().GetLeft().GetRight().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetLeft().GetRight().GetRight().GetRight() != null)
                NodeLRRR.Text = namesTree.GetRoot().GetLeft().GetRight().GetRight().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft().GetLeft().GetLeft() != null)
                NodeRLLL.Text = namesTree.GetRoot().GetRight().GetLeft().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft().GetLeft().GetRight() != null)
                NodeRLLR.Text = namesTree.GetRoot().GetRight().GetLeft().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft().GetRight().GetLeft() != null)
                NodeRRLR.Text = namesTree.GetRoot().GetRight().GetLeft().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetLeft().GetRight().GetRight() != null)
                NodeRLRR.Text = namesTree.GetRoot().GetRight().GetLeft().GetRight().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetRight().GetLeft().GetLeft() != null)
                NodeRRLL.Text = namesTree.GetRoot().GetRight().GetRight().GetLeft().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetRight().GetLeft().GetRight() != null)
                NodeRRLR.Text = namesTree.GetRoot().GetRight().GetRight().GetLeft().GetRight().GetData();
            if (namesTree.GetRoot().GetRight().GetRight().GetRight().GetLeft() != null)
                NodeRRRL.Text = namesTree.GetRoot().GetRight().GetRight().GetRight().GetLeft().GetData();
            if (namesTree.GetRoot().GetRight().GetRight().GetRight().GetRight() != null)
                NodeRRRR.Text = namesTree.GetRoot().GetRight().GetRight().GetRight().GetRight().GetData();
        }
    }
}
