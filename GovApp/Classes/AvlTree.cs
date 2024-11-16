using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp.Classes
{
    public class AvlTree
    {
        //First node in the tree
        public Node Root { get; set; }

        //---------------------------------------------------------------------------//
        //Safe entry point for the insertion method
        public void Insert(ServiceRequest request) 
        {
            if (Root == null)
            {
                Root = new Node(request);
                return;
            }
            InsertAVL(Root, request);
        }
       
        //---------------------------------------------------------------------------//
        //Main insertion logic for the AVL Tree
        private Node InsertTraversal(Node node, ServiceRequest request)
        {
            if (node == null)
            {
                return new Node(request);
            }
            if (request.RequestID < node.Data.RequestID)
            {
               node.Left = InsertTraversal(node.Left, request);
            }else if (request.RequestID > node.Data.RequestID)
            {
                node.Right = InsertTraversal(node.Right, request);
            }
            else
            {
                MessageBox.Show("Duplicate RequestId in AVL Tree!");
            }
            
            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            return Balance(node);
        }

        //---------------------------------------------------------------------------//
        //Safe entry point for the search method
        public ServiceRequest Search(string searchValue)
        {
            ServiceRequest result = SearchTraversal(Root, searchValue);
            if (result == null) 
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        //---------------------------------------------------------------------------//
        // Search Logic for the AVL Tree
        private ServiceRequest SearchTraversal(Node node, string searchValue)
        {
            // Indicates that the request is not found
            if (node == null)
            {
                return null;
            }
            // Compare descriptions lexicographically
            int comparison = string.Compare(searchValue, node.Data.RequestName, StringComparison.OrdinalIgnoreCase);

            if (comparison < 0)
            {
                // Search left if description is smaller
                return SearchTraversal(node.Left, searchValue);
            }
            else if (comparison > 0)
            {
                // Search right if description is larger
                return SearchTraversal(node.Right, searchValue);
            }
            else
            {
                // Found the matching request
                return node.Data;
            }

        }

        //---------------------------------------------------------------------------//
        // Get the height of the node
        private int GetHeight(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return node.Height;
            }
        }

        //---------------------------------------------------------------------------//
        // Adjust height of the node
        private void UpdateHeight(Node node)
        {
            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);
            node.Height = Math.Max(leftHeight, rightHeight) + 1;
        }

        //---------------------------------------------------------------------------//
        // Determine the balance factor by subtracting subtrees heights
        private int GetBalanceFactor(Node node)
        {
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        //---------------------------------------------------------------------------//
        // Rotate node to the left creating a new sub root
        private Node RotateLeft(Node node)
        {
            Node newRoot = node.Right;
            node.Right = newRoot.Left;
            newRoot.Left = node;

            UpdateHeight(node);
            UpdateHeight(newRoot);

            return newRoot;
        }

        //---------------------------------------------------------------------------//
        // Rotate node to the right creating a new sub root
        private Node RotateRight(Node node)
        {
            Node newRoot = node.Left;
            node.Left = newRoot.Right;
            newRoot.Right = node;

            UpdateHeight(node);
            UpdateHeight(newRoot);

            return newRoot;
        }

        //---------------------------------------------------------------------------//
        // Balance the tree after insertion
        private Node Balance(Node node)
        {
            int balanceFactor = GetBalanceFactor(node);

            if (balanceFactor > 1) // Left heavy
            {
                if (GetBalanceFactor(node.Left) < 0)
                {
                    node.Left = RotateLeft(node.Left);
                }
                return RotateRight(node);
            }
            else if (balanceFactor < -1)
            {

                if (GetBalanceFactor(node.Right) > 0)
                {
                    node.Right = RotateRight(node.Right);
                }
                return RotateLeft(node);
            }
            return node;
        }


        private Node InsertAVL(Node node, ServiceRequest request)
        {
            if (node == null) return new Node(request);

            // Compare RequestName lexicographically
            if (string.Compare(request.RequestName, node.Data.RequestName) < 0)
                node.Left = InsertAVL(node.Left, request);
            else if (string.Compare(request.RequestName, node.Data.RequestName) > 0)
                node.Right = InsertAVL(node.Right, request);
            else
                return node; // Duplicate names are not allowed

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

            int balance = GetBalanceFactor(node);

            // Left Heavy
            if (balance > 1 && string.Compare(request.RequestName, node.Left.Data.RequestName) < 0)
                return RotateRight(node);

            // Right Heavy
            if (balance < -1 && string.Compare(request.RequestName, node.Right.Data.RequestName) > 0)
                return RotateLeft(node);

            // Left-Right
            if (balance > 1 && string.Compare(request.RequestName, node.Left.Data.RequestName) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right-Left
            if (balance < -1 && string.Compare(request.RequestName, node.Right.Data.RequestName) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }


    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
