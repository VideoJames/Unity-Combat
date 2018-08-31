using System;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class CombatantBehaviour : MonoBehaviour, Attacker, Defender
    {
        public event Action<float> OnReceievedDamage = delegate { };

        private CombatStats combatStats;

        public float GetDamage()
        {
            float potentialDamage = combatStats.GetDamage();
            return potentialDamage;
        }

        public void ReceiveDamage(float damage)
        {
            OnReceievedDamage(damage);
        }      
    }
}