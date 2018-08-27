using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class Combatant : MonoBehaviour, Attacker, Defender
    {
        [SerializeField] List<DamageData> damageBaselines;
        [SerializeField] List<StatModifier> buffs;
        [SerializeField] List<StatModifier> defenses;

        void Awake()
        {
            Attack testAttack = new Attack(this, this);
            testAttack.ProcessAttack();
        }

        public List<Damage> GetDamage()
        {
            List<Damage> potentialDamages = GetDamageBaselines();
            DamageModification.ModifyDamages(potentialDamages, buffs);
            foreach(Damage damage in potentialDamages)
            {
                print(string.Format("Getting {0} damage", damage.Value));
            }
            
            return potentialDamages;
        }

        public void ReceiveDamage(List<Damage> damages)
        {
            DamageModification.ModifyDamages(damages, defenses);
            foreach (Damage damage in damages)
            {
                print(string.Format("Received {0} damage", damage.Value));
            }            
        }

        /// <summary>
        /// Returns a new List of Damage from the List of DamageData
        /// </summary>
        /// <returns></returns>
        List<Damage> GetDamageBaselines()
        {
            List<Damage> returnDamages = new List<Damage>();
            foreach(DamageData damageData in damageBaselines)
            {
                returnDamages.Add(damageData.GetDamage());
            }
            return returnDamages;
        }        
    }

    public static class DamageModification
    {
        public static void ModifyDamages(List<Damage> damageBaselines, List<StatModifier> damageModifiers)
        {
            foreach (Damage damage in damageBaselines)
            {
                ModifyDamage(damage, damageModifiers);
            }
        }

        public static void ModifyDamage(Damage damageToModify, List<StatModifier> damageModifiers)
        {
            float damageBaselineValue = damageToModify.Value;
            foreach (StatModifier damageModifier in damageModifiers)
            {
                damageToModify.Value += damageModifier.GetStatModificationDelta(damageBaselineValue);
            }
        }
    }
}