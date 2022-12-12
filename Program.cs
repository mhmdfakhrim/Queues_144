using System;
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
                    /* if REAR is not at he last position
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
