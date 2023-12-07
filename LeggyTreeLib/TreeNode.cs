using System.Collections;

namespace LeggyTreeLib
{
    public class TreeNode<T> : ITreeNode<T>
    {
        public List<ITreeNode<T>> children => throw new NotImplementedException();

        public ITreeNode<T>? parent => throw new NotImplementedException();

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
