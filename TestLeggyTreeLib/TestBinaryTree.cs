using LeggyTreeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeggyTreeLib
{
    [TestClass]
    public class TestBinaryTree
    {
        [TestMethod]
        public void TestNumberInRightPlaceLeft()
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);
            Assert.AreEqual(1, tree.root.Left.Left.Value);
        }

        [TestMethod]
        public void TestNumberInRightPlaceRight()
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            Assert.AreEqual(5, tree.root.Right.Right.Value);
        }
        [TestMethod]
        public void TestNumberInRightPlaceScattered()
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(3);
            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(4);
            Assert.AreEqual(4, tree.root.Right.Left.Value);
        }
    }
}
