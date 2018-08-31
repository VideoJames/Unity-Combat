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
        [SerializeField] GameObject weaponPrefab;
        
        public Damage GetDamage()
        {
            return baseDamage.GetDamage();
        }

        // Equip weapon method
        // Instantiate and attach the weaponprefab to the character holding it.
    }
}