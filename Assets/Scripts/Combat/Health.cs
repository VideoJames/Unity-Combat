using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxValue { get; private set; }
    public int CurrentValue { get; private set; }

    public void SetMaxValue (int maxValue)
    {
        MaxValue = maxValue;
    }

}
