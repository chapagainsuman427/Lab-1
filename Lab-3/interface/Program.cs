using System;

namespace Interface
{
    // Interface for First Parent Class
    public interface Interface1
    {
         void first();
    }

    // First Parent Class
    public class TheRock : Interface1 
     { 
        public void first() 
        { 
            Console.WriteLine("It doesnot matter what your name is.");
        } 
    } 

     // Interface for Second Parent Class
    public interface Interface2
    {
        void second();     
    }

    // Second Parent Class
    class StoneCold : Interface2 
    { 
        public void second() 
        { 
            Console.WriteLine("Showing response.");
        } 
    } 

    // Multiple Inheritance through Interface1 and Interface2
    class ChildClass : Interface1, Interface2
    { 
        TheRock obj1 = new TheRock(); 
        StoneCold obj2 = new StoneCold(); 
        public void first() 
        {
            Console.Write("What is your name? ");
            Console.ReadLine();
            obj1.first();
        } 
        public void second() 
        {
            Console.WriteLine("\nIf you like it, give some response!!!");
            obj2.second(); 
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
            ChildClass obj = new ChildClass();

            obj.first();
            obj.second();
        }
    }

}
