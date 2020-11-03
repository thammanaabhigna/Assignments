using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesign
{
    class Program
    {


        /// Factory Method Design Pattern WE DEFINE INTERFACE FOR CREATING AN OBJECT BUT LETS ITS SUBCLASES DECIDE WHICH CLASS TO INSTANTIATE. 






        /// Entry point into console application.



        static void Main()
        {
            // An array of creators

            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            // Wait for user

            Console.ReadKey();
        }
    }

   

    /// The 'Product' abstract class

  

    abstract class Product

    {
    }

    

    /// A 'ConcreteProduct' class

  

    class ConcreteProductA : Product

    {
    }

  

    /// A 'ConcreteProduct' class

    /// </summary>

    class ConcreteProductB : Product

    {
    }

   

    /// The 'Creator' abstract class

 

    abstract class Creator

    {
        public abstract Product FactoryMethod();
    }

   

    /// A 'ConcreteCreator' class

  

    class ConcreteCreatorA : Creator

    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    class ConcreteCreatorB : Creator

    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
