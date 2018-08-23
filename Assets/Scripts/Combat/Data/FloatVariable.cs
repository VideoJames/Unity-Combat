using UnityEngine;
using System;

public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public float InitialValue;

    [NonSerialized]
    public float RunTimeValue;

    public void OnAfterDeserialize()
    {
        RunTimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}
