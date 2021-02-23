using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_lib
{
    class LinkedListController
    {
        private LinkedList myLinkedList;
        private ctl_linkedList theInterface;
        public LinkedListController(ctl_linkedList newInterface)
        {
            theInterface = newInterface;
            myLinkedList = new LinkedList();
        }
        public void addToList(int value)
        {
            myLinkedList.Add(value);
        }
        public void RemoveFromList(int value)
        {
            myLinkedList.removeAt(value);
        }
        public int getSizeoftheList()
        {
            return myLinkedList.getCounter();
        }
        public int getSingleValue(int index)
        {
            return myLinkedList.get(index);

        }
    }
}
