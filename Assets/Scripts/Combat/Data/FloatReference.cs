using System;

[Serializable]
public class FloatReference : FloatVariable
{
    public bool UseConstant = true;
    public float ConstantValue;
    public FloatVariable Variable;    

    public float Value { get { return UseConstant ? ConstantValue : Variable.RunTimeValue; } }
}
