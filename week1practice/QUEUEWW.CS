using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> MyQueue = new Queue<string>();//created an object of queue
            MyQueue.Enqueue("aa");//enqueue method takes one parameter/argument.
            MyQueue.Enqueue("bb");
            MyQueue.Enqueue("cc");
            MyQueue.Enqueue("dd");
            MyQueue.Enqueue("ee");
            MyQueue.Enqueue("ff");
            MyQueue.Enqueue("gg");
            MyQueue.Enqueue("hh");
            MyQueue.Enqueue("ii");
            MyQueue.Enqueue("jj");
            foreach (string Queue in MyQueue)
            {
                Console.WriteLine("The elements of MyQueue are : " + Queue);
            }



            Console.WriteLine("the peek elements of Queue is : " + MyQueue.Peek());//to find peek of myqueue
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//dequeue method for 6 times
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the peek elements of Queue is : " + MyQueue.Peek());//to find peek after 6 dequeue methods
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//dequeue method for 5 times
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//queue became empty
            MyQueue.Enqueue("aa");//enqueue few elements again
            MyQueue.Enqueue("bb");

            MyQueue.Enqueue("cc");

            MyQueue.Enqueue("dd");

            MyQueue.Enqueue("ee");

            MyQueue.Enqueue("ff");
            MyQueue.Enqueue("gg");
            MyQueue.Enqueue("hh");
            MyQueue.Enqueue("ii");
            MyQueue.Enqueue("jj");
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the peek elements of Queue is : " + MyQueue.Peek());//peek method after 5 dequeue methods
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//4 dequeue methods
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());

            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the peek elements of Queue is : " + MyQueue.Peek());//peek method after 4dequeue methods
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//3 dequeue methods
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());
            Console.WriteLine("the peek elements of Queue is : " + MyQueue.Peek());//peek after 3 dequeue methods
            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//2 dequeue methods

            Console.WriteLine("the elements after applying dequeue:" + MyQueue.Dequeue());//queue is empty.so add elements
            MyQueue.Enqueue("aa");
            MyQueue.Enqueue("bb");










            Console.WriteLine("the peek elements of Queue is : " + MyQueue.Peek());


            Console.ReadLine();

        }
    }
}