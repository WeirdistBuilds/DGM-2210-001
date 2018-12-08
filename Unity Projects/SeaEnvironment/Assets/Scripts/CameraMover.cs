using UnityEngine;

public class CameraMover : MonoBehaviour {

	private Transform myTransform;

	private void Start()
	{
		myTransform = GetComponent<Transform>();
	}

	private void Update()
	{
		myTransform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);
	}
}