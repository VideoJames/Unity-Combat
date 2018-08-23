using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour, AttackReceiver, DamageMitigator
{
    public void MitigateDamage(List<DamageData> damages)
    {
        throw new System.NotImplementedException();
    }

    public void ReceiveAttack(Attack attack)
    {
        throw new System.NotImplementedException();
    }
}
