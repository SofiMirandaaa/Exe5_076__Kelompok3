﻿using System;

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
        // Method to remove an key from queue.
        public void dequeue()
        {
            // If queue is empty, return NULL.
            if (this.Sofi == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            // Store previous front and move front one node ahead
            Console.WriteLine("\nThe element deleted from the queue is.");
            this.Sofi = this.Sofi.next;
            // If front becomes NULL, then change rear also as NULL
            if (this.Sofi == null)
                this.Miranda = null;
        }
        public void display()
        {
            if (Sofi == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine("\nElements in the queue are: \n");
            QNode display;
            for (display = Sofi; display != null; display = display.next)
                Console.WriteLine(display.key);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter an element : ");
                                string element = Console.ReadLine();
                                Console.WriteLine();
                                q.enqueue(element);
                            }
                            break;
                        case '2':
                            {
                                q.dequeue();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the value entered. ");
                }
            }
        }
    }
}