


using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

class Enemy
{
    string Name;
    int Health;
    public int _health
    {
        get { return Health; }
    }
    List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new();
    }

    // grabs a random attack from the attack list
    public void RandomAttack()
    {
        Random randAttack = new();
        Attack result = AttackList[randAttack.Next(AttackList.Count - 1)];
        Console.WriteLine($"You chose {result.Name} - that dealt {result.DamageAmount}");
        // note: had to make the attack fields public

    }

    // added a method to add the attack class instance to the list inside the Enemy attack list
    public void GetAttack(Attack attack)
    {
        AttackList.Add(attack);
    }
}

