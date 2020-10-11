using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
    class stack
    {
        static void Main(string[] args)
        {
            Stack<string> MyStack = new Stack<string>();
            MyStack.Push("ab");
            MyStack.Push("cd");
            MyStack.Push("ef");
            MyStack.Push("gh");
            MyStack.Push("ij");
            MyStack.Push("kl");
            MyStack.Push("mn");
            MyStack.Push("op");
            MyStack.Push("qr");
            MyStack.Push("st");
            Console.WriteLine("the topmost element of the stack is {0} ", MyStack.Peek());

            foreach (string x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
            Console.WriteLine("Removing 6 pop oprations");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("after 6 pop oprations");
            Console.WriteLine("the top ele of stack is{0}" + MyStack.Peek());
            foreach (string x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push("ab");
            Console.WriteLine("removing 5 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            foreach (string x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push("cd");
            MyStack.Push("ef");
            MyStack.Push("gh");
            MyStack.Push("ij");
            MyStack.Push("kl");
            Console.WriteLine("removing 4 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push("mn");
            MyStack.Push("op");
            MyStack.Push("qr");
            Console.WriteLine("removing 3 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("pushing here!!!!!");
            MyStack.Push("st");
            MyStack.Push("uv");
            Console.WriteLine("removing 4 elements");
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            foreach (string x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }

            // Console.WriteLine(MyStack.Contains(2));
            Console.ReadKey();

        }
    }
}


