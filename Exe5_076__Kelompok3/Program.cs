using System;

namespace Exe5
{
    // A linked list (LL) node to store a queue entry
    class QNode
    {
        // Create variable key and next
        public string key;
        public QNode next;
        // constructor to create a new linked list node
        public QNode(string key)
        {
            this.key = key;
            this.next = null;
        }
    }
    // A class to represent a queue. The queue, front stores the front node of LL and rear stores the last node of LL
    class Queue
    {
        public QNode Sofi, Miranda;
        public Queue()
        {
            this.Sofi = this.Miranda = null;
        }
        // Method to add an key to the queue.
        public void enqueue(string key)
        {
            // Create a new LL node
            QNode temp = new QNode(key);
            // If queue is empty, then new node is front and rear both
            if (this.Miranda == null)
            {
                Console.Write(key + " is inserted to queue.");
                Console.WriteLine();
                this.Sofi = this.Miranda = temp;
                return;
            }
            // Add the new node at the end of queue and change rear
            Console.Write(key + " is inserted to queue.");
            Console.WriteLine();
            this.Miranda.next = temp;
            this.Miranda = temp;
        }
        
    }
}