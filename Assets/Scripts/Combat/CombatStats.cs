using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    [Serializable]
    public class CombatStats
    {
        public Stat MaxHealth;
        public float CurrentHealth { get; protected set; }

        public Stat Damage;
        public Stat Armor;

        public float GetDamage()
        {
            return Damage.GetValue();
        }
    }
}