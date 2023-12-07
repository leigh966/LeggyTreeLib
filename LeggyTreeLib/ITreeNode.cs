using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeggyTreeLib
{
    public interface ITreeNode<T> : IEnumerable<T>
    {
        public List<ITreeNode<T>> children { get; }
        public ITreeNode<T>? parent { get; }
        public void AddChild(T child);

    }
}
