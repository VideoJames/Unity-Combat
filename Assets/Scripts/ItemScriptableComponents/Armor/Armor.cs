using UnityEngine;

public class Armor : ScriptableObject
{
    [SerializeField] protected float value;
    public float Value { get { return value; } }
}
