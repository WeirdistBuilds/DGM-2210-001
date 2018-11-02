using UnityEngine;

[CreateAssetMenu(fileName = "NewInput", menuName = "Scriptable Objects/SOInput")]
public class SOInput : SOFloat
{
    public string InputName;

    public override float Value
    {
        get { return Input.GetAxis(InputName) * value; }
    }
}
