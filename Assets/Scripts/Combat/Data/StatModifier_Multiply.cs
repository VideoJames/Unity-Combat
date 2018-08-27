
using UnityEngine;

namespace Combat
{
    public class StatModifier_Multiply : ScriptableObject, StatModifier
    {
        [SerializeField] float multiplier;
        public float GetStatModificationDelta(float baseStatValue)
        {
            return baseStatValue * multiplier;
        }
    }
}