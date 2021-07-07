using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Tree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }

        public Node(T data, Node<T> parent, Node<T> leftNode, Node<T> rightNode)
        {
            this.Data = data;
            this.Parent = parent;
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
        }

        public Node(Node<T> parent, Node<T> leftNode, Node<T> rightNode)
            : this(default(T), parent, leftNode, rightNode)
        { 
        }

        public Node(T data)
        {
            this.Data = data;
        }

        public Node()
        { 
        }
    }
}
