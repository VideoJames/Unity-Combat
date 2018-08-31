using UnityEngine;

public abstract class StatModifier : ScriptableObject
{
    [SerializeField] protected float modificationValue;

    public abstract float GetModificationDelta(float baseValue);
}
