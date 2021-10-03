using System;

namespace Classes
{
    public class Player
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName +" "+ lastName);
        }
    }
}
