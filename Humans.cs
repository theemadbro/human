using System;
using System.Collections.Generic;
namespace human {
    public class Humans
    {
        public string Name = "basic";
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }
        public Humans(string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.Health = 100;
        }
        public Humans(string name, int str, int intl, int dex, int hp)
        {
            this.Name = name;
            this.Strength = str;
            this.Intelligence = intl;
            this.Dexterity = dex;
            this.Health = hp;
        }
        public void attack(object trg)
        {
            if (trg is Humans)
            {
                object res = trg.GetType();
                Humans thing = (Humans)trg;
                System.Console.WriteLine(this.Name+" attacks "+thing.Name+"!");
                int dmg = 5*this.Strength;
                thing.Health -= dmg;
                System.Console.WriteLine(thing.Name+" was hit for "+dmg+" hp! They have "+thing.Health+" remaining");
            }
            if 
            else
            {
                System.Console.WriteLine("you can't attack that, doofus");
            }
        }
    }
    public class Wizard : Humans
    {
        public new int Intelligence = 25;
        public new int Health = 50;
        public Wizard(string name) :base(name)
        {
            this.Intelligence = 25;
            this.Health = 50;
        }
        public Wizard(string name, int str, int intl, int dex, int hp) : base(name, str, intl, dex, hp)
        {
        }
        public void heal()
        {
            int amt = 10 * this.Intelligence;
            this.Health += amt;
            System.Console.WriteLine("'Ahh, much better.' Healed for " + amt);
            System.Console.WriteLine(this.Name+"'s Health is now " + this.Health);
        }
        public void fireball(object trg)
        {
            if (trg is Humans)
            {
                Humans thing = (Humans)trg;
                System.Console.WriteLine(this.Name+" attacks "+thing.Name+"!");
                Random rand = new Random();
                int dmg = rand.Next(20,51);
                thing.Health -= dmg;
                System.Console.WriteLine(thing.Name+" was blasted for "+dmg+" hp! They have "+thing.Health+" remaining");
            }
            else
            {
                System.Console.WriteLine("Woops! Looks like "+this.Name+"'s old age is catching up with him again...");
            }
        }
    }
    public class Ninja : Humans
    {
        public new int Dexterity = 175;
        public Ninja(string name) :base(name)
        {
        }
        public Ninja(string name, int str, int intl, int dex, int hp) : base(name, str, intl, dex, hp)
        {
        }
        public void steal(object trg)
        {
            attack(trg);
            this.Health += 10;
            System.Console.WriteLine(this.Name+ " gained 10 health!");
        }
    }
}