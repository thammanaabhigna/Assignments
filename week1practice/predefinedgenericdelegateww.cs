using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefinedGenericDelegate
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

        //method with returning value

        //method without returning value

        //method with returning value

        static void Main(string[] args)
        {

            //Instiating the delegate
            Func<int, float, double> obj1 = (x, y) =>
            {
                return (x + y);
            };

            double result = obj1(10, 3.142f); //new variable to store the values-return type
            Console.WriteLine(result);

            Func<int, int, double> obj2 = (x, y) =>
            {
                return (x * y);
            };

            double result2 = obj2(10, 30); //new variable to store the values-return type
            Console.WriteLine(result2);

            Action<string> obj3 = s =>//non return type
            {
                Console.WriteLine(s + "my");
            };
            obj3("This is");

            Action<string> obj4 = st =>//non return type
            {
                Console.WriteLine(st + "file");
            };
            obj4("practice");

            Predicate<string> obj5 = name => //new variable to store the values-return type
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name.Length > 4)
                    return true;
                return false;
            };
            bool check = obj5("Abhigna");
            Console.WriteLine(check);

            Predicate<string> obj6 = name => //new variable to store the values-return type
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name.Length > 4)
                    return true;
                return false;
            };
            bool check1 = obj6("dxc");
            Console.WriteLine(check1);

            Console.ReadLine();
        }
    }
}

