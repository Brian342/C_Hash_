// See https://aka.ms/new-console-template for more information
namespace Variables
{
     class Program{
         static void Main(string[] args)
        {
          /* 
          // creating 2 varibale
           int x ;
           int y ;

           x = 7;
           y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your Name? ");
            Console.Write("Type your First Name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your Last Name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine($"Hello, {myFirstName} {myLastName}");

            
        }
    }
}

