using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{

	private CharacterController controller;
	public SOMovePattern Pattern;

	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update()
	{
		Pattern.Invoke(controller, transform);
	}
}
