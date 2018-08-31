using UnityEngine;

public class Damage : ItemScriptableComponent
{
    [SerializeField] protected float value;
    public float Value { get { return value; } }
}
