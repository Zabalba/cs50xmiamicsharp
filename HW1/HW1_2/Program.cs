using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_2
{
    class AnsweringService
    {
        static void Main(string[] args)
        {

            /*
            Write a program that mimics an automated answering service. Read user input from the console. If the user enters
            0 - print “We’re transferring you to an operator”
            1 - Our sales offices are closed at this time
            3 - Please record your message now
            5 - Good bye
            any other value - Sorry. you’ve entered an invalid option
            */
            bool validresponse = false;

            while (!validresponse)
            {


                Prompt();

                string userinput = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine(Environment.NewLine);
                int userselection;

                if(int.TryParse(userinput, out userselection))
                {
                    validresponse = RespondToInput(userselection);
                }
                else
                {
                    Console.WriteLine("Sorry. '" + userinput + "' is an invalid selection. Please try again.");
                }

                    
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
        static void Prompt()
        {
            List<string> values = new List<string>();

            values.Add("Please select from one of the following options:");
            values.Add("To reach the sales office, press '1'.");
            values.Add("To leave a message, press '3'.");
            values.Add("To hang up, press '5'.");
            values.Add("To a operator, press '0'.");
            values.Add("Please select an option now:");

            foreach (var item in values)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

        }
        static bool RespondToInput(int option)
        {

            string response = "Please input a selection";
            bool validresponse = false;

            switch (option)
            {

                case 0:
                    response = "We're transferring you to an operator";
                    validresponse = true;
                    break;

                case 1:
                    response = "Our sales offices are closed at this time";
                    validresponse = true;
                    break;

                case 3:
                    response = "Please record your message now";
                    validresponse = true;
                    break;

                case 5:
                    response = "Good bye";
                    validresponse = true;
                    break;

                default:
                    response = "Sorry. you’ve entered an invalid option";
                    break;
            }

            Console.WriteLine(response);

            return validresponse;

        }
    }
}
