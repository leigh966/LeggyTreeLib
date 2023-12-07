using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeggyTreeLib
{
    public class BinaryTree
    {
        private BinaryNode? root = null;

        public bool Contains(int value)
        {
            if (root == null)
            {
                return false;
            }
            return root.CanFind(value)!=null;
        }

        public void Insert(int value)
        {
            if(root == null)
            {
                root = new BinaryNode(value);
                return;
            }
            root.AddChild(value);
        }
    }
}
