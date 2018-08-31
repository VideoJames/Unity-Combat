using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScriptableComponent : ScriptableObject
{
    // Components that can be added to an Item to give it properties
}

public class MonetaryValue : ItemScriptableComponent
{
    [SerializeField] private readonly int value;
    public int Value { get { return value; } }
}

