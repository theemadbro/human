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
        public void attack(object obj)
        {
            if (obj is Humans)
            {
                Humans trg = obj as Humans;
                System.Console.WriteLine(this.Name+" attacks "+trg.Name+"!");
                int dmg = 5*this.Strength;
                trg.Health -= dmg;
                System.Console.WriteLine(trg.Name+" was hit for "+dmg+" hp! They have "+trg.Health+" remaining");
            }
            else
            {
                System.Console.WriteLine("you can't attack that, doofus");
            }
        }
    }
    public class Wizard : Humans
    {
        public Wizard(string name) :base(name, 3, 25, 3, 50)
        {
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
        public void fireball(object obj)
        {
            if (obj is Humans)
            {
                Humans trg = obj as Humans;
                System.Console.WriteLine(this.Name+" attacks "+trg.Name+"!");
                Random rand = new Random();
                int dmg = rand.Next(20,51);
                trg.Health -= dmg;
                System.Console.WriteLine(trg.Name+" was blasted for "+dmg+" hp! They have "+trg.Health+" remaining");
            }
            else
            {
                System.Console.WriteLine("Woops! Looks like "+this.Name+"'s old age is catching up with him again... he's attacking things at random!");
            }
        }
    }
    public class Ninja : Humans
    {
        public Ninja(string name) :base(name, 3, 3, 175, 100)
        { }
        public Ninja(string name, int str, int intl, int dex, int hp) : base(name, str, intl, dex, hp)
        { }
        public void steal(object trg)
        {
            attack(trg);
            this.Health += 10;
            System.Console.WriteLine(this.Name+ " gained 10 hp! ("+this.Health+" total)");
        }
        public void get_away()
        {
            this.Health-=15;
        }
    }
    public class Samurai : Humans
    {
        public static int count = 0;
        public Samurai(string name) :base(name, 3, 3, 3, 200)
        { 
            count++;
        }
        public Samurai(string name, int str, int intl, int dex, int hp) : base(name, str, intl, dex, hp)
        {
            count++;
        }
        public void death_blow(object obj)
        {
            if (obj is Humans)
            { 
                Humans trg = obj as Humans;
                if (trg.Health < 50)
                {
                    System.Console.WriteLine($"{this.Name} feels the weakness in {trg.Name}, and makes the Death Blow.");
                    System.Console.WriteLine($"{trg.Name} is struck for {trg.Health} hp, and keels over ded!");
                    trg.Health = 0;
                }
                else
                {
                    System.Console.WriteLine($"{trg.Name} is still too strong for a Death Blow, so {this.Name} attacks instead.");
                    attack(trg);
                }
            }
        }
        public void meditate()
        {
            if (this.Health < 200)
            {
                this.Health = 200;
                System.Console.WriteLine(this.Name+ " meditates, returning health to 200!");
            }
            else
            {
                System.Console.WriteLine($"{this.Name} pauses to meditate...");
            }
        }
        public static void how_many()
        {
            System.Console.WriteLine(count);
        }
    }
}