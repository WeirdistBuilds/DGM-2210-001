using UnityEngine;

[CreateAssetMenu(fileName = "NewInputBool", menuName = "Scriptable Objects/SOInputBool")]
public class SOInputBool : SOInput
{
	public override float Value
	{
		get
		{
			if (Input.GetButton(InputName))
			{
				return value;
			}
			return 0;
		}
	}
}