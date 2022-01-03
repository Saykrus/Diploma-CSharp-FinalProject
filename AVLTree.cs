using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMCClient
{
    class AVLTree
    {
        private Node root;

        public Node GetRoot()
        {
            return root;
        }

        public void SetRoot(Node newRoot)
        {
            this.root = newRoot;
        }

        public void Add(string data)
        {
            Node newItem = new Node(data);
            if (GetRoot() == null)
            {
                SetRoot(newItem);
            }
            else
            {
                SetRoot(AddRecursive(GetRoot(), newItem));
            }
        }

        private Node AddRecursive(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (string.Compare(n.GetData(), current.GetData()) < 0)
            {
                current.SetLeft(AddRecursive(current.GetLeft(), n));
                current = Balance_Tree(current);
            }
            else if (string.Compare(n.GetData(), current.GetData()) > 0)
            {
                current.SetRight(AddRecursive(current.GetRight(), n));
                current = Balance_Tree(current);
            }
            return current;
        }

        public void Delete(string target)
        {
            SetRoot(DeleteNode(GetRoot(), target));
        }

        private Node DeleteNode(Node current, string target)
        {
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (string.Compare(target, current.GetData()) < 0)
                {
                    current.SetLeft(DeleteNode(current.GetLeft(), target));
                    if (Balance_Factor(current) == -2)//here
                    {
                        if (Balance_Factor(current.GetRight()) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (string.Compare(target, current.GetData()) > 0)
                {
                    current.SetRight(DeleteNode(current.GetRight(), target));
                    if (Balance_Factor(current) == 2)
                    {
                        if (Balance_Factor(current.GetLeft()) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.GetRight() != null)
                    {
                        //delete its inorder successor
                        parent = current.GetRight();
                        while (parent.GetLeft() != null)
                        {
                            parent = parent.GetLeft();
                        }
                        current.SetData(parent.GetData());
                        current.SetRight(DeleteNode(current.GetRight(), parent.GetData()));
                        if (Balance_Factor(current) == 2)//rebalancing
                        {
                            if (Balance_Factor(current.GetLeft()) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.GetLeft();
                    }
                }
            }
            return current;
        }

        private Node Balance_Tree(Node current)
        {
            int b_factor = Balance_Factor(current);
            if (b_factor > 1)
            {
                if (Balance_Factor(current.GetLeft()) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (Balance_Factor(current.GetRight()) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }

        private int Balance_Factor(Node current)
        {
            int l = GetHeight(current.GetLeft());
            int r = GetHeight(current.GetRight());
            int b_factor = l - r;
            return b_factor;
        }

        private Node RotateRR(Node parent)
        {
            Node pivot = parent.GetRight();
            parent.SetRight(pivot.GetLeft());
            pivot.SetLeft(parent);
            return pivot;
        }

        private Node RotateLL(Node parent)
        {
            Node pivot = parent.GetLeft();
            parent.SetLeft(pivot.GetRight());
            pivot.SetRight(parent);
            return pivot;
        }

        private Node RotateLR(Node parent)
        {
            Node pivot = parent.GetLeft();
            parent.SetLeft(RotateRR(pivot));
            return RotateLL(parent);
        }

        private Node RotateRL(Node parent)
        {
            Node pivot = parent.GetRight();
            parent.SetRight(RotateLL(pivot));
            return RotateRR(parent);
        }

        private int max(int l, int r)
        {
            return l > r ? l : r;
        }

        private int GetHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = GetHeight(current.GetLeft());
                int r = GetHeight(current.GetRight());
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }

        public String Find(string key)
        {
            try
            {
                if (FindRecursive(key, GetRoot()).GetData() == key)
                {
                    return key + " was found!";

                }
                else
                {
                    return key + " not found!";
                }
            }
            catch
            {
                return key + " not found!";
            }

        }

        private Node FindRecursive(string target, Node current)
        {
            try
            {
                if (string.Compare(target, current.GetData()) < 0)
                {
                    if (target == current.GetData())
                    {
                        return current;
                    }
                    else
                        return FindRecursive(target, current.GetLeft());
                }
                else
                {
                    if (target == current.GetData())
                    {
                        return current;
                    }
                    else
                        return FindRecursive(target, current.GetRight());
                }
            }
            catch
            {
                return null;
            }
        }

        //public string Display()
        //{
        //    if (GetRoot() == null)
        //    {
        //        return "Tree is empty";
        //    }else
        //    {
        //        return (DisplayInOrder(GetRoot()));
        //    }
        //}

        //private string DisplayInOrder(Node current)
        //{
        //    string s = "";
        //    if (current != null)
        //    {
        //        s = DisplayInOrder(current.GetLeft());
        //        //Console.Write("({0}) ", current.GetData());
        //        s += DisplayInOrder(current.GetRight());
        //        //Console.Write("({0}) ", current.GetData());
        //    }
        //    return s;
        //}

    }
}
