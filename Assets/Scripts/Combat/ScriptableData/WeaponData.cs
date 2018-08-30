using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    [CreateAssetMenu]
    public class WeaponData : ScriptableObject
    {
        [SerializeField] DamageData baseDamage;
        [SerializeField] AttackData attack;
        
        public Damage GetDamage()
        {
            return baseDamage.GetDamage();
        }
    }
}