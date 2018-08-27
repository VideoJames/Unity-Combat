using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class Damage
    {
        public float Value;
        public readonly bool IsCritical;    
        
        public Damage(float value, bool isCritical)
        {
            Value = value;
            IsCritical = isCritical;
        }
    }
}