﻿using System.Collections.Generic;

namespace Combat
{
    public interface Defender
    {
        void ReceiveDamage(List<Damage> damage);
    }
}