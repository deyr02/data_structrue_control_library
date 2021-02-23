using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_structure_lib
{
    class QueueController
    {
        ///<Summary> Cal QueueController
        ///This class is being used to utlize the queue functionality
        ///</Summary>
        private Queue myQueue;
        private ctl_queue theInerface;
        ///<Summary> Method: QueueController
        /// This is condtructor method for QueueController
        /// It creates a reference to the interface
        /// It also creates Queue object
        ///</Summary>
        public QueueController(ctl_queue newInterface)
        {
            theInerface = newInterface;
            myQueue = new Queue();
        }

        ///<Summary> Method: addToQueue
        ///this method is being used to add value in the queue
        ///</Summary>
        public void addToQueue(int data)
        {
            myQueue.Enqueue(data);
        }

        ///<Summary> Method: RemoveFromQueue
        ///this method is being used to add remove value from the queue
        ///</Summary>
        public void RemoveFromQueue()
        {
            myQueue.Dequeue();
        }

        ///<Summary> Method: getQueueCounter
        ///this method is being used to get queue counter
        ///</Summary>
        public int getQueueCounter()
        {
            return myQueue.getCounter();
        }
        ///<Summary> Method: getFrontValue
        ///this method is being used to get the front queue's value
        ///</Summary>
        public int getFrontValue()
        {
            return myQueue.getFrontValue();
        }
        ///<Summary> Method: getRearValue
        ///this method is being used to get the Rear queue's value
        ///</Summary>
        public int getRearValue()
        {
            return myQueue.getRearValue();
        }
        ///<Summary> Method: getSignleValue
        ///this method is being used to get the value of specific node object in the the quee
        ///</Summary>
        public int getSingleValue( int index)
        {
            return myQueue.get(index);
        }
    }
}
