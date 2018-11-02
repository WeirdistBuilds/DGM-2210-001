using UnityEngine;

[CreateAssetMenu(fileName = "NewFloat", menuName = "Scriptable Objects/SOFloat")]
public class SOFloat : ScriptableObject
{
    public float value;
    public virtual float Value
    {
        get { return value; }
    }
}
