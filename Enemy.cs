

class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; set; } = new();


    public Enemy(string name, int health = 100)
    {
        Name = name;
        Health = health;
        AttackList = new();
    }

    // grabs a random attack from the attack list
    public Attack RandomAttack()
    {
        Random randAttack = new();
        Attack result = AttackList[randAttack.Next(AttackList.Count - 1)];
        // Console.WriteLine($"You chose {result.Name} - that dealt {result.DamageAmount}");
        // note: had to make the attack fields public
        return result;

    }

    // added a method to add the attack class instance to the list inside the Enemy attack list
    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // check if health is 0. if so, they are dead:(
        Target.Health -= ChosenAttack.DamageAmount;
        if (Target.Health <= 0)
        {
            Console.WriteLine($"🏆 Achievement unlocked for {Target.Name}🏆");
            Console.WriteLine($"Death 💀");
        }
        if (Target.Health > 0)
        {
            Console.WriteLine($"AYYYOOOO {Name} just {ChosenAttack.Name} {Target.Name}! That must've been at least {ChosenAttack.DamageAmount} damage. Bro probably only has {Target.Health} health left!");
        }


        // Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }
}

