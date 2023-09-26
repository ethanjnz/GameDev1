
// CREATED ENEMY 
Enemy Vader = new("Vader");

// CREATED ATTACKS
Attack Kick = new("Kick", 20);
Attack Punch = new("Punch", 30);
Attack Headbutt = new("Headbutt", 5);

// ADDED ATTACK TO THE ATTACK LIST IN THE ENEMY CLASS
Vader.GetAttack(Kick);
Vader.GetAttack(Punch);
Vader.GetAttack(Headbutt);

Vader.RandomAttack();




