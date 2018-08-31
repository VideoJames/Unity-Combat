using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Weapon : ScriptableObject
{
    [SerializeField] List<ItemScriptableComponent> scriptableComponents;
}
