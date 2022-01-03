using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMCClient
{
    class Node
    {
        private string data;
        private Node left;
        private Node right;

        #region Constructors
        public Node(string data)
        {
            this.data = data;
        }
        #endregion

        #region AccessorMethods
        public string GetData()
        {
            return data;
        }

        public void SetData(string data)
        {
            this.data = data;
        }

        public Node GetLeft()
        {
            return left;
        }

        public void SetLeft(Node newLeft)
        {
            this.left = newLeft;
        }

        public Node GetRight()
        {
            return right;
        }

        public void SetRight(Node newRight)
        {
            this.right = newRight;
        }

        #endregion
    }
}
