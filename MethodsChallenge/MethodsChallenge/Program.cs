using System;

namespace MethodsChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            string name1 = "Lucas Medina";
            string name2 = "Leonardo Pereira";
            string name3 = "Everton Robozão";

            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
            Console.Read();
        }

        public static void GreetFriend(string personName)
        {
            Console.WriteLine("Hi " + personName + ", my friend!");
        }
    }
}
