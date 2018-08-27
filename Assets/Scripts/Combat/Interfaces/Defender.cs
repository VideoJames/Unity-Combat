using System.Collections.Generic;

namespace Combat
{
    public interface Defender
    {
        List<StatModifier> GetDamageModifiers();
    }
}