using UnityEngine;

public class RecordActivate : MonoBehaviour
{

	private Animator animator;
	
	void Start ()
	{
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other)
	{
		animator.SetBool("Activated", true);
	}

	void OnTriggerExit(Collider other)
	{
		animator.SetBool("Activated", false);
	}
	
	
}
