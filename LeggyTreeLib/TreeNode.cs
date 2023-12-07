using System.Collections;
using System.Net.Http.Headers;

namespace LeggyTreeLib
{
    public class TreeNode<T> : ITreeNode<T>
    {
        protected List<ITreeNode<T>> _children;
        public ITreeNode<T>[] Children 
        {
            get
            {
                return _children.ToArray();
            }
        }

        protected ITreeNode<T> _parent;
        public ITreeNode<T>? Parent => throw new NotImplementedException();
        protected T _value;
        public T Value => throw new NotImplementedException();

        public TreeNode(T value)
        {
            _value = value;
        }

        public TreeNode(T value, ITreeNode<T> parent)
        {
            _value = value;
            _parent = parent;
        }

        public void AddChild(T child)
        {
            _children.Add(new TreeNode<T>(child));
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
