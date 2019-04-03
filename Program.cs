using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human vlad = new Human("Vlad");
            Human dima = new Human("Dima", 20, 30, 40, 3000);

            Wizard wiz = new Wizard("Torlol");
            Ninja ninja = new Ninja("Lala");
            Samurai samurai = new Samurai("zebbie");
            samurai.Attack(vlad);
            wiz.Attack(vlad);
            ninja.Attack(vlad);
            wiz.Heal(vlad);
            ninja.Steal(wiz);
            Console.WriteLine(wiz.Strength);

        }
    }

    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        private int _health;


        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            _health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            _health = health;
        }

        public virtual int Attack(Human target)
        {
            int dmg = Strength * 5;
            target.Health -= dmg;
            Console.WriteLine(Name + " hit " + target.Name + " for " + dmg);
            return target.Health;
        }
    }

    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            Health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Strength * 5;
            target.Health -= dmg;
            Console.WriteLine("You hit " + target.Name + " for " + dmg);
            Health += dmg;
            Console.WriteLine("You heal yourselft for " + dmg);
            return target.Health;
        }

        public void Heal(Human target)
        {
            target.Health += 10;
            Console.WriteLine("You healed " + target.Name);
        }
    }


    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int random = rand.Next(11);
            int dmg = Dexterity * 5;
            target.Health -= dmg;
            Console.WriteLine("You hit " + target.Name + " for " + dmg);
            if (random > 3)
            {
                target.Health -= 10;
                Console.WriteLine("You dealt 10 additional damage");
            }

            return target.Health;
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine("You stole 5 health form " + target.Name);
        }
    }
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine("You killed " + target.Name);
            }
            return target.Health;

        }

        public void Meditate()
        {
            Health = 200;
            Console.WriteLine(Name + " restored hull health!");

        }
    }
}
