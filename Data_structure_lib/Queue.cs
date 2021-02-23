using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_lib
{
    ///<Summary>
    /// This class construct the queue algorthams
    ///</Summary>
    public class Queue
    {
        ///<Summary>
        /// this class intialize two node object which is being used to set reference to the queue fornt and rear
        /// this alls intialize a counter to count the total number of node object in the queue
        ///</Summary>
        private Node Rear;
        private Node Front;
        private int count;

        ///<Summary> Method: Queue
        ///this the constructuor method for queue
        ///the construct create tow object for queue which is front and Read
        ///</Summary>
        public Queue()
        {
            Rear = new Node();
            Front = new Node();
        }

        ///<Summary> Method: Enque
        ///the method is being used to add object into the queue
        ///the method create a node object and add the value into node 
        ///then the the function check for  queue whether queue is empty or not
        /// if the queue is empty then the node object added into the rear of the queue and set referenct to the front queue
        /// if not then the node added to rear and set referncet to the previous node
        /// after add the node into the queue, the counter get increased
        ///</Summary>
        public void Enqueue(int data)
        {

            Node previous = new Node();
            Node newNode = new Node();
            newNode.Data = data;

            newNode.Next = null;
            if (Rear.Next == null)
            {
                
                Rear.Next = newNode;
                Front.Next = newNode;
                count++;
                //previous = newNode;
            }
            else
            {
                previous = Rear.Next;
                newNode.Next = previous;
                Rear.Next = newNode;
                Console.WriteLine(newNode.Data);
                count++;

            }

        }
        ///<Summary> method: Dequeue
        ///this method is being used to remove item from the queue
        ///the function go tho the front queue take the front queue reference and remove it from the queue
        ///and set front queue reference to the previous queue
        ///and decrese the counter
        ///if the queue is become empty
        ///set reference to the Rear and front queue null
        ///</Summary>
        public int Dequeue()
        {
            int Result = 0;
            if (getCounter() == 0)
            {
                Front.Next = null;
                Rear.Next = null;
                throw new InvalidOperationException("Queue is Empty");
            }
            else
            {
                Node Pcur = new Node();
             
                Pcur = Rear.Next;
                for (int i = 0; i < getCounter() ; i++)
                {
                    if (i == getCounter() - 2)
                    {
                        Result = Pcur.Data;
                        Front.Next = Pcur;
                        break;
                    }
                    
                    Pcur = Pcur.Next;
                }
                count = count - 1;
                if(count == 0)
                {
                    Front.Next = null;
                    Rear.Next = null;
                }

            }
            return Result;

        }
        ///<Summary> Method: getRearvalue
        ///
        ///this function is being used to get the Rear queue object's value
        ///fist the function check whether the queue is empty or not
        ///if the queue is empty the function throw an exception
        /// if the queue is not empty then return the value of the rear queue object
        ///</Summary>
        public int getRearValue()
        {
            if (Rear.Next == null)
            {

                throw new InvalidOperationException("Queue is Empty");
            }
            return Rear.Next.Data;
        }


        ///<Summary> Method: getFrontValue
        ///
        ///this function is being used to get the front queue object's value
        ///fist the function check whether the queue is empty or not
        ///if the queue is empty the function throw an exception
        /// if the queue is not empty then return the value of the front queue object
        ///</Summary>

        public int getFrontValue()
        {
            if (Front.Next == null)
            {

                throw new InvalidOperationException("Queue is Empty");
            }
            return Front.Next.Data;
        }

        ///<Summary> Method: get
        /// this function is used to get the node object from the queue according to the index number
        /// this function helps to get all the node object in the queue to display infromation in the queue panel
        /// first the fucntion check whether queue is empty or not
        /// if queue is empty then throw an exception
        /// then the function triverse the queue and get node object and return value of the objects
        ///</Summary>
        public int get(int Index)
        {
            int result = -1;
            if (count == 0)
            {
                throw new InvalidOperationException("list is Empty");
            }
            else if (count < Index)
            {
                throw new IndexOutOfRangeException("Index out of Range");
            }
            else
            {
                Node pLoc = Rear.Next;

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
        ///<Summary> Method: getCounter
        ///This function is used to get the size of the queue
        ///</Summary>
        public int getCounter()
        {
            return this.count;
        }
    }
}
