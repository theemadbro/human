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
            Wizard otherwiz = new Wizard ("otherwiz", 2, 2, 2, 40);
            otherwiz.fireball(Merazmus);
            Merazmus.fireball(otherwiz);
            Merazmus.fireball(otherwiz);
            Ninja Kubo = new Ninja("Kubo");
            Kubo.steal(Merazmus);
            Beefboi.attack(Kubo);
            Kubo.steal(Beefboi);
            Samurai sam1 = new Samurai("Hamurai");
            Samurai sam2 = new Samurai("Sam-I-Amurai", 3, 3, 3, 60);
            Samurai.how_many();
            sam1.death_blow(sam2);
            Merazmus.fireball(sam1);
            sam1.death_blow(sam2);
            sam1.meditate();
        }
    }
}
