using System.Collections.Generic;

public interface DamageMitigator
{
    void MitigateDamage(List<DamageData> damages);
}
