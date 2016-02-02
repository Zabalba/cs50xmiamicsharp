using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class SystemInfo
    {
        static void Main(string[] args)
        {


            /*
            The Environment class provides some basic information about the current system that your application is running on. 
            Write a simple Console application called SystemInfo that uses the Environment class to print some system information to the screen. 
            Specifically, you are required to print the Machine Name, Operating System version, the current User, the number of Processors on the machine and the Network Domain. 
            Each of these should be printed to a new line.
            */

            PrintCurrentEnvironmentValues();
            Console.ReadKey();

        }
        static void PrintCurrentEnvironmentValues()
        {
            List<string> values = new List<string>();

            values.Add("Machine Name: " + Environment.MachineName);
            values.Add("OS Version: " + Environment.OSVersion.VersionString);
            values.Add("Current Username: " + Environment.UserName);
            values.Add("Processor Count: " + Environment.ProcessorCount.ToString());
            values.Add("Network Domain Name: " + Environment.UserDomainName);

            foreach (var item in values)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

        }
    }
}
