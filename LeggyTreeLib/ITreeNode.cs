﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeggyTreeLib
{
    public interface ITreeNode<T> : IEnumerable<T>
    {
        public List<ITreeNode<T>> Children { get; }
        public ITreeNode<T>? Parent { get; }
        public T Value { get; }
        public void AddChild(T child);

    }
}
