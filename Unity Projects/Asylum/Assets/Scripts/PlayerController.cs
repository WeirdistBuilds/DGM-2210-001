using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float Speed;
	private Rigidbody rigidbody;
	private Vector3 moveDirection;
	private Vector3 gravFix;
	private float hMove;
	private float vMove;

	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}
	
	
	void Update()
	{
		hMove = Input.GetAxis("Horizontal");
		vMove = Input.GetAxis("Vertical");

		moveDirection = (hMove * transform.right + vMove * transform.forward).normalized;
		
		gravFix = new Vector3(0, rigidbody.velocity.y, 0);
		rigidbody.velocity = moveDirection * Speed * Time.deltaTime;
		rigidbody.velocity += gravFix;
	}
}
