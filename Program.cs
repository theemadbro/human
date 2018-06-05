using System;

namespace human
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Humans Jack = new Humans("Jack");
            Humans Beefboi = new Humans("Beefboi", 2, 1, 1, 300);
            int idea = 42;
            Jack.attack(Beefboi);
            Beefboi.attack(idea);
        }
    }
}
