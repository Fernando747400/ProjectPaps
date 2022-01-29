using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Variables/Float")]
public class FloatVariable : ScriptableObject
{
    public string VariableDescription;
    public float Value;

    public void SetValue(float value)
    {
        Value = value;
    }

    public void addValue(float value)
    {
        Value = Value + value;
    }

    public void substractValue(float value)
    {
        Value = Value - value;
    }

}
