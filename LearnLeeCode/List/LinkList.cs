using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.List
{
    public class LinkList<T> : IMyList<T>
    {
        public Node<T> Head { get; set; }

        public LinkList()
        { 
        }

        public T this[int i] 
        {
            get
            {
                return this.GetNode(i).Data;
            }
            set
            {
                this.GetNode(i).Data = value;
            }
        }

        public void Append(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this.Head == null)
            {
                this.Head = newNode;
                return;
            }

            Node<T> current = this.Head;
            if (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void Clear()
        {
            this.Head = null;
        }

        public T Delete(int i)
        {
            if (i == 0)
            {
                Node<T> current = this.Head;
                this.Head = null;
                return current.Data;
            }
            else
            {
                var previousNode = GetNode(i - 1);
                var node = previousNode.Next;
                previousNode.Next = node.Next;
                return node.Data;
            }
        }

        public int GetLength()
        {
            Node<T> p = this.Head;
            int length = 0;
            while (p != null)
            {
                p = p.Next;
                length++;
            }
            return length;
        }

        public void Insert(T item, int i)
        {
            Node<T> newNode = new Node<T>(item);
            Node<T> targetNode = this.GetNode(i);
            newNode.Next = targetNode.Next;
            targetNode.Next = newNode;
        }

        public bool IsEmpty()
        {
            return this.Head == null;
        }

        public int Locate(T value)
        {
            throw new NotImplementedException();
        }

        private Node<T> GetNode(int i)
        {
            if (i < 0)
            {
                throw new ArgumentException("i must be eqaul or greater than 0");
            }
            if (this.Head == null)
            {
                throw new NullReferenceException("this is null");
            }
            if (i == 0)
            {
                return this.Head;
            }
            else
            {
                Node<T> currentNode = this.Head;
                int currentCount = 1;
                while (currentCount <= i && currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    currentCount++;
                }
                if (currentCount == i + 1)
                {
                    return currentNode;
                }
                else
                {
                    throw new IndexOutOfRangeException("index is out of range");
                }
            }
        }
    }
}
