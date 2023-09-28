

class Magic : Enemy
{
    public Magic(string name) : base(name, 80)
    { }

    public void Heal(Enemy Target)
    {
        if (Target.Health <= 0)
        {
            Console.WriteLine($"Man, {Target.Name} is gone😞");
            return;
        }
        else

        {
            Target.Health += 40;
            Console.WriteLine($"for some reason {Name} raised {Target.Name}'s health to {Target.Health}???");
        }



    }


}