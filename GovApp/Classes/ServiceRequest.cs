using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp.Classes
{
    /// <summary>
    /// Blueprint on what it takes to make a Service Request
    /// </summary>
    public class ServiceRequest
    {
        // Attributes (Characteristics)
        public int RequestID { get; set; }
        public string RequestType { get; set; }
        public string RequestName { get; set; }
        public string RequestStatus { get; set; }
        public string RequestDate { get; set; }

        // Constructor (Builder)
        public ServiceRequest(int requestID, string requestType, string requestName, string requestStatus, string requestDate)
        {
            RequestID = requestID;
            RequestType = requestType;
            RequestName = requestName;
            RequestStatus = requestStatus;
            RequestDate = requestDate;
        }
       
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
