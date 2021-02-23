using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_lib
{
    class Stack_Controller
    {
        private ctlStack theInterface;
        private Stack myStack;
        ///<Summary> method : Stack_controller
        ///Constructor for the contorller class
        ///Refer to interface
        ///create a stack object
        ///</Summary>

        public Stack_Controller(ctlStack newInterface)
        {
            theInterface = newInterface;
            myStack = new Stack();
            
        }
        ///<Summary> method : addtoStack
        /// add the value to the particular stack
        ///</Summary>
        public void addToStack( int value)
        {
            myStack.Push(value);
        }



        ///<Summary> method : RemovefromStack
        ///remove item from the particular stack
        ///</Summary>

        public void RemoveFromStack()
        {
            myStack.Pop();
        }


        ///<Summary> method : getStackCounter
        ///this method is being used to get the size of the stack from the stack object
        ///retun the  integer value
        ///</Summary>

        public int getStackCounter()
        {
            return myStack.get_stack_size();
        }

        ///<Summary> method : getStackTop
        ///the function get the value of stack top form the stack class 
        ///Retun the value
        ///</Summary>

        public int getStackTop()
        {
            return myStack.get_Top_Value();
        }
        
        

    }
}
