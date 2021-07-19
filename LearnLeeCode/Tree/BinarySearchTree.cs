using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Tree
{
    //This BST does not support duplicate keys
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private BinaryTree<T> underlyingTree = new BinaryTree<T>();

        public BinarySearchTree()
        { 
        }

        public BinarySearchTree(T data)
        {
            underlyingTree = new BinaryTree<T>(data);
        }

        public T MaxValue()
        {
            if (underlyingTree != null && underlyingTree.Head != null)
            {
                throw new NullReferenceException("tree is null");
            }
            var currentNode = underlyingTree.Head;
            Queue<Node<T>> nodeQueue = new Queue<Node<T>>();
            nodeQueue.Enqueue(underlyingTree.Head);
            while (nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();
                if (currentNode.RightNode != null)
                {
                    nodeQueue.Enqueue(currentNode.RightNode);
                }
            }
            return currentNode.Data;
        }

        public T MinValue()
        {
            if (underlyingTree != null && underlyingTree.Head != null)
            {
                throw new NullReferenceException("tree is null");
            }
            var currentNode = underlyingTree.Head;
            Queue<Node<T>> nodeQueue = new Queue<Node<T>>();
            nodeQueue.Enqueue(underlyingTree.Head);
            while (nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();
                if (currentNode.LeftNode != null)
                {
                    nodeQueue.Enqueue(currentNode.LeftNode);
                }
            }
            return currentNode.Data;
        }

        public bool IsExist(T data)
        {
            var result = false;
            Queue<Node<T>> nodeQueue = new Queue<Node<T>>();
            nodeQueue.Enqueue(underlyingTree.Head);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                var compareResult = currentNode.Data.CompareTo(data);
                if (compareResult == 0)
                {
                    result = true;
                    break;
                }
                else if (compareResult > 0 && currentNode.LeftNode != null)
                {
                    nodeQueue.Enqueue(currentNode.LeftNode);
                }
                else if (compareResult < 0 && currentNode.RightNode != null)
                {
                    nodeQueue.Enqueue(currentNode.RightNode);
                }
            }
            return result;
        }

        public bool Insert(T data)
        {
            if (underlyingTree == null || underlyingTree.Head == null)
            {
                underlyingTree = new BinaryTree<T>(data);
                return true;
            }
            var currentNode = underlyingTree.Head;
            var compareResult = 0;
            Queue<Node<T>> nodeQueue = new Queue<Node<T>>();
            nodeQueue.Enqueue(underlyingTree.Head);
            while (nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();
                compareResult = currentNode.Data.CompareTo(data);
                if (compareResult == 0)   //already existing
                {
                    return false;
                }
                else if (compareResult < 0 && currentNode.RightNode != null) //current node is less than the target value
                {
                    nodeQueue.Enqueue(currentNode.RightNode);
                }
                else if (compareResult > 0 && currentNode.LeftNode != null)//current node is great than the target value
                {
                    nodeQueue.Enqueue(currentNode.LeftNode);
                }
            }
            compareResult = currentNode.Data.CompareTo(data);
            if (compareResult < 0)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.RightNode = currentNode;
                newNode.Parent = currentNode.Parent;
                currentNode.Parent.RightNode = newNode;
                currentNode.Parent = newNode;
            }  else if (compareResult > 0)
            {
                underlyingTree.InsertLeft(data, currentNode);
            }
            return true;
        }
    }
}
