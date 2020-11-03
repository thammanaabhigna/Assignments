using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class Program
    {
       
    static void Main()
    {
    // Create ConcreteComponent and two Decorators

    ConcreteComponent c = new ConcreteComponent();
    ConcreteDecoratorA d1 = new ConcreteDecoratorA();
    ConcreteDecoratorB d2 = new ConcreteDecoratorB();

    // Link decorators

    d1.SetComponent(c);
    d2.SetComponent(d1);

    d2.Operation();

    // Wait for user

    Console.ReadKey();
}
  }
 
 

  /// The 'Component' abstract class

 

  abstract class Component

{
    public abstract void Operation();
}



/// The 'ConcreteComponent' class


class ConcreteComponent : Component

{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation()");
    }
}



/// The 'Decorator' abstract class


abstract class Decorator : Component

{
    protected Component component;

    public void SetComponent(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        if (component != null)
        {
            component.Operation();
        }
    }
}



/// The 'ConcreteDecoratorA' class


class ConcreteDecoratorA : Decorator

{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
}



/// The 'ConcreteDecoratorB' class



class ConcreteDecoratorB : Decorator

{
    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
        Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior()
    {
    }
}
}
 
