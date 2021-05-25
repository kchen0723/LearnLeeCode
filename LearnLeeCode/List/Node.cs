using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.List
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data, Node<T> next)
        {
            this.Data = data;
            this.Next = next;
        }

        public Node(T data)
            : this(data, null)
        { 
        }

        public Node(Node<T> next)
            : this(default(T), next)
        { 
        }

        public Node()
            : this(default(T), null)
        { 
        }
    }
}
