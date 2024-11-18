using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp.Classes
{
    /// <summary>
    /// Each node is a box of data that contains a Service Request Object.
    /// With 2 pointers pointing to other boxes with their own Service Request Objects.(chain like system)
    /// The left node contains a Service Request Object with a RequestID less than the parent node.
    /// The right node contains a Service Request Object with a RequestID greater than the parent node.
    /// These pointers are null if there is no child node.
    /// By using this system, we can easily search for a Service Request Object by its RequestID.
    /// 
    /// Data: The Service Request Object
    /// 
    /// Left: A pointer to the child node on the left
    /// 
    /// Right: A pointer to the child node on the right
    /// 
    /// Height:Number of edges from node to the deepest leaf
    /// </summary>
    public class Node
    {
       public Issue Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Height { get; set; }

        public Node(Issue theData)
        {
            Data = theData;
            Height = 1;
        }
        
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
