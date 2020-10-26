using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            //declaring the object of binary search tree
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            //adding the values in binary search tree
            binarySearchTree.InsertDataInBST(23);
            binarySearchTree.InsertDataInBST(344);
            binarySearchTree.InsertDataInBST(43);
            binarySearchTree.InsertDataInBST(266);
            //returning node of root element after last element is inserted in the node
            Node<int> head= binarySearchTree.InsertDataInBST(232);

            //displaying values of node is sorted order
            binarySearchTree.DisplayDatainBST();
            //count left and right nodes in binary search tree
            binarySearchTree.CountOfNodes();
            //search for the value in binary search tree
            //root element obtained from the insert data and search value is passed to method 
            binarySearchTree.SearchInBST(head,232);
        }
    }
}
