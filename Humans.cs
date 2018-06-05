namespace human {
    public class Humans
    {
        public string Name;
        public int Strength = 3;
        public int Intelligence = 3 ;
        public int Dexterity = 3;
        public int Health = 100;
        public Humans(string inp)
        {
            this.Name = inp;
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
                Humans thing = (Humans)trg;
                System.Console.WriteLine("You attack "+thing.Name+"!");
                int dmg = 5*this.Strength;
                thing.Health -= dmg;
                System.Console.WriteLine(thing.Name+" was hit for "+dmg+" hp! They have "+thing.Health+" remaining");
            }
            else
            {
                System.Console.WriteLine("you can't attack that, doofus");
            }
        }
    }
}