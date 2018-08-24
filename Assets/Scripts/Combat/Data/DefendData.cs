using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DefendData : ScriptableObject
{
    [SerializeField] List<StatModifier> damageModifiers;
}
