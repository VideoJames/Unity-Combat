using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combatant : MonoBehaviour, DamageMitigator, AttackReceiver
{
    [SerializeField]
    DefendData defenses;

    public void MitigateDamage(List<DamageData> damages)
    {
        AttackData.GetModifiedDamage(defenses.)
    }

    public void ReceiveAttack(Attack attack)
    {
        throw new System.NotImplementedException();
    }
}