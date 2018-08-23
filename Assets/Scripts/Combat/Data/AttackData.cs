using System.Collections.Generic;
using UnityEngine;

public class AttackData : ScriptableObject
{
    [SerializeField] List<StatModifier> damageModifiers;

    public Attack CreateAttack(Attacker attacker)
    {
        return new Attack(GetModifiedDamage(damageModifiers, attacker.GetDamage()));
    }

    public static List<Damage> GetModifiedDamage(List<StatModifier> damageModifierList, List<Damage> baseDamageList)
    {
        List<Damage> modifiedDamageList = new List<Damage>();

        for (int i = 0; i < baseDamageList.Count; i++)
        {
            Damage baseDamage = baseDamageList[i];
            modifiedDamageList.Add(new Damage(baseDamage.Value));
            foreach (StatModifier damageModifier in damageModifierList)
            {
                modifiedDamageList[i].Value += damageModifier.GetStatModificationDelta(baseDamage.Value);
            }
        }

        return modifiedDamageList;
    }    
}
