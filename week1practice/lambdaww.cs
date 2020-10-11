using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment


{
    //Defining the delegate according to method
    public delegate double AddnumsDelegate(int x, float y);
    public delegate int MultiplyDelegate(int x, int y);
    public delegate void NamesDelegate(string str);
    public delegate void WishDelegate(string str);
    public delegate bool CheckLengthDelegate(string str);
    public delegate bool CheckLength1Delegate(string str);

    class Program
    {
        static void Main(string[] args)
        {
            AddnumsDelegate obj1 = (int x, float y) =>
            {
                return (x + y);
            };
            double result = obj1.Invoke(5, 5.5f);
            Console.WriteLine(result);

            MultiplyDelegate obj2 = (int x, int y) =>
            {
                return (x + y);
            };
            int result1 = obj2.Invoke(50, 50);
            Console.WriteLine(result1);

            NamesDelegate obj3 = was =>
            {
                Console.WriteLine(" This " + was + " my ");
            };
            obj3.Invoke("was");

            WishDelegate obj4 = sir =>
            {
                Console.WriteLine(" my " + sir + "file ");
            };
            obj4.Invoke("practice ");

            CheckLengthDelegate obj5 = name =>
            {
                if (name.Length > 5)
                    return true;
                return false;
            };
            bool check = obj5.Invoke(" Sowmya ");
            Console.WriteLine(check);

            CheckLength1Delegate obj6 = namee =>
            {
                if (namee.Length < 3)
                    return true;
                return false;
            };
            bool check1 = obj6.Invoke(" Ramyasree ");
            Console.WriteLine(check1);

            Console.ReadLine();
        }
    }
}