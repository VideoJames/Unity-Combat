using UnityEngine;

namespace Combat
{
    public class StatModifier_Add : ScriptableObject, StatModifier
    {
        [SerializeField] float added;
        public float GetStatModificationDelta(float baseStatValue)
        {
            return baseStatValue + added;
        }
    }
}