using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    /// <summary>
    /// Generic Binary search tree is defined
    /// Due to generic class, Icomparable method is defined to use CompareTo inside the program
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BinarySearchTree<T> where T : IComparable
    {
        //creating a object of Node class, called root which will save the first data coming from the user
        public Node<T> root;
        int leftNodeCount = 0;
        int rightNodeCount = 0;

        /// <summary>
        /// Inserting data in Binary Search Tree
        /// </summary>
        /// <param name="data">data to be entered in binary search tree</param>
        public void InsertDataInBST(T data) 
        {
            //Creating and instatiating node with data in constructor
            //now we have to point node to correct addresss so that condition of Binary search tree is satisfied
            Node<T> node = new Node<T>(data);

            //when there is no initial data and root is null, first value is added in root.
            if (root == null)
            {
                root = node;
            }
            else
            {
                //current position node is defined which have the value of root element.
                Node<T> currentPosition = root;
                //loop is instatiated to add value in binary search tree
                while (true)
                {
                    //current position is assigned to parent node
                    //this is done because parent node will contain the data of currentposition, where as current position will be changed
                    //to point to the left or right node 
                    //hence parent node with value of currentPosition(root) will be pointing to left or right to add a data in it.
                    Node<T> parent = currentPosition;
                    //when data is less than the data in root, currentPosition node will point to left direction
                    if (currentPosition.data.CompareTo(data) > 0)
                    {
                        currentPosition = currentPosition.left;
                        //if there is no node in it and value is null, as current position is now null
                        //parent node is used to point to left direction and add  node with data.
                        if (currentPosition == null)
                        {
                            parent.left = node;
                            break;
                        }
                    }
                    else
                    {
                        //when data is greater than right position, than root node will point to right direction
                        //address of right node is passed in current position and currentPosition is changed
                        //if right node is null, then parent node is used to assign value at right.
                        currentPosition = currentPosition.right;
                        if (currentPosition == null)
                        {
                            parent.right = node;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Displaying the data in binary search tree in sorted manner
        /// for displaying the data in sorted manner, printing should start from leftmost leaf node.
        /// </summary>
        public void DisplayDatainBST()
        {
            //parent node is defined and equalized to root, which helps in printing values when coming out of recursion in function
            Node<T> parent = root;
            //if pointer to left node is not null, then root is changed to left value, and parent node still represents root.
            //displaydatainBST is again called and root is changed to represent left node.
            //this recursion continues until left most node becomes null and value is printed for that particular parent node.
            if (root.left!=null)
            {
                leftNodeCount++;
                parent = root;
                root = root.left;
                DisplayDatainBST();
            }
            Console.WriteLine("Data in sorted manner from :\t" + parent.data);
            //after printing first value for which left node is null
            //it's parent node is checked to have right node, if right node is there, then root points to right node and again recursion is done
            //recursion again finds the leftmost null value and displays the node and process is repeated
            //if pointer has moved from leftmost to rightmost value, then process begins to come out of recursion
            //in that case for each value coming out of recursion, it's parent node is printed using parent node assigned value in if condition 
            //and checked for right node
            //for better understanding, do debugging again
            if(root.right!=null)
            {
                rightNodeCount++;
                root = root.right;
                DisplayDatainBST();
            }
        }
        /// <summary>
        /// Getting count of each left and right nodes
        /// </summary>
        public void CountOfNodes()
        {
            //variables are defined in  class for left node count and right node count
            //counters for each node are incremented when displaying the value.
            //when condition for left node is not null is called then left counter is incremented, otherwise right counter is incremented
            Console.WriteLine("Count for Left nodes are\t" + leftNodeCount);
            Console.WriteLine("Count for Right nodes are\t" +rightNodeCount);
        }

    }
}
