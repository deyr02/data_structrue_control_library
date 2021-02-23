using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_lib
{
    ///<Summary>Node
    ///this object is being used to hold the data for queue and  linked list and  the reference for the next node
    ///</Summary>
    public class Node
    {
        ///<Summary> Method; Data
         /// this method is used to get the data and set the data in the node
         ///</Summary>
        public int Data { get; set; }




        ///<Summary> method: Next
        /// this method is used to get nede reference and set the node reference
        ///</Summary>
        public Node Next { get; set; }



        ///<Summary> Method: Node
        /// this is the constructor method of this class 
        ///</Summary>
        public Node()
        {

        }

    }
}
