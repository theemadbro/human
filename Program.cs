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
            Wizard Merazmus = new Wizard("Merazmus");
            Merazmus.heal();
            Wizard Abazrafel = new Wizard ("Abazrafel", 2, 2, 2, 40);
            Abazrafel.fireball(Merazmus);
            Merazmus.fireball(Abazrafel);
            Merazmus.fireball(Abazrafel);
            Ninja Kubo = new Ninja("Kubo");
            Kubo.steal(Merazmus);
        }
    }
}
