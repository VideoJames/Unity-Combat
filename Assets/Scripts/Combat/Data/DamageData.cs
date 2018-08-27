using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    [CreateAssetMenu]
    public class DamageData : ScriptableObject
    {
        [SerializeField] float value;

        public Damage GetDamage()
        {
            return new Damage(value, false);
        }
    }
}