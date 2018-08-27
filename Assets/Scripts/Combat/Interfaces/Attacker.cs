using System.Collections.Generic;

namespace Combat
{
    public interface Attacker
    {
        List<Damage> GetDamage();
    }
}