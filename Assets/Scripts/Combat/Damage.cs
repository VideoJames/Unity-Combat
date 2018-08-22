using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Damage
{
    int BaseValue { get; }
    int CurrentValue { get; }
    void ApplyDamage(DamageReceiver damageReceiver);
}

public interface DamageReceiver
{
    void ReceiveDamage(Damage damage);
}

public interface DamageMediator
{

}
