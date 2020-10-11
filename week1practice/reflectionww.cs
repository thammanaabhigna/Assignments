using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharpReflection
{

    class Program
    {
        static void Main(String[] args)
        {
            Type A = typeof(int); //Intiaising the T as typeofString. (Type ==> Datatype)

            //use of reflections as below
            // I Trying to find what sort the data related to T
            Console.WriteLine("Name : {0}", A.Name); //what type of Method or Type or Fields
            Console.WriteLine("FullName : {0}", A.FullName); //what type of Method or Type or Fields
            Console.WriteLine("Namespace : {0}", A.Namespace); //what type of Method or Type or Fields
            Console.WriteLine("BaseType : {0}", A.BaseType); //what type of Method or Type or Fields
            Console.ReadKey();

            int i = 42;
            System.Type type = i.GetType();
            System.Console.WriteLine(type);
            //Console.WriteLine(typeof(i));

            //example of uses of reflections to obtain full name of the loaded assembly
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info);

            Console.ReadLine();


        }
    }
}
