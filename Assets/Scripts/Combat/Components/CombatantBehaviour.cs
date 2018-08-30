using System;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class CombatantBehaviour : MonoBehaviour, Attacker, Defender
    {
        public event Action<float> OnReceievedDamage = delegate { };

        Equipment equipment;

        public Damage GetDamage()
        {
            Damage potentialDamage = equipment.Weapon.GetDamage();
            DamageModification.ModifyDamage(potentialDamage, equipment.Armor);           
            return potentialDamage;
        }

        public void ReceiveDamage(Damage damage)
        {
            DamageModification.ModifyDamage(damage, equipment.Armor);
            OnReceievedDamage(damage.Value);
        }      
    }

    public static class DamageModification
    {
        public static void ModifyDamage(Damage damageToModify, List<StatModifier> damageModifiers)
        {
            float damageBaselineValue = damageToModify.Value;
            foreach (StatModifier damageModifier in damageModifiers)
            {
                damageToModify.Value += damageModifier.GetStatModificationDelta(damageBaselineValue);
            }
        }
    }

    public struct Equipment
    {
        public WeaponData Weapon;
        public List<StatModifier> Armor;
    }
}