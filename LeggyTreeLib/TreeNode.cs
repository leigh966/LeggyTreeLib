using System.Collections;

namespace LeggyTreeLib
{
    public class TreeNode<T> : ITreeNode<T>
    {
        protected List<ITreeNode<T>> _children;
        public List<ITreeNode<T>> Children => throw new NotImplementedException();

        public ITreeNode<T>? Parent => throw new NotImplementedException();

        public void AddChild(T child)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
