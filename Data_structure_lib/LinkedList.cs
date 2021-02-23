using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_lib
{
    public class LinkedList
    {
        private Node Head;
        private int Counter;
        ///<Summary> method : LinkeList
        ///This the constructer of the class
        ///the constructer creates a node as head of the linked list
        ///the head of the list does not contain any value, it is refer to the first item in the list
        ///
        ///</Summary>
        public LinkedList()
        {
            Head = new Node();
        }
        ///<Summary> method : Add
        ///This function is being used to add the value in the list
        ///first the function check whether the list is empty or not
        ///if the list is empty then the function add the item after head object
        ///if not loop through the list and add it at the last
        ///</Summary>
        public void Add(int data)
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
        ///<Summary> method : removeAt
        ///this function is being used to delete item from the list according to index number provided
        ///if the list is empty thow exception
        ///
        ///</Summary>
        public void removeAt(int Index)
        {
            if (Counter == 0)
            {
                throw new InvalidOperationException("list is Empty");
            }
            else if (Counter-1 < Index)
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
        ///<Summary> method : get
        ///this function helps to get the particular node object according to the  index number
        ///if list is empty the function will throw an exception
        ///if not return the node object
        ///</Summary>
        public int get(int Index)
        {
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
        ///<Summary> method : getCounter
        ///this function is being used to get the size of the list
        ///</Summary>
        public int getCounter()
        {
            return this.Counter;
        }
    }
}
