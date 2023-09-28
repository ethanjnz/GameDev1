
class Melee : Enemy
{
    public Melee(string name) : base(name, 120)
    { }

    public void Rage(Enemy Target)
    {

        Console.WriteLine($"Rage has been activated for {Name}");
        Attack RandAttack = RandomAttack();
        RandAttack.DamageAmount += 10;
        PerformAttack(Target, RandAttack);
        RandAttack.DamageAmount -= 10;


    }

}