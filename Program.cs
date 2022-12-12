﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_144
{

    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*Initializing the values of the variables REAR and FRONT to -1 to indicate that
             * the queue is initially empty. */
            FRONT = -1;
            REAR = -1;  
        }

        public void insert(int element)
        {
            /*this statement checks for the overflow condition. */
            if (( FRONT == 0 && REAR == max - 1 ) ||( FRONT == REAR +1)) 
                    {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* This following statement checks whether the queue is empty. if the queue is empty
             * , then the value of the REAR and FRONT variables is set to 0 */
            if ( FRONT == -1 )
            {
                FRONT = 0;
                REAR = 0;   
            }
            else
            {
                /* if REAR is at the last position of the array, then the value of
                 * REAR is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is not at he last position, then its value is incremented by one */
                    REAR = REAR + 1;
            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[REAR] = element;
        }

        public void remove()
        {
            /* Checks whether the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe Element deleted from the queue is: " + queue_array[FRONT] + "\n");
            /* Check if the queue has one elmeent. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* if the elemnt to be deleted is at the last position of the array, then the value
                 * of FRONT is set to 0 i.e to the firts element of the array. */
                if (FRONT == max -1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1;

            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* Checks if the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are .................\n");
            if (FRONT_position <= REAR_position)
            {
                /* traverse the queue till the last element present in an array. */
                while (FRONT_position < REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* traverses the queue till the last position of the array.*/
                while (FRONT_position <= max -1)
                {
                    Console.Write(queue_array[FRONT_position] + "     ");
                    FRONT_position++;
                }
                *
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
