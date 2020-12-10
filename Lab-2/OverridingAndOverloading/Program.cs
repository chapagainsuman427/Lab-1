using System;

namespace OverridingAndOverloading
{ 
    public class Base
    {
        public string Name; 

        public Base()
        {
            Console.WriteLine("Welcome Everyone.");
        }

        public Base(string name)
        {
            Name = name;
            Console.WriteLine("Welcome {0}, to base class.",Name);
        }

        public virtual void display()
        {
            Console.WriteLine("This is base class.");
        }
    }

    public class Derived: Base
    {
        public override void display()
        {
            Console.WriteLine("This is derived class.");
        }
        public void display(string Name)
        {
            Console.WriteLine("Hello I am " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Default Constructor
            Base b1 = new Base();

            // Constructor Overloading
            Base b2 = new Base("Suman");   

            b1.display();

            Derived d1 = new Derived();
            
            // Function Overriding
            d1.display();          

            // Function Overloading
            d1.display("Suman");       
        }
    }

    

}
