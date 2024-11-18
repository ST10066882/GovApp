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
        public void Insert(Issue request) 
        {
            if (Root == null)
            {
                Root = new Node(request);
                return;
            }
            InsertAVL2(Root, request);
        }
       
        //---------------------------------------------------------------------------//
        //Safe entry point for the search method
        public Issue Search(string searchValue)
        {
            Issue result = SearchTraversal(Root, searchValue);
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
        private Issue SearchTraversal(Node node, string searchValue)
        {
            // Indicates that the request is not found
            if (node == null)
            {
                return null;
            }
            // Compare descriptions lexicographically
            int comparison = string.Compare(searchValue, node.Data.Location, StringComparison.OrdinalIgnoreCase);

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


        private Node InsertAVL(Node node, Issue request)
        {
            if (node == null) return new Node(request);

            // Compare RequestName lexicographically
            if (string.Compare(request.Location, node.Data.Location) < 0)
                node.Left = InsertAVL(node.Left, request);
            else if (string.Compare(request.Location, node.Data.Location) > 0)
                node.Right = InsertAVL(node.Right, request);
            else
                return node; // Duplicate names are not allowed

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

            int balance = GetBalanceFactor(node);

            // Left Heavy
            if (balance > 1 && string.Compare(request.Location, node.Left.Data.Location) < 0)
                return RotateRight(node);

            // Right Heavy
            if (balance < -1 && string.Compare(request.Location, node.Right.Data.Location) > 0)
                return RotateLeft(node);

            // Left-Right
            if (balance > 1 && string.Compare(request.Location, node.Left.Data.Location) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right-Left
            if (balance < -1 && string.Compare(request.Location, node.Right.Data.Location) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        private Node InsertAVL2(Node node, Issue request)
        {
            // Ensure the request is valid
            if (request == null || string.IsNullOrEmpty(request.Location))
                throw new ArgumentException("Issue or Location cannot be null or empty.");

            // Base case: Insert new node
            if (node == null)
                return new Node(request);

            // Perform lexicographical comparison (case-insensitive)
            int comparison = string.Compare(request.Location, node.Data.Location, StringComparison.OrdinalIgnoreCase);

            if (comparison < 0)
            {
                // Insert in the left subtree
                node.Left = InsertAVL2(node.Left, request);
            }
            else if (comparison > 0)
            {
                // Insert in the right subtree
                node.Right = InsertAVL2(node.Right, request);
            }
            else
            {
                // Duplicate location detected
                Console.WriteLine($"Duplicate location: {request.Location}");
                return node; // Do nothing for duplicates
            }

            // Update the height of the current node
            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

            // Check balance factor and perform rotations if necessary
            int balance = GetBalanceFactor(node);

            // Left-Left Case
            if (balance > 1 && string.Compare(request.Location, node.Left.Data.Location, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Console.WriteLine($"Left-Left case at node: {node.Data.Location}");
                return RotateRight(node);
            }

            // Right-Right Case
            if (balance < -1 && string.Compare(request.Location, node.Right.Data.Location, StringComparison.OrdinalIgnoreCase) > 0)
            {
                Console.WriteLine($"Right-Right case at node: {node.Data.Location}");
                return RotateLeft(node);
            }

            // Left-Right Case
            if (balance > 1 && string.Compare(request.Location, node.Left.Data.Location, StringComparison.OrdinalIgnoreCase) > 0)
            {
                Console.WriteLine($"Left-Right case at node: {node.Data.Location}");
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right-Left Case
            if (balance < -1 && string.Compare(request.Location, node.Right.Data.Location, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Console.WriteLine($"Right-Left case at node: {node.Data.Location}");
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }


        private void InOrderTraversal(Node node, Action<Issue> visit)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, visit);
            visit(node.Data); // Add the current node's data
            InOrderTraversal(node.Right, visit);
        }
        public HashSet<string> GetAllLocationsAsHashSet()
        {
            HashSet<string> issues = new HashSet<string>();
            InOrderTraversal(Root, location => issues.Add(location.Location));
            return issues;
        }


    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
