using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp.Classes
{
    /// <summary>
    /// NB: Doesnt store the actual data 
    /// Graph deals with the connections between nodes.
    /// Storing their neighboring nodes.
    /// Making it easier to find related requests
    /// </summary>
    public class Graph
    {
        // Points to a requests neighbours using the request id
        private Dictionary<int, HashSet<ServiceRequest>> myRequest;
        
        //Constructor builds the dictionary
        public Graph()
        {
           myRequest = new Dictionary<int, HashSet<ServiceRequest>>();
        }

        //---------------------------------------------------------------------------//
        //Add request to the dictionary
        public void AddRequest(ServiceRequest request)
        {
            //Check if request id in dictionary
            if(myRequest.ContainsKey(request.RequestID) == false)
            {
                //Ensures each request has a hashset to store neighboring requests
                myRequest.Add(request.RequestID, new HashSet<ServiceRequest>());
            }
        }

        //---------------------------------------------------------------------------//
        //Link two requests together (edge creation)
        public void CreateRelationship(ServiceRequest start, ServiceRequest end)
        {
            //check if requests exits already
            if(myRequest.ContainsKey(start.RequestID) && myRequest.ContainsKey(end.RequestID))
            {
                //Add respective nodes in hashset making them neibours to one another 
                myRequest[start.RequestID].Add(end);
                myRequest[end.RequestID].Add(start);
            }
            else if (myRequest.ContainsKey(start.RequestID) == false)
            {
               AddRequest(start);
            }
            else { AddRequest(end); }
        }

        //---------------------------------------------------------------------------//
        //Get all the neighbors of a request (return hashest of appropriate entry)
        public HashSet<ServiceRequest> GetNeighbors(ServiceRequest request)
        {
            //Check if request id in dictionary
            if (myRequest.ContainsKey(request.RequestID) == true)
            {
                return myRequest[request.RequestID];
            }
            //If not found return null
            return null;
        }
        
    }//--------------------------End Of Class-------------------------------------------------//    
    
}//------------------------------End of Namespace---------------------------------------------//
