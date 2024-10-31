// Create a function that returns the name of the winner in a fight between two fighters.
//
//     Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.
//
//     Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.
//
//     Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.
//
//     Your function also receives a third argument, a string, with the name of the fighter that attacks first.
//     Example:
//
// declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"
//   
// Lew attacks Harry; Harry now has 3 health.
//     Harry attacks Lew; Lew now has 6 health.
//     Lew attacks Harry; Harry now has 1 health.
//     Harry attacks Lew; Lew now has 2 health.
//     Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.

Console.WriteLine(declareWinner(new Fighter("Lew", 10, 2),new Fighter("Harry", 5, 4), "Lew"));
Console.WriteLine(declareWinner(new Fighter("Lew", 10, 2),new Fighter("Harry", 5, 4), "Harry"));
Console.WriteLine(declareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"));

Console.WriteLine(declareWinner(new Fighter("Harald", 20, 100), new Fighter("Harry", 5, 4), "Harry"));

static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
{
    Fighter[] f = new[] { fighter1, fighter2 }.OrderByDescending(e => e.Name == firstAttacker).ToArray();

    while (f[0].Health > 0 && f[1].Health > 0)
    {
        f[1].Health -= f[0].DamagePerAttack;

        if (f[1].Health <= 0) break;
            
        f[0].Health -= f[1].DamagePerAttack;
    }

    return f.FirstOrDefault(e => e.Health > 0).Name;
}

class Fighter
{
    public string Name;
    public int Health, DamagePerAttack;

    public Fighter(string name, int health, int damagePerAttack)
    {
        this.Name = name;
        this.Health = health;
        this.DamagePerAttack = damagePerAttack;
    }
}