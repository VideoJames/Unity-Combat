using System.Collections.Generic;

public class Attack
{
    public List<Damage> PotentialDamage { get; private set; }

    public Attack (List<Damage> damage)
    {
        PotentialDamage = damage;
    }
} 