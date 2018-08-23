using System.Collections.Generic;
using UnityEngine;


public class DamageData : ScriptableObject
{
    public FloatReference Float;

    //[SerializeField] DamageType type;
    //public DamageType Type { get { return type; } }

    //[SerializeField] List<Effect> effects;
    //public List<Effect> Effects { get { return effects; } }

    public Damage CreateDamage()
    {
        return new Damage(Float.Value);
    }
}
