using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	public float minX = -60f, maxX = 60f, minY = -360f, maxY = 360f;
	public float sensX = 15f, sensY = 15f;
	public Camera cam;

	private float rotY = 0f, rotX = 0f;
	
	
	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;

		if (Input.GetKey(KeyCode.Escape))
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
	
	void Update ()
	{
		rotY += Input.GetAxis("Mouse X") * sensY;
		rotX += Input.GetAxis("Mouse Y") * sensX;
		rotX = Mathf.Clamp(rotX, minX, maxX);
		
		transform.localEulerAngles = new Vector3(0, rotY, 0);
		cam.transform.localEulerAngles = new Vector3(-rotX, rotY, 0);
	}
}
