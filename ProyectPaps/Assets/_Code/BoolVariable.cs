using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Variables/Bool")]
public class BoolVariable : ScriptableObject
{
    public string DeveloperDescription;
    public bool Value;
    public bool defaultValue;

    public void SetValue(bool value)
    {
        Value = value;
    }
}
