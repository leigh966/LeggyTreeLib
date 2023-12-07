using LeggyTreeLib;

namespace TestLeggyTreeLib
{
    [TestClass]
    public class TestTreeNode
    {
        [TestMethod]
        public void TestAddChildren()
        {
            ITreeNode<int> parent = new TreeNode<int>(0);
            parent.AddChild(1);
            Assert.AreEqual(1, parent.Children[0].Value);
        }
        [TestMethod]
        public void TestParentsAreEqual()
        {
            ITreeNode<int> parent = new TreeNode<int>(0);
            parent.AddChild(1);
            Assert.AreEqual(parent, parent.Children[0].Parent);
        }
        [TestMethod]
        public void TestRemoveChild()
        {
            ITreeNode<int> parent = new TreeNode<int>(0);
            parent.AddChild(1);
            Assert.IsFalse(parent.RemoveChild(parent));
            var child = parent.Children[0];
            Assert.IsTrue(parent.RemoveChild(child));
            Assert.IsFalse(parent.RemoveChild(child));
            Assert.AreEqual(0, parent.Children.Length);
        }
    }
}