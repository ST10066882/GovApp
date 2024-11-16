using GovApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp.UserControls
{
    //Note double check recursion methods for infinite loop
    /// <summary>
    /// Logic for the Service Locator User Control
    /// handles the AVL tree and the graph
    /// </summary>
    public partial class ServiceLocator : UserControl
    {
        //Create a new AVL Tree
        AvlTree myTree = new AvlTree();

        //list used to store the names of the requests
        List<String> requestNames = new List<String>();

        //Constructor for user control (Builder)
        public ServiceLocator()
        {
            InitializeComponent();
            PopulateTree();
            PopulateListBox(myTree.Root);
            Graph myGraph = new Graph();
            //Start creating the graph from the root of my AVL tree
            CreateGraphFromTree(myTree.Root, myGraph);
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //---------------------------------------------------------------------------//
        // Code that runs when user selects a service request
        private void ServiceStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ensuring the user can see the request
            if (RequestArea.Visible == false)
            {
                RequestArea.Visible = true;
            }
            ClearLabels();
            if (ServiceStorage.SelectedItem == null)
            {
                MessageBox.Show("Not valid request" + requestNames.Count);
                return;
            }
            string selectedRequest = ServiceStorage.SelectedItem.ToString();

            ServiceRequest targetRequest = myTree.Search(selectedRequest);
            if (targetRequest != null)
            {
                RequestNameLbl.Text = targetRequest.RequestName;
                TypeData.Text = targetRequest.RequestType;
                StatusData.Text = targetRequest.RequestStatus;
                DateData.Text = targetRequest.RequestDate;
            }
            else
            {
                MessageBox.Show("Request not found!");
            }

        }

        //---------------------------------------------------------------------------//
        // Create and Populate Binary Search Tree
        private void PopulateTree()
        {
            List<ServiceRequest> requests = new List<ServiceRequest>
            {
                new ServiceRequest(1, "Maintenance", "Fix Water Leak", "Pending", "01/11/2024"),
                new ServiceRequest(2, "IT Support", "Update Drivers", "Completed", "05/11/2024"),
                new ServiceRequest(3, "Finance", "Budget Approval", "In Progress", "06/11/2024"),
                new ServiceRequest(4, "Legal", "Review Contract", "Pending", "07/11/2024"),
                new ServiceRequest(5, "Human Resources", "Employee Review", "Completed", "08/11/2024"),
                new ServiceRequest(6, "Maintenance", "Fix Broken Window", "In Progress", "09/11/2024"),
                new ServiceRequest(7, "IT Support", "Install Software", "Completed", "10/11/2024"),
                new ServiceRequest(8, "Finance", "Tax Return", "Pending", "11/11/2024"),
                new ServiceRequest(9, "Legal", "Client Negotiations", "In Progress", "12/11/2024"),
                new ServiceRequest(10, "Human Resources", "Hiring Process", "Completed", "13/11/2024")
            };

           for (int i = 0; i < requests.Count; i++)
           {
                myTree.Insert(requests[i]);
           }
            
        }

        //---------------------------------------------------------------------------//
        // Traverse the tree and create graph edges
        private void CreateGraphFromTree(Node node,Graph graph)
        {
            if (node == null)
            {
                return;
            }else if (node.Left != null)
            {
                // If there's a left child, create an relationship between node
                // and left
                graph.CreateRelationship(node.Data, node.Left.Data);
                CreateGraphFromTree(node.Left, graph);
            }
            else if(node.Right != null)
            {
                // If there's a right child, create an relationship between node
                // and right
                graph.CreateRelationship(node.Data, node.Right.Data);
                CreateGraphFromTree(node.Right, graph);
            }
        }

        //---------------------------------------------------------------------------//
        //Populate the list box with the names of the service requests
        private void PopulateListBox(Node node)
        {
            //Traverse the tree from the root
            GatherRequestsFromTree(myTree.Root);

            //Add the names to the list box
            for (int i = 0; i < requestNames.Count; i++)
            {
                ServiceStorage.Items.Add(requestNames[i]);
            }
        }

        //---------------------------------------------------------------------------//
        //Traverse the tree and gather the names of the service requests
        //Note : This method is recursive we want for it to be null
        private void GatherRequestsFromTree(Node node)
        {
            //Attempting to find left/right leaf node
            if (node == null)
            {
                return;
            }
            //If there is a left child, go left
            GatherRequestsFromTree(node.Left);

            //Add the name of the request to the list
            requestNames.Add(node.Data.RequestName);

            //If there is a right child, go right
            GatherRequestsFromTree(node.Right);
        }

        //---------------------------------------------------------------------------//
        //Clear all labels
        private void ClearLabels()
        {
            RequestNameLbl.Text = "";
            TypeData.Text = "";
            StatusData.Text = "";
            DateData.Text = "";
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
