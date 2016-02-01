using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //print profile: First name, last name, ,hometown, email
            //Console.Write(profile("Kevin","Contino","North Miami","kevin.contino@gmail.com"));

            //accept array of pos ints, print only the even numbers
            //Console.Write(printevennums(1,2,3,4,5,6));

            //find the avg of a list of numbers
            //Console.Write(GetAvg(1, 2));

            //print list of ints that are odd
            //IsOdd(1, 2, 3, 4);

            //cause exception and print
            //CauseException(20);

            /*
            Animal Alien = new Animal();
            Dog Fido = new Dog();

            List<Animal> Creatures = new List<Animal>();

            Creatures.Add(Alien);
            Creatures.Add(Fido);

            foreach (Animal creature in Creatures)
            {
                creature.Walk();
            }
            */

            //create interface called event service
            MobileSimpleService mss = new MobileSimpleService();
            DesktopSimpleService dss = new DesktopSimpleService();



            //Final Project: build a website managing events (Laundry app?)

            Console.ReadKey();
        }
        static string profile(params string[] list)
        {

            string rv = "";
            for (int i = 0; i < list.Length; i++)
            {
                rv = AppendValueNL(rv, list[i]);
            }
            return rv;
        }
        static string printevennums(uint divisor = 2, params uint[] list)
        {
            string rv = "";
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % divisor == 0)
                {
                    rv = AppendValueNL(rv, list[i].ToString());
                }
            }
            return rv;
        }
        static string AppendValueNL(string existingvalue, string valuetoadd)
        {
            return existingvalue + valuetoadd + Environment.NewLine;
        }
        static double GetAvg(params int[] list)
        {

            double sum = 0;
            double avg = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }

            avg = sum / list.Length;

            return avg;
        }
        static void IsOdd(params int[] list)
        {

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Console.WriteLine("Number " + list[i] + " is a odd number");
                }
            }

        }
        static void CauseException(int value)
        {

            try
            {
                int boom = value / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
    class Animal
    {
        public virtual void Walk()
        {
            Hover();
        }
        private void Hover()
        {
            //hovers as base locomotion
        }
    }
    class Dog : Animal
    {
        public override void Walk()
        {
            Use4Legs();
        }
        private void Use4Legs()
        {
            //use 4 legs as locomotion
        }
    }

    public interface SimpleService
    {
        void AddEvent(string eventName, DateTime eventDate);
        void RemoveEvent(string eventID);
        void ModifyEvent(string eventID);
    }
    public class MobileSimpleService : SimpleService
    {
        public void AddEvent(string eventName, DateTime eventDate)
        {
            throw new NotImplementedException();
        }

        public void ModifyEvent(string eventID)
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent(string eventID)
        {
            throw new NotImplementedException();
        }
    }
    public class DesktopSimpleService : SimpleService
    {
        public void AddEvent(string eventName, DateTime eventDate)
        {
            throw new NotImplementedException();
        }

        public void ModifyEvent(string eventID)
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent(string eventID)
        {
            throw new NotImplementedException();
        }
    }
}
