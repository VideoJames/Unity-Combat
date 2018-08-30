using System.Collections.Generic;

namespace Combat
{
    public interface Defender
    {
        void ReceiveDamage(Damage damage);
    }
}