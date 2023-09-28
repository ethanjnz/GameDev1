
//CREATED MELEE CLASS
Melee Saitama = new("Saitama");
Attack SeriousKick = new("Serious Kicked", 100);
Attack SeriousPunch = new("Serious Punched", 100);
Attack SeriousHeadbutt = new("Serious Headbutted", 100);
Attack Tackle = new("Tackled", 25);
Attack Punch = new("Punched", 20);
Attack Kick = new("kicked", 15);
Saitama.AddAttack(Kick);
Saitama.AddAttack(Punch);
Saitama.AddAttack(Tackle);
Saitama.AddAttack(SeriousKick);
Saitama.AddAttack(SeriousPunch);
Saitama.AddAttack(SeriousHeadbutt);


// CREATED RANGED CLASS
Ranged Naruto = new("Naruto");
Attack Rasenshuriken = new("Rasenshurikened", 50);
Attack ShadowClone = new("Shadow Cloned", 1);
Attack SixPaths = new("Six Pathed", 75);
Attack Arrow = new("Arrow Shot at", 20);
Attack Knife = new("Knife Threw at", 15);
Naruto.AddAttack(Rasenshuriken);
Naruto.AddAttack(ShadowClone);
Naruto.AddAttack(SixPaths);
Naruto.AddAttack(Arrow);
Naruto.AddAttack(Knife);


// CREATED MAGIC CLASS
Magic LightYagami = new("Light Yagami");
Attack DeathNote = new("Death Noted 💀", 100);
Attack FireBall = new("Fireballed", 25);
Attack Lightning = new("Lightning Bolted", 20);
Attack StaffStrike = new("Staff Striked", 10);
Attack Monologue = new("Monologued", 1);
Attack Apple = new("Ryuk eats apple, you dead", 100);
LightYagami.AddAttack(DeathNote);
LightYagami.AddAttack(Monologue);
LightYagami.AddAttack(Apple);
LightYagami.AddAttack(FireBall);
LightYagami.AddAttack(Lightning);
LightYagami.AddAttack(StaffStrike);

// BATTLE LOG
Console.WriteLine("--------------------");
Saitama.PerformAttack(Naruto, Kick);
Console.WriteLine("--------------------");
Saitama.Rage(LightYagami);
Console.WriteLine("--------------------");
Naruto.PerformAttack(Saitama, Arrow);
Naruto.Dash();
Naruto.PerformAttack(Saitama, Arrow);
Console.WriteLine("--------------------");
LightYagami.PerformAttack(Saitama, FireBall);
Console.WriteLine("--------------------");
LightYagami.Heal(Saitama);
LightYagami.Heal(LightYagami);

