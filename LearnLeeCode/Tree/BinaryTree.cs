using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Tree
{
    public class BinaryTree<T>
    {
        public BinaryTree()
        { 
        }

        public BinaryTree(T data)
        {
            this.Head = new Node<T>(data);
        }

        public Node<T> Head { get; set; }

        public Node<T> Root
        {
            get { return Head; }
            set { this.Head = value; }
        }

        public Node<T> InsertLeft(T data, Node<T> target)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.LeftNode = target.LeftNode;
            newNode.Parent = target;
            target.LeftNode = newNode;
            return newNode;
        }

        public Node<T> InsertRight(T data, Node<T> target)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.RightNode = target.RightNode;
            newNode.Parent = target;
            target.RightNode = newNode;
            return newNode;
        }

        public Node<T> DeleteLeft(Node<T> target)
        {
            if (target == null || target.LeftNode == null)
            {
                return null;
            }
            var result = target.LeftNode;
            result.Parent = null;
            target.LeftNode = null;
            return result;
        }

        public Node<T> DeleteRight(Node<T> target)
        {
            if (target == null || target.RightNode == null)
            {
                return null;
            }
            var result = target.RightNode;
            result.Parent = null;
            target.RightNode = null;
            return result;
        }

        public void PreOder(Node<T> root, Action<T> handler)
        {
            if (root == null)
            {
                return;
            }
            handler?.Invoke(root.Data);
            PreOder(root.LeftNode, handler);
            PreOder(root.RightNode, handler);
        }

        public void InOder(Node<T> root, Action<T> handler)
        {
            if (root == null)
            {
                return;
            }
            InOder(root.LeftNode, handler);
            handler?.Invoke(root.Data);
            InOder(root.RightNode, handler);
        }

        public void PostOder(Node<T> root, Action<T> handler)
        {
            if (root == null)
            {
                return;
            }
            PostOder(root.LeftNode, handler);
            PostOder(root.RightNode, handler);
            handler?.Invoke(root.Data);
        }

        public void LevelOrder(Action<T> handler)
        {
            if (Head == null)
            {
                return;
            }
            Queue<Node<T>> nodeQueue = new Queue<Node<T>>();
            nodeQueue.Enqueue(Head);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                handler?.Invoke(node.Data);
                if (node.LeftNode != null)
                {
                    nodeQueue.Enqueue(node.LeftNode);
                }
                if (node.RightNode != null)
                {
                    nodeQueue.Enqueue(node.RightNode);
                }
            }
        }
    }
}
