
using UnityEngine;

namespace Combat
{
    [CreateAssetMenu]
    public class StatModifier_Multiply : StatModifier
    {
        public override float GetModificationDelta(float baseStatValue)
        {
            return baseStatValue * modificationValue - baseStatValue;
        }
    }
}