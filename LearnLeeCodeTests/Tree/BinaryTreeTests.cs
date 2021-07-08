using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnLeeCode.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnLeeCode.Tree.Tests
{
    [TestClass()]
    public class BinaryTreeTests
    {
        [TestMethod()]
        public void InsertLeftTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TestBuildCompleteBinaryTree()
        {
            var data = Enumerable.Range(10, 20).ToList();
            data.AddRange(Enumerable.Range(100, 30));
            Assert.AreEqual(data.Count, 50);
            if (data != null && data.Count > 0)
            {
                BinaryTree<int> binaryTree = new BinaryTree<int>(data[0]);
                Queue<Node<int>> stackQueue = new Queue<Node<int>>();
                stackQueue.Enqueue(binaryTree.Head);
                int dataIndex = 1;
                while (stackQueue.Count > 0)
                { 
                    if(dataIndex >= data.Count)
                    {
                        break;
                    }
                    var targetNode = stackQueue.Dequeue();
                    var leftNode = binaryTree.InsertLeft(data[dataIndex], targetNode);
                    stackQueue.Enqueue(leftNode);

                    if (dataIndex + 1 >= data.Count)
                    {
                        break;
                    }
                    var rightNode = binaryTree.InsertRight(data[dataIndex + 1], targetNode);
                    stackQueue.Enqueue(rightNode);
                    dataIndex += 2;
                }
                Assert.AreEqual(binaryTree.Head.Data, 10);
            }
        }
    }
}