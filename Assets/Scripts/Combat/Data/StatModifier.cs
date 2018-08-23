using UnityEngine;

public interface StatModifier
{
    float GetStatModificationDelta(float baseStatValue);
}

public class StatModifier_Multiplier : ScriptableObject, StatModifier
{
    [SerializeField] float multiplier;
    public float GetStatModificationDelta(float baseStatValue)
    {
        return baseStatValue * multiplier;
    }
}

public class StatModifier_Adder : ScriptableObject, StatModifier
{
    [SerializeField] float added;
    public float GetStatModificationDelta(float baseStatValue)
    {
        return baseStatValue + added;
    }
}