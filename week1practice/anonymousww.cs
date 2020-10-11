using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_assignment
{
    //Defining delegate
    public delegate double AddnumsDelegate(int x, float y);
    public delegate int MultiplyDelegate(int x, int y);
    public delegate string NamesDelegate(string str);
    public delegate string WishDelegate(string str);
    public delegate bool CheckLengthDelegate(string str);
    public delegate bool CheckLength1Delegate(string str);

    class Program
    {
        static void Main(string[] args)
        {
            AddnumsDelegate obj1 = delegate (int x, float y) //object creation
            {
                return (x + y);
            };
            double result = obj1.Invoke(5, 5.5f); //Invoke Method
            Console.WriteLine(result);

            MultiplyDelegate obj2 = delegate (int x, int y) //object creation
            {
                return (x + y);
            };
            int result1 = obj2.Invoke(50, 50); //Invoke Method
            Console.WriteLine(result1);

            NamesDelegate obj3 = delegate (string Abhigna) //object creation
            {
                return " This " + Abhigna + " my ";
            };
            string result2 = obj3.Invoke("is"); //Invoke Method
            Console.WriteLine(result2);

            WishDelegate obj4 = delegate (String sir)//object creation
            {
                return (" practise " + sir + " yes ");
            };
            string result3 = obj4.Invoke("file "); //Invoke Method
            Console.WriteLine(result3);

            CheckLengthDelegate obj5 = delegate (string name) //object creation
            {
                if (name.Length > 5)
                    return true;
                return false;
            };
            bool check = obj5.Invoke(" sir "); //Invoke Method
            Console.WriteLine(check);

            CheckLength1Delegate obj6 = delegate (string namee)//object creation
            {
                if (namee.Length < 3)
                    return true;
                return false;
            };
            bool check1 = obj6.Invoke(" AbhignaThammana ");//Invoke Method
            Console.WriteLine(check1);

            Console.ReadLine();
        }
    }
}

