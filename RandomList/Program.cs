using System;
using System.Security.Cryptography.X509Certificates;

namespace CustomRandomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("Tan");
            list.Add("Minh");
            list.Add("Duy");
            Console.WriteLine(list.RandomString());
        }
    }
}