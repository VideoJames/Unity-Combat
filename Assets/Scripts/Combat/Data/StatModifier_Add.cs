using UnityEngine;

namespace Combat
{
    [CreateAssetMenu]
    public class StatModifier_Add : StatModifier
    {
        public override float GetStatModificationDelta(float baseStatValue)
        {
            return modificationValue;
        }
    }
}