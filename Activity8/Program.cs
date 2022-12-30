using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_097
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /* A node class consist os three things, the information, refrrence to the right child, and refrence to the left child */

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /* Initializing ROOT to null*/

        }
        public void insert(string element) /* Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode =  null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("Duplicate word not allowed");
                return;
            }
            else /*If the spesified node is not present*/
            {
                tmp = new Node(element, null, null); /* Creates a Node*/
                if (parent ==null) /*if the tree is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }

            }
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /* This function searches the currentNode of the spesified Node as
             * well as the current Node of this parwnt */
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) &&(currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is Empty");
                return ;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
