using System;

namespace UserInputAndrewGreen
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = "Hi, this is Andrew Green.";
            string question;

            Console.WriteLine(greeting);

            Console.WriteLine("Please ask a question and hit ENTER to continue:");

            // typecasting not needed  
            // as ReadLine returns string 
            question = Console.ReadLine();

            Console.WriteLine("You typed: " + question + "!");
            
        }
    }
}
