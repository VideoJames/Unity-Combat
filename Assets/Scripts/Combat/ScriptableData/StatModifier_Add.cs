using UnityEngine;

namespace Combat
{
    [CreateAssetMenu]
    public class StatModifier_Add : StatModifier
    {
        public override float GetModificationDelta(float baseStatValue)
        {
            return modificationValue;
        }
    }
}