using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables and do things with them!
            Console.WriteLine("Hello World");
        string myName = "Joosh";
        int myAge = 32;
        string favColor = "porble";
        string myHobby = "gaming";
        bool isOldEnoughToDrive = false;
        double myHeight = 5.59;
        char firstInitial = 'j';
        Console.WriteLine("My name is " + myName);
        Console.WriteLine("My age is {0}", myAge);
        Console.WriteLine("My favorite color is " + favColor);
        Console.WriteLine("My favorite hobby is " + myHobby);
        Console.WriteLine("My height is " + myHeight + " feet tall.");
        Console.WriteLine("My first initial is " + firstInitial);
        Console.WriteLine("I am legally allowed to drive " + isOldEnoughToDrive);
        }
    }
}
