using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackData : ScriptableObject
{
    [SerializeField] List<StatModifier> damageModifiers;

    public Attack CreateAttack(Attacker attacker)
    {
        return new Attack(GetModifiedDamage(damageModifiers, attacker.GetDamage()));
    }
    
    // TODO: This method should be moved somewhere else as it is shared by Attack and Defend Data classes
    // TODO: How can we nicely allow StatModifier to determine which stat to modify?
    public static List<Damage> GetModifiedDamage(List<StatModifier> damageModifierList, List<Damage> baseDamageList)
    {
        List<Damage> modifiedDamageList = new List<Damage>();

        foreach (Damage baseDamage in baseDamageList)
        {
            Damage modifiedDamge = new Damage(baseDamage.Value);
            foreach (StatModifier damageModifier in damageModifierList)
            {
                modifiedDamge.Value += damageModifier.GetStatModificationDelta(baseDamage.Value);
            }
        }

        return modifiedDamageList;
    }    
}
