using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
       
        /// Entry point into console application.

      

        static void Main()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user

            Console.ReadKey();
        }
    }

   

    /// The 'Abstraction' class

 

    class Abstraction

    {
        protected Implementor implementor;

        // Property

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }



    /// The 'Implementor' abstract class



    abstract class Implementor

    {
        public abstract void Operation();
    }

 
    /// The 'RefinedAbstraction' class


    class RefinedAbstraction : Abstraction

    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

   

    /// The 'ConcreteImplementorA' class



    class ConcreteImplementorA : Implementor

    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }



    /// The 'ConcreteImplementorB' class

 

    class ConcreteImplementorB : Implementor

    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}