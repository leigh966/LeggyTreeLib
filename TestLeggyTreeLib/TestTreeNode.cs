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
    }
}