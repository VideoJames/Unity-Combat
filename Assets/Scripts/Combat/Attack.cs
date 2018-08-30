using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class Attack
    {
        List<Damage> damage = new List<Damage>();
        Attacker attacker;
        Defender defender;

        public Attack(Attacker attacker, Defender defender)
        {
            this.attacker = attacker;
            this.defender = defender;            
        }

        public void ProcessAttack()
        {
            Damage attackDamage = attacker.GetDamage();

            defender.ReceiveDamage(attackDamage);
        }
    }
}