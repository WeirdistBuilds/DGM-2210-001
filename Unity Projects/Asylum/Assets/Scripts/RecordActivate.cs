using UnityEngine;

public class RecordActivate : MonoBehaviour
{

	private Animator animator;
	
	void Start ()
	{
		animator = GetComponent<Animator>();
	}

	void OnCollisionEnter(Collision other)
	{
		animator.SetBool("Activated", true);
	}

	void OnCollisionExit(Collision other)
	{
		animator.SetBool("Activated", false);
	}
	
	
}
