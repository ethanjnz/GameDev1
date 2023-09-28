
class Ranged : Enemy
{
    public int Distance { get; set; } = 5;

    public Ranged(string name) : base(name, 100)
    { }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance >= 10)
        {
            base.PerformAttack(Target, ChosenAttack);
        }
        else
        {
            Console.WriteLine($"AYYYYO {Name}! You are too close man! Back it up at least 10ft away!");
        }
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"A litte dash put you about {Distance}ft away");
    }

}