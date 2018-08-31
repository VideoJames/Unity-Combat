using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    private float baseValue;

    private List<StatModifier> modifiers;

    public float GetValue()
    {
        float returnValue = baseValue;
        modifiers.ForEach(x => returnValue += x.GetModificationDelta(baseValue));
        return returnValue;
    }

    public void AddModifier(StatModifier modifier)
    {
        modifiers.Add(modifier);
    }

    public void RemoveModifier(StatModifier modifier)
    {
        modifiers.Remove(modifier);
    }
}
