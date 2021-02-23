using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_lib
{
    class Stack
    {
        ///<Summary>
        ///A list is being used to hodld tha values of the stack
        ///</Summary>
        int Counter;
        Node Head;

        ///<Summary>method: Stack
        /// this is constructor for the stack
        /// the constructor creat a list of Types
        ///</Summary>
        public Stack()
        {
            Head = new Node();
        }
        ///<Summary> Method: Push
        /// the method takes the value  and add the value in the list
        ///</Summary>
        public void Push(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;
            if (Head.Next == null)
            {
                Head.Next = newNode;

            }
            else
            {
                Node pCur = new Node();
                Node Ploc = Head.Next;
                for (int i = 0; i < Counter; i++)
                {
                    if (i == Counter - 1)
                    {
                        pCur = Ploc;
                        pCur.Next = newNode;
                        break;

                    }
                    Ploc = Ploc.Next;
                }


            }
            Counter++;

        }
       
        ///<Summary> Method: Pop
        /// this method is being used to remove value form the list according to Stock algoritham the last value form the list
        /// the method checks the counter if the counter  is less than 0 exception will occur
        ///  if  the size is not zero
        ///     get the last node of the stack 
        ///     remove form the stack 
        ///</Summary>
        public void Pop()
        {
            int Index = Counter - 1;
            if (Counter == 0)
            {
                throw new InvalidOperationException("list is Empty");
            }
            else if (Counter - 1 < Index)
            {
                throw new IndexOutOfRangeException("Index out of Range");
            }
            else
            {

                if (Index == 0)
                {
                    Node Pnext = Head.Next.Next;
                    Head.Next = Pnext;

                }
                else
                {
                    Node pLoc = Head.Next;
                    Node pCur = new Node();
                    Node pPre = new Node();
                    int C = 0;
                    while (pLoc != null)
                    {
                        if (C == Index)
                        {
                            pCur = pLoc;
                            pPre.Next = pCur.Next;
                            break;

                        }
                        ++C;
                        pPre = pLoc;
                        pLoc = pLoc.Next;
                    }


                }
                Counter = Counter - 1;
            }
            

        }
        ///<Summary> Method: get_top_value
        ///This function is being used to retrieve the top item of the stack
        /// first the fuction check for stack size if the stack is empty then an exception will occur
        /// If the stack is not empty
        ///    the function will return the value of last node which is stack top
        ///</Summary>
        public int get_Top_Value()
        {
            int Index = Counter - 1;
            int result = 0;
            if (Counter == 0)
            {
                throw new InvalidOperationException("list is Empty");
            }
            else if (Counter < Index)
            {
                throw new IndexOutOfRangeException("Index out of Range");
            }
            else
            {
                Node pLoc = Head.Next;

                int C = 0;
                while (pLoc != null)
                {
                    if (C == Index)
                    {
                        result = pLoc.Data;
                        break;

                    }
                    C++;
                    pLoc = pLoc.Next;
                }
            }
            return result;

           

        }

        ///<Summary> method : get_Stack_size()
        ///this method will retun value of the counter 
        ///</Summary>

        public int get_stack_size()
        {
            return Counter;
        }
    }
}
