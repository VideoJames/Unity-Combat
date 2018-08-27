using UnityEngine;

namespace Combat
{
    public abstract class StatModifier : ScriptableObject
    {
        [SerializeField] protected float modificationValue;

        public abstract float GetStatModificationDelta(float baseStatValue);
    }
}